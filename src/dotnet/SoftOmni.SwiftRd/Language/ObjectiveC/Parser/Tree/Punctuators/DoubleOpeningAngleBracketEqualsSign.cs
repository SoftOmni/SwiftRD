using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class DoubleOpeningAngleBracketEqualsSign : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "<<=";

    public DoubleOpeningAngleBracketEqualsSign()
        : base(new EditableBuffer(Value))
    { }

    internal DoubleOpeningAngleBracketEqualsSign(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.DoubleOpeningAngleBracketEqualsSign;

    public string AsString => Value;

    public static DoubleOpeningAngleBracketEqualsSign Create()
    {
        return new DoubleOpeningAngleBracketEqualsSign(new EditableBuffer(Value));
    }
}
