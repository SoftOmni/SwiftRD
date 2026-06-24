using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Open : LeafAccessLevelModifier, ISwiftKeywordNode
{
    public const string Keyword = "open";
    
    internal Open(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Open)
    { }

    internal Open(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Open)
    { }


    public string KeywordValue => Keyword;

    public static Open Create()
    {
        return new Open(new EditableBuffer(Keyword));
    }

    public static Open Create(SwiftInternalNode parent)
    {
        return new Open(new EditableBuffer(Keyword));
    }
}