using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

public class OpeningCurlyBraceTrigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, ITrigraph
{
    public const char EquivalentCharacter = '{';
    
    internal OpeningCurlyBraceTrigraph(IEditableBuffer buffer)
        : base(buffer)
    { }
    
    public OpeningCurlyBraceTrigraph()
        : base(new EditableBuffer(EquivalentCharacter.ToString()))
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.OpeningCurlyBraceTrigraph;

    public char ReplacementCharacter => EquivalentCharacter;

    public static OpeningCurlyBraceTrigraph Create()
    {
        return new OpeningCurlyBraceTrigraph(new EditableBuffer(EquivalentCharacter.ToString()));
    }
}