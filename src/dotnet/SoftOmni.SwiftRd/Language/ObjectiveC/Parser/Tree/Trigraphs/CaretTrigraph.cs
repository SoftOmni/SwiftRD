using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

public class CaretTrigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, ITrigraph
{
    public const char EquivalentCharacter = '^';
    
    internal CaretTrigraph(IEditableBuffer buffer)
        : base(buffer)
    { }
    
    public CaretTrigraph()
        : base(new EditableBuffer(EquivalentCharacter.ToString()))
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.CaretTrigraph;

    public char ReplacementCharacter => EquivalentCharacter;

    public static CaretTrigraph Create()
    {
        return new CaretTrigraph(new EditableBuffer(EquivalentCharacter.ToString()));
    }
}
