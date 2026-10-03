using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

public class ClosingCurlyBraceTrigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, ITrigraph
{
    public const char EquivalentCharacter = '}';
    
    internal ClosingCurlyBraceTrigraph(IEditableBuffer buffer)
        : base(buffer)
    { }
    
    public ClosingCurlyBraceTrigraph()
        : base(new EditableBuffer(EquivalentCharacter.ToString()))
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.ClosingCurlyBraceTrigraph;

    public char ReplacementCharacter => EquivalentCharacter;

    public static ClosingCurlyBraceTrigraph Create()
    {
        return new ClosingCurlyBraceTrigraph(new EditableBuffer(EquivalentCharacter.ToString()));
    }
}
