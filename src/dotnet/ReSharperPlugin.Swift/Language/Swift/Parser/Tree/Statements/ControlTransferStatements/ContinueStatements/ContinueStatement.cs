using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ContinueStatements;

public class ContinueStatement : SwiftCompositeNode, IContinueStatement
{
    public Continue Continue { get; }
    
    public IIdentifier? Label { get; }

    internal ContinueStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Continue @continue, IIdentifier? label = null)
        : base(buffer, children)
    {
        Continue = @continue;
        Label = label;
    }

    IReadOnlyIdentifier? IReadOnlyContinueStatement.Label => Label;

    public void ChangeLabel(IIdentifier newLabel)
    {
        throw new System.NotImplementedException();
    }
}
