using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class CompoundBitwiseAndOperator : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "&=";

    public CompoundBitwiseAndOperator()
        : base(new EditableBuffer(Value))
    { }

    internal CompoundBitwiseAndOperator(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.CompoundBitwiseAndOperator;

    public string AsString => Value;

    public static CompoundBitwiseAndOperator Create()
    {
        return new CompoundBitwiseAndOperator(new EditableBuffer(Value));
    }
}
