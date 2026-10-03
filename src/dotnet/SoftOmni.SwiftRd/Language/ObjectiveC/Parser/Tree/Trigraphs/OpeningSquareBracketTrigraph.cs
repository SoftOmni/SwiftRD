using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

public class OpeningSquareBracketTrigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, ITrigraph
{
    public const char EquivalentCharacter = '[';
    
    internal OpeningSquareBracketTrigraph(IEditableBuffer buffer)
        : base(buffer)
    { }
    
    public OpeningSquareBracketTrigraph()
        : base(new EditableBuffer(EquivalentCharacter.ToString()))
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.OpeningSquareBracketTrigraph;

    public char ReplacementCharacter => EquivalentCharacter;

    public static OpeningSquareBracketTrigraph Create()
    {
        return new OpeningSquareBracketTrigraph(new EditableBuffer(EquivalentCharacter.ToString()));
    }
}