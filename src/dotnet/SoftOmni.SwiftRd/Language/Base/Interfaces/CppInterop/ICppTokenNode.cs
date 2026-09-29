using JetBrains.ReSharper.Psi.Tree;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.CppInterop;

public interface ICppTokenNode : ICppExposableNode<ITokenNode>, ILeafNode;