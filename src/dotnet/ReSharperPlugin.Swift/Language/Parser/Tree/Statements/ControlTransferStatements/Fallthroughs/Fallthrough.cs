using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements.Fallthroughs;

public class Fallthrough : ControlTransferStatementLeafNode, ISwiftKeyword
{
    public const string Keyword = "fallthrough";
    
    public Fallthrough(IEditableBuffer editableBuffer) 
        : base(editableBuffer, NodeTypes.NodeTypes.Fallthrough)
    { }

    public Fallthrough(ISwiftNode parent, IEditableBuffer editableBuffer) 
        : base(parent, editableBuffer, NodeTypes.NodeTypes.Fallthrough)
    { }

    public string KeywordValue => Keyword;

    public static Fallthrough Create()
    {
        return new Fallthrough(new EditableBuffer(Keyword));
    }

    public static Fallthrough Create(ISwiftNode parent)
    {
        return new Fallthrough(parent, new EditableBuffer(Keyword));
    }
}