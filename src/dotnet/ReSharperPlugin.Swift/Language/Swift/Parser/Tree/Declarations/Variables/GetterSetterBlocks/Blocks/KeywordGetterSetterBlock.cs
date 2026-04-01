using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Clauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;

public class KeywordGetterSetterBlock : GetterSetterBlock<KeywordGetterClause, KeywordSetterClause>
{
    public KeywordGetterSetterBlock(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public KeywordGetterSetterBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public KeywordGetterSetterBlock(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public KeywordGetterSetterBlock(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}