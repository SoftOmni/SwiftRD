using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public abstract class ParameterModifier : SwiftLeafNode
{
    public Parameter? Parameter { get; internal set; }

    internal ParameterModifier(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    internal ParameterModifier(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    {
        if (parent is Parameter parameter)
        {
            Parameter = parameter;
        }
    }

    internal ParameterModifier(Parameter parameter, IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    {
        Parameter = parameter;
    }
}