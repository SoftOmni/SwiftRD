using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.DefaultLabels;

public class Default : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "default";
    
    public DefaultLabel? DefaultLabel { get; internal set; }

    internal Default(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Default)
    { }

    internal Default(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Default)
    {
        if (parent is DefaultLabel defaultLabel)
        {
            DefaultLabel = defaultLabel;
        }
    }

    internal Default(DefaultLabel parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Default)
    {
        DefaultLabel = parent;
    }

    public string KeywordValue => Keyword;

    public static Default Create()
    {
        return new Default(new EditableBuffer(Keyword));
    }

    public static Default Create(DefaultLabel defaultLabel)
    {
        return new Default(defaultLabel, new EditableBuffer(Keyword));
    }

    public static Default CreateUnchecked(SwiftInternalNode parent)
    {
        return new Default(parent, new EditableBuffer(Keyword));
    }
}