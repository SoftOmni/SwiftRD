using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class NotEqualsOperator : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "!=";

    public NotEqualsOperator()
        : base(new EditableBuffer(Value))
    { }

    internal NotEqualsOperator(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.NotEqualsOperator;

    public string AsString => Value;

    public static NotEqualsOperator Create()
    {
        return new NotEqualsOperator(new EditableBuffer(Value));
    }
}