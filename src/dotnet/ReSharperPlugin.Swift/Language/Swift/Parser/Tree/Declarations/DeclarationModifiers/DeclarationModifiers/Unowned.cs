using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Unowned : DeclarationModifierLeaf, ISwiftKeywordNode
{
    public const string Keyword = "unowned";
    
    internal Unowned(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Unowned, buffer)
    { }

    internal Unowned(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Unowned)
    { }


    public string KeywordValue => Keyword;

    public static Unowned Create()
    {
        return new Unowned(new EditableBuffer(Keyword));
    }

    public static Unowned Create(SwiftInternalNode parent)
    {
        return new Unowned(new EditableBuffer(Keyword));
    }
}