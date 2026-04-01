using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

public class TryOperator : SwiftInternalNode
{
    public Try? Try { get; internal set; }
    
    public QuestionMark? QuestionMark { get; internal set; }
    
    public ExclamationMark? ExclamationMark { get; internal set; }

    public TryOperator(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public TryOperator(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public TryOperator(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public TryOperator(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}