using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

public class VerticalSlashTrigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, ITrigraph
{
    public const char EquivalentCharacter = '|';
    
    internal VerticalSlashTrigraph(IEditableBuffer buffer)
        : base(buffer)
    { }
    
    public VerticalSlashTrigraph()
        : base(new EditableBuffer(EquivalentCharacter.ToString()))
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.VerticalSlashTrigraph;

    public char ReplacementCharacter => EquivalentCharacter;

    public static VerticalSlashTrigraph Create()
    {
        return new VerticalSlashTrigraph(new EditableBuffer(EquivalentCharacter.ToString()));
    }
}