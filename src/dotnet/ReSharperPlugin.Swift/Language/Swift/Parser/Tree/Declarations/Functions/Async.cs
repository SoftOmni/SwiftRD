using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public class Async: SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "async";
    
    internal Async(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Async)
    { }

    internal Async(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Async)
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