using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class GreaterThanOperator : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = ">";

    public GreaterThanOperator()
        : base(new EditableBuffer(Value))
    { }

    internal GreaterThanOperator(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.GreaterThanOperator;

    public string AsString => Value;

    public static GreaterThanOperator Create()
    {
        return new GreaterThanOperator(new EditableBuffer(Value));
    }
}