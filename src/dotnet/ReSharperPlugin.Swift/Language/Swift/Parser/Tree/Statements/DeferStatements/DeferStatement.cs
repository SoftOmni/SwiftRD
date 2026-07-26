using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DeferStatements;

public class DeferStatement : SwiftCompositeNode, IDeferStatement
{
    public Defer Defer { get; }

    public ICodeBlock CodeBlock { get; }

    internal DeferStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Defer defer, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        Defer = defer;
        CodeBlock = codeBlock;
    }

    IReadOnlyCodeBlock IReadOnlyDeferStatement.CodeBlock => CodeBlock;

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}
