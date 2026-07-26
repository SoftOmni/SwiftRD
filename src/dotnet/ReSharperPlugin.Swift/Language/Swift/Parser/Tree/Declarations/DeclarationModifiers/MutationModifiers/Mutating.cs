using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public class Mutating : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Mutating>
{
    public const string Keyword = "mutating";
    
    public Mutating()
        : base(new EditableBuffer(Keyword))
    { }

    internal Mutating(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Mutating;

    public string KeywordValue => Keyword;

    public static Mutating Create()
    {
        return new Mutating(new EditableBuffer(Keyword));
    }
}
