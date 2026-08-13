using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Operators.BuiltinOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Operators.UserDefinedOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Parsing;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.InfixOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private const string GenericArgumentClauseTypeKindIdentifier = "Type identifier generic argument clause";

    private static partial class TypeParser
    {
        private static (IGenericArgumentClause? genericArgumentClause, TypeParserData?
            genericArgumentStackTypeParserData) ProcessGenericArgumentClause(SwiftLexer lexer, IEditableBuffer buffer,
                int currentOffset, LeftAngleBracket leftAngleBracket,
                List<ISwiftNode<SwiftCompositeNode>> children, Stack<TypeParserData> typesStack,
                ISwiftParsingSettings settings)
        {
            SubEditableBuffer genericArgumentClauseBuffer = new(buffer,
                currentOffset - leftAngleBracket.GetTextLength(), leftAngleBracket.GetTextLength());
            currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);
            List<Comma> parameterSeparators = [];
            List<IGenericArgument> arguments = [];
            List<IGenericParameter> undesiredParameters = [];
            List<(ISwiftNode<SwiftCompositeNode> significantChild, int position)> significantChildData =
                [(leftAngleBracket, 0)];

            SubEditableBuffer genericArgumentBuffer = new(buffer, 0);
            List<ISwiftNode<SwiftCompositeNode>> genericArgumentChildren = [];
            int genericArgumentOffset = 0;

            while (lexer.TokenType is not EndOfFileToken and not RightAngleBracketToken)
            {
                genericArgumentClauseBuffer.SetLengthToParentOffset(currentOffset);

                if (lexer.TokenType is CommaToken)
                {
                    IEditableBuffer separatorBuffer =
                        new SubEditableBuffer(genericArgumentClauseBuffer, currentOffset, lexer.TokenLength);
                    Comma separator = new(separatorBuffer);

                    significantChildData.Add((separator, -significantChildData.Count));
                    children.Add(separator);
                    parameterSeparators.Add(separator);

                    currentOffset += lexer.TokenLength;
                    lexer.Advance();
                    genericArgumentBuffer = new SubEditableBuffer(genericArgumentClauseBuffer, currentOffset);
                    genericArgumentOffset = 0;
                    genericArgumentChildren = [];

                    continue;
                }

                if (lexer.TokenType is OperatorToken)
                {
                    if (lexer.TokenType is OptionalChainingOperatorToken or TernaryOperatorToken)
                    {
                        if (settings.GetOptionalQuestionMarkInGenericArgumentClauseInTypeIdentifierPolicy is
                            ISwiftParsingSettings.OptionalQuestionMarkInGenericArgumentClauseInTypeIdentifier
                                .TreatAsUnsuitableOperator)
                        {
                            switch (settings.GetCompletelyUnsuitableOperatorBehavior)
                            {
                                case ISwiftParsingSettings.UnsuitableOperatorBehavior
                                    .InterruptOverallElementIncludingEnclosingListIfPresent:
                                    TypeParserData genericArgumentParserData = new(genericArgumentClauseBuffer,
                                        currentOffset, children, significantChildData,
                                        TypeParserData.TypeKind.GetOrCreate(GenericArgumentClauseTypeKindIdentifier));
                                    return (null, genericArgumentParserData);
                                case ISwiftParsingSettings.UnsuitableOperatorBehavior
                                    .InterruptOverallElementNotIncludingEnclosingListIfPresent:
                                    
                                    break;
                                case ISwiftParsingSettings.UnsuitableOperatorBehavior.ContinueNormally:
                                    IEditableBuffer operatorBuffer =
                                        new SubEditableBuffer(genericArgumentBuffer, genericArgumentOffset);
                                    if (lexer.TokenType is OptionalChainingOperatorToken)
                                    {
                                        genericArgumentChildren.Add(new PrefixOperator(operatorBuffer));
                                    }
                                    else
                                    {
                                        genericArgumentChildren.Add(new InfixOperator(operatorBuffer));
                                    }

                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                        }
                        else
                        { }
                    }

                    if (lexer.TokenLength != 1 && lexer.TokenLength != '-')
                    { }
                }
            }
        }
    }
}