using System.Collections.Generic;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.ErrorNodes;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;

public class SwiftErrorInternalNode<TSelf> : ErrorInternalNode<ISwiftNodeFamily<TSelf>, TSelf, SwiftLeafNode<TSelf>>, ISwiftInternalNode<TSelf>
    where TSelf : SwiftInternalNode<TSelf>
{
    protected SwiftErrorInternalNode(IEditableBuffer buffer, string message)
        : base(buffer, message)
    { }

    protected SwiftErrorInternalNode(TSelf parent, int index, IEditableBuffer editableBuffer, string message, IEnumerable<ISwiftNode<TSelf>>? children = null)
        : base(parent, index, editableBuffer, children, message)
    { }

    protected SwiftErrorInternalNode(TSelf parent, int index, int textIndex, int lengthInParent, string message, IEnumerable<ISwiftNode<TSelf>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children, message)
    { }

    public override PsiLanguageType Language => SwiftLanguage.Instance!;

    public override NodeType NodeType => SwiftNodeTypes.Internal;
}