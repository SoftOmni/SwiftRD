using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Dynamic : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "dynamic";
    
    internal Dynamic(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Dynamic, buffer)
    { }

    internal Dynamic(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Dynamic)
    { }


    public string KeywordValue => Keyword;

    public static Dynamic Create()
    {
        return new Dynamic(new EditableBuffer(Keyword));
    }

    public static Dynamic Create(SwiftInternalNode parent)
    {
        return new Dynamic(new EditableBuffer(Keyword));
    }
}