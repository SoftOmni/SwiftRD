using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public class Unsafe : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "unsafe";
    
    public UnownedUnsafe? UnownedUnsafe { get; internal set; }

    internal Unsafe(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Unsafe)
    { }

    internal Unsafe(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Unsafe)
    {
        if (parent is UnownedUnsafe unownedUnsafe)
        {
            UnownedUnsafe = unownedUnsafe;
        }
    }

    internal Unsafe(UnownedUnsafe parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Unsafe)
    {
        UnownedUnsafe = parent;
    }

    public string KeywordValue => Keyword;

    public static Unsafe Create()
    {
        return new Unsafe(new EditableBuffer(Keyword));
    }

    public static Unsafe Create(UnownedUnsafe unownedUnsafe)
    {
        return new Unsafe(unownedUnsafe, new EditableBuffer(Keyword));
    }

    public static Unsafe CreateUnchecked(SwiftInternalNode parent)
    {
        return new Unsafe(parent, new EditableBuffer(Keyword));
    }
}