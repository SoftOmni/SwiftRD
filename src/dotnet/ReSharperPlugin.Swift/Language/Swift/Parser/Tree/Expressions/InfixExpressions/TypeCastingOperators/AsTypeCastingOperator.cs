using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

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