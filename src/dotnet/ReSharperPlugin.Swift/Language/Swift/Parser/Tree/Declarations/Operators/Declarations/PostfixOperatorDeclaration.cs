using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public class PostfixOperatorDeclaration : SwiftCompositeNode, IPostfixOperatorDeclaration
{
    public Postfix PostfixKeyword { get; }
    
    public OperatorKeyword OperatorKeyword { get; }
    
    public IOperator Operator { get; }

    internal PostfixOperatorDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Postfix postfixKeyword, OperatorKeyword operatorKeyword, IOperator @operator)
        : base(buffer, children)
    {
        PostfixKeyword = postfixKeyword;
        OperatorKeyword = operatorKeyword;
        Operator = @operator;

        Icon = SwiftIcons.ConstantIcon;
    }

    public AnyCompiledIconClass Icon { get; }

    IReadOnlyOperator IReadOnlyPostfixOperatorDeclaration.Operator => Operator;

    public void ChangeOperator(IOperator newOperator)
    {
        throw new System.NotImplementedException();
    }
}
