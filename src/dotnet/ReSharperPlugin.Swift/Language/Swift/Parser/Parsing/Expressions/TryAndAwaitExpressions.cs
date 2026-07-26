using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static class TryAndAwaitExpressionParser
    {
        public static (TryExpression? tryExpression, AwaitExpression? awaitExpression)
            EatTryAndAwaitExpressions(
                SwiftLexer swiftLexer,
                IEditableBuffer parentEditableBuffer,
                int currentTextOffset,
                List<ISwiftNode<SwiftCompositeNode>> children
            )
        {
            if (swiftLexer.TokenType is not TryKeywordToken and not AwaitKeywordToken)
            {
                return (null, null);
            }

            TryExpression? tryExpression = null;
            AwaitExpression? awaitExpression = null;
            if (swiftLexer.TokenType is TryKeywordToken)
            {
                tryExpression = EatTryExpression(swiftLexer, parentEditableBuffer, currentTextOffset);
                children.Add(tryExpression);
            }
            else
            {
                awaitExpression = EatAwaitExpression(swiftLexer, parentEditableBuffer, currentTextOffset);
                children.Add(awaitExpression);
            }
            
            // TODO: investigate whether it is allowed to have an await before a try
            if (swiftLexer.TokenType is not TryKeywordToken and not AwaitKeywordToken)
            {
                return (tryExpression, awaitExpression);
            }

            if (swiftLexer.TokenType is TryKeywordToken && tryExpression is not null)
            {
                return (tryExpression, awaitExpression);
            }

            if (swiftLexer.TokenType is AwaitKeywordToken && awaitExpression is not null)
            {
                return (tryExpression, awaitExpression);
            }

            if (swiftLexer.TokenType is TryKeywordToken)
            {
                tryExpression = EatTryExpression(swiftLexer, parentEditableBuffer, currentTextOffset);
                children.Add(tryExpression);
            }
            else
            {
                awaitExpression = EatAwaitExpression(swiftLexer, parentEditableBuffer, currentTextOffset);
                children.Add(awaitExpression);
            }

            return (tryExpression, awaitExpression);
        }

        private static TryExpression EatTryExpression(
            SwiftLexer swiftLexer,
            IEditableBuffer parentEditableBuffer,
            int currentTextOffset
        )
        {
            IEditableBuffer tryExpressionBuffer;
            IEditableBuffer tryKeywordBuffer;

            Try @try;
            swiftLexer.Advance();
            if (swiftLexer.TokenType is not QuestionMarkToken and not ExclamationMarkToken)
            {
                tryExpressionBuffer =
                    new SubEditableBuffer(parentEditableBuffer, currentTextOffset, swiftLexer.TokenLength);
                tryKeywordBuffer =
                    new SubEditableBuffer(tryExpressionBuffer, 0, Try.Keyword.Length);

                @try = new Try(tryKeywordBuffer);

                return new TryExpression(tryExpressionBuffer, [@try], @try);
            }

            tryExpressionBuffer =
                new SubEditableBuffer(parentEditableBuffer, currentTextOffset,
                    Try.Keyword.Length + swiftLexer.TokenLength);

            tryKeywordBuffer = new SubEditableBuffer(tryExpressionBuffer, 0, Try.Keyword.Length);
            @try = new Try(tryKeywordBuffer);

            IEditableBuffer subsequentElementBuffer = new SubEditableBuffer(tryExpressionBuffer,
                @try.GetTextLength(), swiftLexer.TokenLength);

            ISwiftNode<SwiftCompositeNode> subsequentElement =
                swiftLexer.TokenType is QuestionMarkToken
                    ? new QuestionMark(subsequentElementBuffer)
                    : new ExclamationMark(subsequentElementBuffer);
            
            // TODO: Investigate weather to add comments or whitespace to the children
            if (swiftLexer.TokenType is QuestionMarkToken)
            {
                return new TryExpression(tryExpressionBuffer,
                    [@try, subsequentElement], @try, (QuestionMark)subsequentElement);
            }

            return new TryExpression(tryExpressionBuffer,
                [@try, subsequentElement], @try, (ExclamationMark)subsequentElement);
        }

        private static AwaitExpression EatAwaitExpression(
            SwiftLexer swiftLexer,
            IEditableBuffer parentTextBuffer,
            int currentOffset)
        {
            IEditableBuffer awaitExpressionBuffer =
                new SubEditableBuffer(parentTextBuffer, currentOffset, swiftLexer.TokenLength);

            IEditableBuffer awaitKeywordBuffer =
                new SubEditableBuffer(awaitExpressionBuffer, 0, swiftLexer.TokenLength);

            Await @await = new(awaitKeywordBuffer);
            AwaitExpression awaitExpression
                = new (awaitExpressionBuffer, [await], await);

            swiftLexer.Advance();
            return awaitExpression;
        }
    }
}
