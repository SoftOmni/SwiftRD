using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.ValueBinding;

public class IncompleteValueBindingPattern : SwiftErrorCompositeNode, IValueBindingPattern
{
    public IReadOnlyValueBindingPattern.InitializerKind? Kind { get; }

    public Let? Let { get; }

    public Var? Var { get; }

    public IPattern Pattern { get; }

    internal IncompleteValueBindingPattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ISwiftNode<SwiftCompositeNode> varOrLet, IPattern pattern) : base(buffer, children, GenerateMessage(varOrLet))
    {
        if (varOrLet is Let let)
        {
            Let = let;
            Kind = IReadOnlyValueBindingPattern.InitializerKind.Let;
        }
        else if (varOrLet is Var var)
        {
            Var = var;
            Kind = IReadOnlyValueBindingPattern.InitializerKind.Var;
        }

        Pattern = pattern;
    }

    private static string GenerateMessage(ISwiftNode<SwiftCompositeNode> varOrLet)
    {
        bool isLet = varOrLet is Let;

        return $"Value binding pattern is missing pattern after {(isLet ? "'let'" : "'var'")}";
    }

    public void MakeLet()
    {
        throw new NotImplementedException();
    }
    
    public void MakeVar()
    {
        throw new NotImplementedException();
    }

    public void SetPattern(IPattern pattern)
    {
        throw new NotImplementedException();
    }
}