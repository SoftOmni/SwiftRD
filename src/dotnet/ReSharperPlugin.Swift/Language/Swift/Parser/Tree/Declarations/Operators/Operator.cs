using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

public class Operator : SwiftLeafNode
{
    public Operator(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.Operator)
    { }

    public Operator(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Operator)
    { }
}