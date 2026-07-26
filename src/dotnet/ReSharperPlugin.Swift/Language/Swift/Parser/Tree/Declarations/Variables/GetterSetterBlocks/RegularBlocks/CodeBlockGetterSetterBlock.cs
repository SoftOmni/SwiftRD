using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public class CodeBlockGetterSetterBlock : SwiftCompositeNode, ICodeBlockGetterSetterBlock
{
    public ICodeBlock CodeBlock { get; }

    internal CodeBlockGetterSetterBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ICodeBlock codeBlock)
        : base(buffer, children)
    {
        CodeBlock = codeBlock;
    }

    IReadOnlyCodeBlock IReadOnlyCodeBlockGetterSetterBlock.CodeBlock => CodeBlock;

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}
