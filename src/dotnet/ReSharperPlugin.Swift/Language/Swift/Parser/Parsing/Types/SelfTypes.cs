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
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.SelfTypes;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static partial class TypeParser
    {
        private const string SelfTypeTypeKindIdentifier = "Self type"; 
        
        private static void ProcessSelfType(IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, Stack<TypeParserData> typesStack)
        {
            IEditableBuffer selfTypeBuffer = new SubEditableBuffer(buffer, currentOffset, Self.Keyword.Length);
            IEditableBuffer selfBuffer = new SubEditableBuffer(selfTypeBuffer, 0, Self.Keyword.Length);

            Self self = new(selfBuffer);
            children.Add(self);

            SelfType selfType = new(selfTypeBuffer, children, self);

            typesStack.Push(new TypeParserData(selfTypeBuffer, currentOffset, children, 
                [(self, 0)], 
                TypeParserData.TypeKind.GetOrCreate(SelfTypeTypeKindIdentifier), 
                selfType));
        }
        
        public static ISelfType ParseSelfTypeCore(IEditableBuffer content)
        {
            IEditableBuffer contentsClone = EditableBufferExtensions.CloneBuffer(content);
            
            SwiftLexer lexer = new(contentsClone);
            lexer.Start();

            int currentOffset = 0;
            List<ISwiftNode<SwiftCompositeNode>> children = [];

            currentOffset = AdvanceAndAddCommentsWhitespace(contentsClone, currentOffset, children, lexer);

            if (lexer.TokenType is not SelfUppercaseKeywordToken)
            {
                throw new SyntaxError(
                    $"To parse a self type, the first non whitespace and non comment element must be the {Self.Keyword} keyword.\n" +
                    $"The token lexed was instead {lexer.TokenType}");
            }

            IEditableBuffer selfBuffer = new SubEditableBuffer(contentsClone, currentOffset, Self.Keyword.Length);
            Self self = new(selfBuffer);
            
            children.Add(self);
            AdvanceAndAddCommentsWhitespace(contentsClone, currentOffset, children, lexer);
            if (lexer.TokenType is not EndOfFileToken)
            {
                throw new SyntaxError(
                    $"To parse a self type, the buffer must contain only whitespace, comments and the {Self.Keyword} keyword.\n" +
                    $"A token after the keyword was found not being comment or whitespace related: {lexer.TokenType}");
            }

            SelfType selfType = new(contentsClone, children, self);
            return selfType;
        }
    }

    public static ISelfType ParseSelfType(string content)
    {
        return ParseSelfType(new EditableBuffer(content));
    }

    public static ISelfType ParseSelfType(string content, int start)
    {
        return ParseSelfType(new EditableBuffer(content), start);
    }

    public static ISelfType ParseSelfType(string content, int start, int length)
    {
        return ParseSelfType(new EditableBuffer(content), start, length);
    }

    public static ISelfType ParseSelfType(StringBuilder content)
    {
        return ParseSelfType(content.ToString());
    }

    public static ISelfType ParseSelfType(StringBuilder content, int start)
    {
        return ParseSelfType(content.ToString(), start);
    }

    public static ISelfType ParseSelfType(StringBuilder content, int start, int length)
    {
        return ParseSelfType(content.ToString(), start, length);
    }

    public static ISelfType ParseSelfType(IEditableBuffer content)
    {
        return TypeParser.ParseSelfTypeCore(content);
    }

    public static ISelfType ParseSelfType(IEditableBuffer content, int start)
    {
        if (start < 0 || start > content.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }
        
        return TypeParser.ParseSelfTypeCore(new SubEditableBuffer(content, start, content.Length - start));
    }

    public static ISelfType ParseSelfType(IEditableBuffer content, int start, int length)
    {
        if (start < 0 || start > content.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (length < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }
        
        return TypeParser.ParseSelfTypeCore(new SubEditableBuffer(content, start, length));
    }

    public static ISelfType ParseSelfType(ReadOnlySpan<char> content)
    {
        IEditableBuffer buffer = new EditableBuffer(content.ToString());
        return ParseSelfType(buffer);
    }

    public static ISelfType ParseSelfType(ReadOnlySpan<char> content, int start)
    {
        return ParseSelfType(content.Slice(start));
    }

    public static ISelfType ParseSelfType(ReadOnlySpan<char> content, int start, int length)
    {
        return ParseSelfType(content.Slice(start, length));
    }
}