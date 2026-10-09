using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class TernaryOperatorQuestionResponseSeparator : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "?";

    public TernaryOperatorQuestionResponseSeparator()
        : base(new EditableBuffer(Value))
    { }

    internal TernaryOperatorQuestionResponseSeparator(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.TernaryOperatorQuestionResponseSeparator;

    public string AsString => Value;

    public static TernaryOperatorQuestionResponseSeparator Create()
    {
        return new TernaryOperatorQuestionResponseSeparator(new EditableBuffer(Value));
    }
}
