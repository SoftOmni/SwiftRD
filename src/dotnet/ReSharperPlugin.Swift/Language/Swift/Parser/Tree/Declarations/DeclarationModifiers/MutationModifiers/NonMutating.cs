using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public class NonMutating : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<NonMutating>
{
    public const string Keyword = "nonmutating";
    
    public NonMutating()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal NonMutating(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.NonMutating;

    public string KeywordValue => Keyword;

    public static NonMutating Create()
    {
        return new NonMutating(new EditableBuffer(Keyword));
    }
}
