using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions.Conditions.CaseConditions;

public class CaseCondition : SwiftCompositeNode, ICaseCondition
{
    public Case Case { get; }
    
    public IPattern Pattern { get; }
    
    public IInitializerDeclaration Initializer { get; }

    internal CaseCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Case @case, IPattern pattern, IInitializerDeclaration initializer)
        : base(buffer, children)
    {
        Case = @case;
        Pattern = pattern;
        Initializer = initializer;
    }

    IReadOnlyPattern IReadOnlyCaseCondition.Pattern => Pattern;

    IReadOnlyInitializerDeclaration IReadOnlyCaseCondition.Initializer => Initializer;

    public void ChangePattern(IPattern newPattern)
    {
        throw new NotImplementedException();
    }

    public void ChangeInitializer(IInitializerDeclaration newInitializer)
    {
        throw new NotImplementedException();
    }
}
