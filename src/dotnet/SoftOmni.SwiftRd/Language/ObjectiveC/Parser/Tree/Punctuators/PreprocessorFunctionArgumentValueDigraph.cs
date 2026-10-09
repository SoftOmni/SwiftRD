using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class PreprocessorFunctionArgumentValueDigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "%:";

    public PreprocessorFunctionArgumentValueDigraph()
        : base(new EditableBuffer(Value))
    { }

    internal PreprocessorFunctionArgumentValueDigraph(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.PreprocessorFunctionArgumentValueDigraph;

    public string AsString => Value;

    public static PreprocessorFunctionArgumentValueDigraph Create()
    {
        return new PreprocessorFunctionArgumentValueDigraph(new EditableBuffer(Value));
    }
}
