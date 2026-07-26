using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions.Conditions.OptionalBindingConditions.LetOptionalBindingConditions;

public class LetOptionalBindingCondition : SwiftCompositeNode, ILetOptionalBindingCondition
{
    public Let Let { get; }
    
    public IPattern Pattern { get; }
    
    public IInitializerDeclaration? Initializer { get; }

    internal LetOptionalBindingCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Let let, IPattern pattern, IInitializerDeclaration? initializer)
        : base(buffer, children)
    {
        Let = let;
        Pattern = pattern;
        Initializer = initializer;
    }

    IReadOnlyPattern IReadOnlyOptionalBindingCondition.Pattern => Pattern;

    IReadOnlyInitializerDeclaration? IReadOnlyOptionalBindingCondition.Initializer => Initializer;

    public void ChangePattern(IPattern newPattern)
    {
        throw new NotImplementedException();
    }

    public void SetInitializer(IInitializerDeclaration? initializer)
    {
        throw new NotImplementedException();
    }

    public void RemoveInitializer()
    {
        throw new NotImplementedException();
    }
}
