using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Macros;

public class MacroKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "macro";
    
    public Macro? Macro { get; internal set; }

    internal MacroKeyword(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Macro)
    { }

    internal MacroKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Macro)
    {
        if (parent is Macro macro)
        {
            Macro = macro;
        }
    }

    internal MacroKeyword(Macro parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Macro)
    {
        Macro = parent;
    }

    public string KeywordValue => Keyword;

    public static MacroKeyword Create()
    {
        return new MacroKeyword(new EditableBuffer(Keyword));
    }

    public static MacroKeyword Create(Macro macro)
    {
        return new MacroKeyword(macro, new EditableBuffer(Keyword));
    }

    public static MacroKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new MacroKeyword(parent, new EditableBuffer(Keyword));
    }
}