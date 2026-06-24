using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

public class If : StatementLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "if";
    
    internal If(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.If)
    { }

    public If(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.If)
    { }

    public string KeywordValue => Keyword;

    public static If Create()
    {
        return new If(new EditableBuffer(Keyword));
    }
    
    public static If Create(IfStatement ifStatement)
    {
        return new If(ifStatement, new EditableBuffer(Keyword));
    }
}