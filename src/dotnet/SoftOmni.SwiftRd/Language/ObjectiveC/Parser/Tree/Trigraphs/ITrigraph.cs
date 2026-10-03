using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.LeafNode;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

public interface ITrigraph : IObjectiveCLeafNode<ObjectiveCCompositeNode>
{
    public char ReplacementCharacter { get; }
}
