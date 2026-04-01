using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Static : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "static";
    
    internal Static(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Static, buffer)
    { }

    internal Static(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Static)
    { }


    public string KeywordValue => Keyword;

    public static Static Create()
    {
        return new Static(new EditableBuffer(Keyword));
    }

    public static Static Create(SwiftInternalNode parent)
    {
        return new Static(new EditableBuffer(Keyword));
    }
}