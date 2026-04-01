using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.CppInterop;

public interface ICppExposableNode<out TCppNode> : INode
{
    TCppNode EquivalentCppNode { get; }

    void AdjustCppResolveEngine();
}