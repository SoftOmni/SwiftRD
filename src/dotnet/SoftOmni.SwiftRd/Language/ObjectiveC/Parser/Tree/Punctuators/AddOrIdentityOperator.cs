using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class AddOrIdentityOperator : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "+";

    public AddOrIdentityOperator()
        : base(new EditableBuffer(Value))
    { }

    internal AddOrIdentityOperator(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.AddOrIdentityOperator;

    public string AsString => Value;

    public static AddOrIdentityOperator Create()
    {
        return new AddOrIdentityOperator(new EditableBuffer(Value));
    }
}