using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Parsing;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static class GenericArgumentClauseParser
    {
        public static IGenericArgumentClause ParseGenericArgumentClauseWithStart(SwiftLexer lexer, IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, LeftAngleBracket? leftAngleBracket, ISwiftParsingSettings parsingSettings)
        {
            currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);
            if (lexer.TokenType is EndOfFileToken)
            {
                return new IncompleteGenericArgumentClause(buffer, "Missing closing > with generic arguments", leftAngleBracket);
            }

            if (lexer.TokenType is RightAngleBracketToken)
            {
                RightAngleBracket rightAngleBracket = new(new SubEditableBuffer(buffer, currentOffset, lexer.TokenLength));
                return new IncompleteGenericArgumentClause(buffer, "Missing generic arguments", leftAngleBracket,
                    rightAngleBracket: rightAngleBracket);
            }

            bool canBeReasonablyInterpretedAsType = TypeExtensions.CanBeReasonablyInterpretedAsType(lexer);
            if (!canBeReasonablyInterpretedAsType)
            {
                return new IncompleteGenericArgumentClause(buffer, "Missing closing > with generic arguments", leftAngleBracket);
            }

            return ParseGenericArguments(lexer, buffer, currentOffset, children, leftAngleBracket, parsingSettings);
        }

        private static IGenericArgumentClause ParseGenericArguments(SwiftLexer lexer, IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, LeftAngleBracket? leftAngleBracket, ISwiftParsingSettings parsingSettings)
        {
            bool canBeReasonablyInterpretedAsType = true;
            int initialOffset = currentOffset;

            List<IType> types = [];
            List<IGenericArgument> genericArguments = [];
            List<Comma> commas = [];

            while (canBeReasonablyInterpretedAsType && lexer.TokenType is not RightAngleBracketToken)
            {
                IType type = ParseType();
                IGenericArgument genericArgument;

                currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);
                // TODO: Finish me
                if (lexer.TokenType is not CommaToken)
                {
                    canBeReasonablyInterpretedAsType = TypeExtensions.CanBeReasonablyInterpretedAsType(lexer);
                    if (parsingSettings.GetGenericsClauseUnendedBehavior is ISwiftParsingSettings.GenericsClauseUnendedBehavior.ConsiderTypeWithoutCommaBePart)
                    {
                        genericArgument = new GenericArgument(type);
                        
                        types.Add(type);
                        genericArguments.Add(genericArgument);
                        
                        children.Add(type);
                    }
                    
                    IncompleteGenericArgumentGroup incompleteGenericArgumentGroup =
                        new(new SubEditableBuffer(buffer, initialOffset, currentOffset - initialOffset),
                            children, genericArguments, types, commas, "Missing closing > of generic arguments clause");

                    return new IncompleteGenericArgumentClause(buffer, "Missing closing > of generic arguments clause",
                        leftAngleBracket, incompleteGenericArgumentGroup);
                }
                
                genericArgument = new GenericArgument(type);
                
                types.Add(type);
                genericArguments.Add(genericArgument);
                
                currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);
                if (lexer.TokenType is CommaToken)
                {
                    Comma comma = new(new SubEditableBuffer(buffer, currentOffset, lexer.TokenLength));
                    commas.Add(comma);
                }
            }
            
            
        }
    }
    
    private static IGenericArgumentClause ParseGenericArgumentClauseWithStart(SwiftLexer lexer, IEditableBuffer buffer,
        int currentOffset,
        List<ISwiftNode<SwiftCompositeNode>> children, LeftAngleBracket? leftAngleBracket, ISwiftParsingSettings swiftParsingSettings)
    {
        return GenericArgumentClauseParser.ParseGenericArgumentClauseWithStart(lexer, buffer, currentOffset, children, leftAngleBracket);
    }

    public static IGenericArgumentClause ParseGenericArgumentClause(string code)
    {
        throw new NotImplementedException();
    }

    public static IGenericArgumentClause ParseGenericArgumentClause(ReadOnlySpan<char> code)
    {
        throw new NotImplementedException();
    }
}