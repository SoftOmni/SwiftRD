using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.FunctionTypes;

public class Throws: SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "throws";
    
    public ThrowsClause? ThrowsClause { get; internal set; }
    
    internal Throws(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Throws)
    { }

    internal Throws(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Throws)
    {
        if (parent is ThrowsClause throwsClause)
        {
            ThrowsClause = throwsClause;
        }
    }

    internal Throws(ThrowsClause parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Throws)
    {
        ThrowsClause = parent;
    }


    public string KeywordValue => Keyword;

    public static Throws Create()
    {
        return new Throws(new EditableBuffer(Keyword));
    }

    public static Throws Create(ThrowsClause parent)
    {
        return new Throws(new EditableBuffer(Keyword));
    }
    
    public static Throws CreateUnchecked(ISwiftNode parent)
    {
        return new Throws(new EditableBuffer(Keyword));
    }
}