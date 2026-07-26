using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public class PrefixOperatorDeclaration : SwiftCompositeNode, IPrefixOperatorDeclaration
{
    public Prefix PrefixKeyword { get; }
    
    public OperatorKeyword OperatorKeyword { get; }
    
    public IOperator Operator { get; }

    internal PrefixOperatorDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Prefix prefixKeyword, OperatorKeyword operatorKeyword, IOperator @operator)
        : base(buffer, children)
    {
        PrefixKeyword = prefixKeyword;
        OperatorKeyword = operatorKeyword;
        Operator = @operator;

        Icon = SwiftIcons.ConstantIcon;
    }

    public AnyCompiledIconClass Icon { get; }

    IReadOnlyOperator IReadOnlyPrefixOperatorDeclaration.Operator => Operator;

    public void ChangeOperator(IOperator newOperator)
    {
        throw new System.NotImplementedException();
    }
}
