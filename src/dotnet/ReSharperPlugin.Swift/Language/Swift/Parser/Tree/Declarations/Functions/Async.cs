using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions;

public class Async: SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "async";
    
    internal Async(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Async)
    { }

    internal Async(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Async)
    { }


    public string KeywordValue => Keyword;

    public static Async Create()
    {
        return new Async(new EditableBuffer(Keyword));
    }

    public static Async Create(SwiftInternalNode parent)
    {
        return new Async(new EditableBuffer(Keyword));
    }
}