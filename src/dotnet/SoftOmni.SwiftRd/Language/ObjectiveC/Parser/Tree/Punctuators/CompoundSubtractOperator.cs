using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class CompoundSubtractOperator : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "-=";

    public CompoundSubtractOperator()
        : base(new EditableBuffer(Value))
    { }

    internal CompoundSubtractOperator(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.CompoundSubtractOperator;

    public string AsString => Value;

    public static CompoundSubtractOperator Create()
    {
        return new CompoundSubtractOperator(new EditableBuffer(Value));
    }
}