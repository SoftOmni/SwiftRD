using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.ActorIsolationModifiers;

public class NonIsolated : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<NonIsolated>
{
    public const string Keyword = "nonisolated";
    
    public NonIsolated()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal NonIsolated(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.NonIsolated;

    public string KeywordValue => Keyword;

    public static NonIsolated Create()
    {
        return new NonIsolated(new EditableBuffer(Keyword));
    }
}
