using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.CompositeStatements.Returns;

public class Return : ControlTransferStatementLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "return";
    
    public ReturnStatement? ReturnStatement { get; private set; }
    
    internal Return(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Return)
    { }

    internal Return(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Return)
    {
        if (parent is ReturnStatement returnStatement)
        {
            ReturnStatement = returnStatement;
        }
    }

    internal Return(ReturnStatement parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Return)
    {
        ReturnStatement = parent;
    }

    public string KeywordValue => Keyword;

    public static Return Create()
    {
        return new Return(new EditableBuffer(Keyword));
    }
    
    public static Return Create(ReturnStatement returnStatement)
    {
        return new Return(returnStatement, new EditableBuffer(Keyword));
    }

    public static Return CreateUnchecked(SwiftInternalNode parent)
    {
        return new Return(parent, new EditableBuffer(Keyword));
    }

    public Expression? Expression => ReturnStatement?.Expression;

    public bool IsAssociatedToReturnStatement => ReturnStatement is not null;
    
    public bool IsSimpleReturn => Expression is null;

    public bool ContainsReturnValue => Expression is not null;
}