using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

public class ClosingSquareBracketTrigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, ITrigraph
{
    public const char EquivalentCharacter = ']';
    
    internal ClosingSquareBracketTrigraph(IEditableBuffer buffer)
        : base(buffer)
    { }
    
    public ClosingSquareBracketTrigraph()
        : base(new EditableBuffer(EquivalentCharacter.ToString()))
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.ClosingSquareBracketTrigraph;

    public char ReplacementCharacter => EquivalentCharacter;

    public static ClosingSquareBracketTrigraph Create()
    {
        return new ClosingSquareBracketTrigraph(new EditableBuffer(EquivalentCharacter.ToString()));
    }
}