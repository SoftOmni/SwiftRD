using System;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions.PrefixOperators;

public class PrefixOperator : SwiftLeafNode<SwiftCompositeNode>, IPrefixOperator
{
    public PrefixOperator(string value)
        : this(CheckValueCompatibility(value))
    { }
    
    public PrefixOperator(ReadOnlySpan<char> value)
        : this(CheckValueCompatibility(value))
    { }
    
    public PrefixOperator(IBuffer value)
        : this(CheckValueCompatibility(value))
    { }

    internal PrefixOperator(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PrefixOperator;

    public void ChangeValue(string value)
    {
        throw new NotImplementedException();
    }

    public void ChangeValue(IBuffer value)
    {
        throw new NotImplementedException();
    }

    public void ChangeValue(ReadOnlySpan<char> value)
    {
        throw new NotImplementedException();
    }

    private static IEditableBuffer CheckValueCompatibility(string value)
    {
        throw new NotImplementedException();
    }

    private static IEditableBuffer CheckValueCompatibility(ReadOnlySpan<char> value)
    {
        throw new NotImplementedException();
    }

    private static IEditableBuffer CheckValueCompatibility(IBuffer value)
    {
        throw new NotImplementedException();
    }
}
