using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public class Mutating : MutationModifier, ISwiftKeyword
{
    public const string Keyword = "mutating";

    internal Mutating(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.Mutating)
    { }

    internal Mutating(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Mutating)
    { }


    public string KeywordValue => Keyword;

    public static Mutating Create()
    {
        return new Mutating(new EditableBuffer(Keyword));
    }

    public static Mutating Create(SwiftInternalNode parent)
    {
        return new Mutating(new EditableBuffer(Keyword));
    }
}