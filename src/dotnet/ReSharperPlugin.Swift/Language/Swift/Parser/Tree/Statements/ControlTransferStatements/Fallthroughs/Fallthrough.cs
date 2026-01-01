using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements.Fallthroughs;

public class Fallthrough : ControlTransferStatementLeafNode, ISwiftKeyword
{
    public const string Keyword = "fallthrough";
    
    public Fallthrough(IEditableBuffer editableBuffer) 
        : base(editableBuffer, NodeTypes.NodeTypes.Fallthrough)
    { }

    public Fallthrough(SwiftInternalNode parent, IEditableBuffer editableBuffer) 
        : base(parent, editableBuffer, NodeTypes.NodeTypes.Fallthrough)
    { }

    public string KeywordValue => Keyword;

    public static Fallthrough Create()
    {
        return new Fallthrough(new EditableBuffer(Keyword));
    }

    public static Fallthrough Create(SwiftInternalNode parent)
    {
        return new Fallthrough(parent, new EditableBuffer(Keyword));
    }
}