using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords;

public interface IObjectiveCKeyword : IObjectiveCNode<ObjectiveCCompositeNode>
{
    public string KeywordValue { get; }
}
