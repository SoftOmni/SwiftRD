using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.DictionaryTypes;

public class DictionaryType : TypeInternalNode
{
    public LeftSquareBracket? LeftSquareBracket { get; internal set; }

    public IType? KeyType;
    
    public Colon? Colon { get; internal set; }
    
    public IType? ValueType { get; internal set; }
    
    public RightSquareBracket? RightSquareBracket { get; internal set; }

    public DictionaryType(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public DictionaryType(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public DictionaryType(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public DictionaryType(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}