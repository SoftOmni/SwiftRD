using System.Collections.Generic;
using JetBrains.ReSharper.Psi.JavaScript.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static partial class ExpressionParser
    {
        private struct ExpressionParserState
        {
            public enum State
            {
                NotParsed,
                TryAndAwaitParsed,
                PrefixedParsed
            }

            public List<ISwiftNode<SwiftCompositeNode>> Children { get; }

            public int StartInBuffer { get; }

            public TryExpression? TryExpression { get; set; }

            public AwaitExpression? AwaitExpression { get; set; }

            public IPrefixExpression? PrefixExpression { get; set; }

            public InfixExpressionGroup? InfixExpressionGroup { get; set; }

            public State CurrentState { get; private set; }

            public ExpressionParserState(List<ISwiftNode<SwiftCompositeNode>> children,
                int startInBuffer, State currentState = State.NotParsed)
            {
                Children = children;
                StartInBuffer = startInBuffer;
                CurrentState = currentState;
            }

            public void AssignTryAndAwaitExpressionFromParserResult(
                (TryExpression? tryExpression, AwaitExpression? awaitExpression) parserResult)
            {
                TryExpression = parserResult.tryExpression;
                AwaitExpression = parserResult.awaitExpression;

                CurrentState = State.TryAndAwaitParsed;
            }
        }

        private static void ParseExpression(SwiftLexer swiftLexer, IEditableBuffer parentBuffer,
            int currentTextOffset)
        {
            Stack<ExpressionParserState> parserStates = [];
        }

        private static void ParseExpression(SwiftLexer swiftLexer, IEditableBuffer parentBuffer,
            int currentTextOffset, Stack<ExpressionParserState> parserStates)
        {
            List<ISwiftNode<SwiftCompositeNode>> children = [];
            ExpressionParserState topLevelExpressionState = new(children, currentTextOffset);
            parserStates.Push(topLevelExpressionState);

            topLevelExpressionState.AssignTryAndAwaitExpressionFromParserResult(
                TryAndAwaitExpressionParser.EatTryAndAwaitExpressions(
                    swiftLexer, parentBuffer, currentTextOffset, children
                ));
        }
    }
}
