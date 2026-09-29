using JetBrains.ReSharper.Psi.Cpp.Tree;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.CppInterop;

public interface ICppExposableComposableNode : ICppExposableNode<CppCompositeNode>, IInternalNode;
