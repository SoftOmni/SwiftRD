using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.Fallthroughs;

public class Fallthrough : ControlTransferStatementLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "fallthrough";
    
    public Fallthrough(IEditableBuffer editableBuffer) 
        : base(editableBuffer, SwiftNodeTypes.Fallthrough)
    { }

    public Fallthrough(SwiftInternalNode parent, IEditableBuffer editableBuffer) 
        : base(parent, editableBuffer, SwiftNodeTypes.Fallthrough)
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