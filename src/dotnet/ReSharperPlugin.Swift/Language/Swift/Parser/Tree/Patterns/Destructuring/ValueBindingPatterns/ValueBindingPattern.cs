using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.ValueBinding;

public class ValueBindingPattern : SwiftCompositeNode, IValueBindingPattern
{
    public IReadOnlyValueBindingPattern.InitializerKind? Kind { get; }

    public Let? Let { get; }

    public Var? Var { get; }

    public IPattern Pattern { get; }

    internal ValueBindingPattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ISwiftNode<SwiftCompositeNode> varOrLet, IPattern pattern) : base(buffer, children)
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

    public void MakeLet()
    {
        throw new System.NotImplementedException();
    }
    
    public void MakeVar()
    {
        throw new System.NotImplementedException();
    }

    public void SetPattern(IPattern pattern)
    {
        throw new System.NotImplementedException();
    }
}