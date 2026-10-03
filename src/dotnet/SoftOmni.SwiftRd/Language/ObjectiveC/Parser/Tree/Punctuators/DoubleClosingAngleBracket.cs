using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class DoubleClosingAngleBracket : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = ">>";

    public DoubleClosingAngleBracket()
        : base(new EditableBuffer(Value))
    { }

    internal DoubleClosingAngleBracket(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.DoubleClosingAngleBracket;

    public string AsString => Value;

    public static DoubleClosingAngleBracket Create()
    {
        return new DoubleClosingAngleBracket(new EditableBuffer(Value));
    }
}