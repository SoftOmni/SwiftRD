using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Operators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions;

public class FunctionName : SwiftInternalNode
{
    public Function? Function { get; private set; }
    
    public Identifier? Identifier { get; private set; }

    public OperatorDeclaration? Operator { get; private set; }

    public NameKind? Kind { get; private set; }

    public FunctionName(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionName(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionName(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    {
        if (parent is Function function)
        {
            Function = function;
        }
    }

    public FunctionName(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    {
        if (parent is Function function)
        {
            Function = function;
        }
    }

    public enum NameKind
    {
        Identifier,
        Operator,
        Other
    }
}