using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class PreprocessorConcatenateOperatorDigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "%:%:";

    public PreprocessorConcatenateOperatorDigraph()
        : base(new EditableBuffer(Value))
    { }

    internal PreprocessorConcatenateOperatorDigraph(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.PreprocessorConcatenateOperatorDigraph;

    public string AsString => Value;

    public static PreprocessorConcatenateOperatorDigraph Create()
    {
        return new PreprocessorConcatenateOperatorDigraph(new EditableBuffer(Value));
    }
}
