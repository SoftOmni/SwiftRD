using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class DoubleClosingAngleBracketEqualsSign : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = ">>=";

    public DoubleClosingAngleBracketEqualsSign()
        : base(new EditableBuffer(Value))
    { }

    internal DoubleClosingAngleBracketEqualsSign(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.DoubleClosingAngleBracketEqualsSign;

    public string AsString => Value;

    public static DoubleClosingAngleBracketEqualsSign Create()
    {
        return new DoubleClosingAngleBracketEqualsSign(new EditableBuffer(Value));
    }
}
