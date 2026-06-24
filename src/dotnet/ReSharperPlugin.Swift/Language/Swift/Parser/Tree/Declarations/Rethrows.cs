using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

public class Rethrows : TypeLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "Rethrows";
    
    internal Rethrows(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Rethrows)
    { }

    internal Rethrows(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Rethrows)
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