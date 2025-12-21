using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations;

public class Rethrows : TypeLeafNode, ISwiftKeyword
{
    public const string Keyword = "Rethrows";
    
    internal Rethrows(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Rethrows)
    { }

    internal Rethrows(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Rethrows)
    { }

    public string KeywordValue => Keyword;

    public static Rethrows Create()
    {
        return new Rethrows(new EditableBuffer(Keyword));
    }
    
    public static Rethrows Create(SwiftInternalNode parent)
    {
        return new Rethrows(parent, new EditableBuffer(Keyword));
    }
}