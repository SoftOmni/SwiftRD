using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Ifs;

public class If : StatementLeafNode, ISwiftKeyword
{
    public const string Keyword = "if";
    
    internal If(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.If)
    { }

    public If(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.If)
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