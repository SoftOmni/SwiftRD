using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.ForInStatements;

public class For : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "for";
    
    public ForInStatement? ForInStatement { get; internal set; }

    internal For(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.For)
    { }

    internal For(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.For)
    {
        if (parent is ForInStatement forInStatement)
        {
            ForInStatement = forInStatement;
        }
    }

    internal For(ForInStatement parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.For)
    {
        ForInStatement = parent;
    }

    public string KeywordValue => Keyword;

    public static For Create()
    {
        return new For(new EditableBuffer(Keyword));
    }

    public static For Create(ForInStatement forInStatement)
    {
        return new For(forInStatement, new EditableBuffer(Keyword));
    }

    public static For CreateUnchecked(ISwiftNode parent)
    {
        return new For(parent, new EditableBuffer(Keyword));
    }
}