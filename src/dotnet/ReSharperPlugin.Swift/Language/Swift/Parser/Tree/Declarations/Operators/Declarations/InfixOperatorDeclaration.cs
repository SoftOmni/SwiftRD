using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public class InfixOperatorDeclaration : SwiftCompositeNode, IInfixOperatorDeclaration
{
    public Infix InfixKeyword { get; }
    
    public OperatorKeyword OperatorKeyword { get; }
    
    public IOperator Operator { get; }
    
    public IInfixOperatorGroup? InfixOperatorGroup { get; }

    internal InfixOperatorDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Infix infixKeyword, OperatorKeyword operatorKeyword, IOperator @operator, IInfixOperatorGroup? infixOperatorGroup)
        : base(buffer, children)
    {
        InfixKeyword = infixKeyword;
        OperatorKeyword = operatorKeyword;
        Operator = @operator;
        InfixOperatorGroup = infixOperatorGroup;

        Icon = SwiftIcons.ConstantIcon;
    }

    public AnyCompiledIconClass Icon { get; }
    
    IReadOnlyOperator IReadOnlyInfixOperatorDeclaration.Operator => Operator;

    IReadOnlyInfixOperatorGroup? IReadOnlyInfixOperatorDeclaration.InfixOperatorGroup => InfixOperatorGroup;

    public void ChangeOperator(IOperator newOperator)
    {
        throw new System.NotImplementedException();
    }

    public void SetInfixOperatorGroup(IInfixOperatorGroup? newInfixOperatorGroup)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveInfixOperatorGroup()
    {
        throw new System.NotImplementedException();
    }
}
