using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class OpeningAngleBracketEqualsSign : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "<=";

    public OpeningAngleBracketEqualsSign()
        : base(new EditableBuffer(Value))
    { }

    internal OpeningAngleBracketEqualsSign(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.OpeningAngleBracketEqualsSign;

    public string AsString => Value;

    public static OpeningAngleBracketEqualsSign Create()
    {
        return new OpeningAngleBracketEqualsSign(new EditableBuffer(Value));
    }
}