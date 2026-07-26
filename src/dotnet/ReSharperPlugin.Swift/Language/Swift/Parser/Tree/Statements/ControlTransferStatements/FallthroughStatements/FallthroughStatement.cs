using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.Fallthroughs;

public class FallthroughStatement : SwiftCompositeNode, IFallthroughStatement
{
    public Fallthrough Fallthrough { get; }

    internal FallthroughStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Fallthrough fallthrough)
        : base(buffer, children)
    {
        Fallthrough = fallthrough;
    }
}
