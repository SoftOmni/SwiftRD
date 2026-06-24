using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

public class AssociatedType : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "associatedtype";
    
    public AssociatedTypeDeclaration? AssociatedTypeDeclaration { get; internal set; }

    internal AssociatedType(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.AssociatedType)
    { }

    internal AssociatedType(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.AssociatedType)
    {
        if (parent is AssociatedTypeDeclaration associatedTypeDeclaration)
        {
            AssociatedTypeDeclaration = associatedTypeDeclaration;
        }
    }

    internal AssociatedType(AssociatedTypeDeclaration parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.AssociatedType)
    {
        AssociatedTypeDeclaration = parent;
    }

    public string KeywordValue => Keyword;

    public static AssociatedType Create()
    {
        return new AssociatedType(new EditableBuffer(Keyword));
    }

    public static AssociatedType Create(AssociatedTypeDeclaration associatedTypeDeclaration)
    {
        return new AssociatedType(associatedTypeDeclaration, new EditableBuffer(Keyword));
    }

    public static AssociatedType CreateUnchecked(SwiftInternalNode parent)
    {
        return new AssociatedType(parent, new EditableBuffer(Keyword));
    }
}