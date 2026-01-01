using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Subscripts;

public class SubscriptKeywordGetterSetter : Subscript
{
    public KeywordGetterSetterBlock? GetterSetterBlock { get; internal set; }
    
    public SubscriptKeywordGetterSetter(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SubscriptKeywordGetterSetter(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SubscriptKeywordGetterSetter(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public SubscriptKeywordGetterSetter(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}