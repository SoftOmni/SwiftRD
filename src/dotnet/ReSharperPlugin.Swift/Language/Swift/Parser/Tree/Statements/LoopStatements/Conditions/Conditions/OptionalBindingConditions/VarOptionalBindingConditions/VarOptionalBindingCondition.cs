using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions.Conditions.OptionalBindingConditions.VarOptionalBindingConditions;

public class VarOptionalBindingCondition : SwiftCompositeNode, IVarOptionalBindingCondition
{
    public Var Var { get; }
    
    public IPattern Pattern { get; }
    
    public IInitializer? Initializer { get; }

    internal VarOptionalBindingCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Var var, IPattern pattern, IInitializer? initializer)
        : base(buffer, children)
    {
        Var = var;
        Pattern = pattern;
        Initializer = initializer;
    }

    IReadOnlyPattern IReadOnlyOptionalBindingCondition.Pattern => Pattern;

    IReadOnlyInitializer? IReadOnlyOptionalBindingCondition.Initializer => Initializer;

    public void ChangePattern(IPattern newPattern)
    {
        throw new NotImplementedException();
    }

    public void SetInitializer(IInitializer? initializer)
    {
        throw new NotImplementedException();
    }

    public void RemoveInitializer()
    {
        throw new NotImplementedException();
    }
}
