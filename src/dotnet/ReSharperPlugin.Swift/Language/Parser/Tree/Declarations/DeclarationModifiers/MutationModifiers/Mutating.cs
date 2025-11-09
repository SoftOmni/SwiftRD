using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public class Mutating : MutationModifier, ISwiftKeyword
{
    public const string Keyword = "mutating";

    internal Mutating(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.Mutating)
    { }

    internal Mutating(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Mutating)
    { }


    public string KeywordValue => Keyword;

    public static Mutating Create()
    {
        return new Mutating(new EditableBuffer(Keyword));
    }

    public static Mutating Create(ISwiftNode parent)
    {
        return new Mutating(new EditableBuffer(Keyword));
    }
}