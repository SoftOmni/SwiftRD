using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions.InOutExpressions;

public class InOutExpression : SwiftCompositeNode, IInOutExpression
{
    public Ampersand Ampersand { get; }

    public IPrimaryExpression PrimaryExpression { get; }
    
    internal InOutExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Ampersand ampersand, IPrimaryExpression primaryExpression)
        : base(buffer, children)
    {
        Ampersand = ampersand;
        PrimaryExpression = primaryExpression;
        
        ReturnType = SetDefaultReturnType();
    }


    IReadOnlyPrimaryExpression IReadOnlyInOutExpression.PrimaryExpression => PrimaryExpression;
    
    public IType ReturnType { get; } // TODO: Investigate

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangePrimaryExpression(IPrimaryExpression newPrimaryExpression)
    {
        throw new NotImplementedException();
    }
    
    private static IType SetDefaultReturnType()
    {
        throw new NotImplementedException();
    }
}
