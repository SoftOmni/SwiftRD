using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class GreaterThanOrEqualsOperator : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = ">=";

    public GreaterThanOrEqualsOperator()
        : base(new EditableBuffer(Value))
    { }

    internal GreaterThanOrEqualsOperator(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.GreaterThanOrEqualsOperator;

    public string AsString => Value;

    public static GreaterThanOrEqualsOperator Create()
    {
        return new GreaterThanOrEqualsOperator(new EditableBuffer(Value));
    }
}
