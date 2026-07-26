using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.IdentifierConditionComposing;

public class IdentifierConditionComposing : SwiftCompositeNode, IIdentifierConditionComposing
{
    public IIdentifier Identifier { get; }

    internal IdentifierConditionComposing(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        IIdentifier identifier)
        : base(buffer, children)
    {
        Identifier = identifier;
    }

    IReadOnlyIdentifier IReadOnlyIdentifierConditionComposing.Identifier => Identifier;

    public bool Evaluatable()
    {
        throw new NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new NotImplementedException();
    }

    public void ChangeIdentifier(IIdentifier newIdentifier)
    {
        throw new NotImplementedException();
    }
}
