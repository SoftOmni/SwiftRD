using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.BreakStatements;

public class BreakStatement : SwiftCompositeNode, IBreakStatement
{
    public Break Break { get; }
    
    public IIdentifier? Label { get; }

    internal BreakStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Break @break, IIdentifier? label = null)
        : base(buffer, children)
    {
        Break = @break;
        Label = label;
    }

    IReadOnlyIdentifier? IReadOnlyBreakStatement.Label => Label;

    public void ChangeLabel(IIdentifier newLabel)
    {
        throw new NotImplementedException();
    }
}
