using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.AnyTypes;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static partial class TypeParser
    {
        private const string AnyTypeTypeKindIdentifier = "Any type"; 

        private static void ProcessAnyType(IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, Stack<TypeParserData> typesStack)
        {
            IEditableBuffer anyUppercaseTypeBuffer =
                new SubEditableBuffer(buffer, currentOffset, AnyUppercase.Keyword.Length);
            IEditableBuffer anyUppercaseBuffer =
                new SubEditableBuffer(anyUppercaseTypeBuffer, 0, AnyUppercase.Keyword.Length);

            AnyUppercase anyUppercase = new(anyUppercaseBuffer);
            children.Add(anyUppercase);

            AnyType anyType = new(anyUppercaseTypeBuffer, children, anyUppercase);

            typesStack.Push(new TypeParserData(anyUppercaseTypeBuffer, currentOffset, children,
                [(anyUppercase, 0)],
                TypeParserData.TypeKind.GetOrCreate(AnyTypeTypeKindIdentifier), 
                anyType));
        }
        
        public static IAnyType ParseAnyTypeCore(IEditableBuffer content)
        {
            IEditableBuffer contentsClone = EditableBufferExtensions.CloneBuffer(content);
            
            SwiftLexer lexer = new(contentsClone);
            lexer.Start();

            int currentOffset = 0;
            List<ISwiftNode<SwiftCompositeNode>> children = [];

            currentOffset = AdvanceAndAddCommentsWhitespace(contentsClone, currentOffset, children, lexer);

            if (lexer.TokenType is not AnyUppercaseKeywordToken)
            {
                throw new SyntaxError(
                    $"To parse a any type, the first non whitespace and non comment element must be the {AnyUppercase.Keyword} keyword.\n" +
                    $"The token lexed was instead {lexer.TokenType}");
            }

            IEditableBuffer anyBuffer = new SubEditableBuffer(contentsClone, currentOffset, AnyUppercase.Keyword.Length);
            AnyUppercase any = new(anyBuffer);
            
            children.Add(any);
            AdvanceAndAddCommentsWhitespace(contentsClone, currentOffset, children, lexer);
            if (lexer.TokenType is not EndOfFileToken)
            {
                throw new SyntaxError(
                    $"To parse a any type, the buffer must contain only whitespace, comments and the {AnyUppercase.Keyword} keyword.\n" +
                    $"A token after the keyword was found not being comment or whitespace related: {lexer.TokenType}");
            }

            AnyType anyType = new(contentsClone, children, any);
            return anyType;
        }
    }
    
    public static IAnyType ParseAnyType(string content)
    {
        return ParseAnyType(new EditableBuffer(content));
    }

    public static IAnyType ParseAnyType(string content, int start)
    {
        return ParseAnyType(new EditableBuffer(content), start);
    }

    public static IAnyType ParseAnyType(string content, int start, int length)
    {
        return ParseAnyType(new EditableBuffer(content), start, length);
    }

    public static IAnyType ParseAnyType(StringBuilder content)
    {
        return ParseAnyType(content.ToString());
    }

    public static IAnyType ParseAnyType(StringBuilder content, int start)
    {
        return ParseAnyType(content.ToString(), start);
    }

    public static IAnyType ParseAnyType(StringBuilder content, int start, int length)
    {
        return ParseAnyType(content.ToString(), start, length);
    }

    public static IAnyType ParseAnyType(IEditableBuffer content)
    {
        return TypeParser.ParseAnyTypeCore(content);
    }

    public static IAnyType ParseAnyType(IEditableBuffer content, int start)
    {
        if (start < 0 || start > content.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }
        
        return TypeParser.ParseAnyTypeCore(new SubEditableBuffer(content, start, content.Length - start));
    }

    public static IAnyType ParseAnyType(IEditableBuffer content, int start, int length)
    {
        if (start < 0 || start > content.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (length < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }
        
        return TypeParser.ParseAnyTypeCore(new SubEditableBuffer(content, start, length));
    }

    public static IAnyType ParseAnyType(ReadOnlySpan<char> content)
    {
        IEditableBuffer buffer = new EditableBuffer(content.ToString());
        return ParseAnyType(buffer);
    }

    public static IAnyType ParseAnyType(ReadOnlySpan<char> content, int start)
    {
        return ParseAnyType(content.Slice(start));
    }

    public static IAnyType ParseAnyType(ReadOnlySpan<char> content, int start, int length)
    {
        return ParseAnyType(content.Slice(start, length));
    }
}
