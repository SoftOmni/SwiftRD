
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;

using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.LeafNodes;

/// <summary>
///     <para>
///         Represents a generic concrete or abstract syntax tree <see cref="INode"/> for an arbitrary language
///         that happens to be a leaf node.
///     </para>
///     <para>
///         An <see cref="ILeafNode"/> does not have any children. It is otherwise a regular <see cref="INode"/>.
///     </para>
///     <para>
///         This also doesn't assume that all the <see cref="INode"/>s of the tree
///         this <see cref="ILeafNode"/> is a part of have a particular language tied to them.
///         There could be differing languages within the same tree.
///         Use <see cref="INode{TIInternalNode, TILeafNode}"/> and <see cref="IInternalNode{TBaseNode}"/> and <see cref="ILeafNode{TBaseNode}"/>
///         to have a set of <see cref="INode"/>s that correspond to a particular language.
///     </para>
/// </summary>
/// <remarks>
///     <para>
///         For now this is simply useful for specifying a more specific type.
///         This does not have special features compared to an <see cref="INode"/> tied to it because anything
///         an <see cref="ILeafNode"/> would want to do, an <see cref="INode"/> would as well.
///     </para>
/// </remarks>
public interface ILeafNode : INode;