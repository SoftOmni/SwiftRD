using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Clauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;

public class KeywordGetterSetterBlock : GetterSetterBlock<KeywordGetterClause, KeywordSetterClause>
{
    public KeywordGetterSetterBlock(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public KeywordGetterSetterBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public KeywordGetterSetterBlock(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public KeywordGetterSetterBlock(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}