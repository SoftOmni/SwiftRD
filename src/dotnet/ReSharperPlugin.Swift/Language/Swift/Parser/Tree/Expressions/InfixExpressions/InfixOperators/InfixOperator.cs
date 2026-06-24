using System;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.InfixOperators;

public class InfixOperator : SwiftLeafNode<SwiftCompositeNode>, IInfixOperator
{
    public InfixOperator(string value)
        : base(CheckValueCompatibility(value))
    { }
    
    public InfixOperator(ReadOnlySpan<char> value)
        : base(CheckValueCompatibility(value))
    { }
    
    public InfixOperator(IBuffer value)
        : base(CheckValueCompatibility(value))
    { }
    
    internal InfixOperator(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.InfixOperator;

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
