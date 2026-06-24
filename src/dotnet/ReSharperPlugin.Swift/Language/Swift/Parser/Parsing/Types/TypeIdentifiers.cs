using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Parsing;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static partial class TypeParser
    {
        private static void ProcessTypeIdentifier(SwiftLexer lexer, IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, Stack<TypeParserData> typesStack,
            ISwiftParsingSettings settings)
        {
            List<ITypeIdentifierComponent> components = [];

            int startOfIdentifier = currentOffset;
            int endOfIdentifier = currentOffset + lexer.TokenLength;
            List<ISwiftNode<SwiftCompositeNode>> componentChildren = [];

            List<>
            lexer.Advance();
            while (lexer.TokenType is not EndOfFileToken)
            {
                currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, componentChildren, lexer);
                if (lexer.TokenType is not PeriodToken and not LeftAngleBracketToken)
                {
                    IEditableBuffer componentBuffer =
                        new SubEditableBuffer(buffer, startOfIdentifier, endOfIdentifier - startOfIdentifier);

                    IEditableBuffer identifierBuffer =
                        new SubEditableBuffer(componentBuffer, 0, componentBuffer.Length);
                    IIdentifier identifier = new Identifier(identifierBuffer);

                    
                    if (settings.GetTrailingWhitespaceAfterElementPolicy is ISwiftParsingSettings.TrailingWhitespaceAfterElementPolicy.IncludeAsSiblingOfElement)
                    {
                        componentChildren.Clear();
                    }
                    else
                    {
                        while (componentChildren.Count > 0 && componentChildren[componentChildren.Count - 1] is IWhitespaceNode whitespaceNode)
                        {
                            componentChildren.RemoveAt(componentChildren.Count - 1);
                            
                        }
                    }
                    
                    componentChildren.Add(identifier);
                    
                    ITypeIdentifierComponent component = 
                        new TypeIdentifierComponent(componentBuffer, children, identifier);
                    break;
                }
            }
            
            
        }
    }
}
