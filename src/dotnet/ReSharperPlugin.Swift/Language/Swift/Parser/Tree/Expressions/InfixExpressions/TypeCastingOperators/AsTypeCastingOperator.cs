using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public class AsTypeCastingOperator : TypeCastingOperator
{
    public As? As { get; internal set; }
    
    public QuestionMark? QuestionMark { get; internal set; }
    
    public ExclamationMark? ExclamationMark { get; internal set; }
    
    public AsTypeCastingOperator(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AsTypeCastingOperator(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AsTypeCastingOperator(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public AsTypeCastingOperator(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}