using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

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