using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.SwitchExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;

public class Switch : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "switch";
    
    public SwitchStatement? SwitchStatement { get; internal set; }
    
    public SwitchExpression? SwitchExpression { get; internal set; }

    internal Switch(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Switch)
    { }

    internal Switch(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Switch)
    {
        if (parent is SwitchStatement switchStatement)
        {
            SwitchStatement = switchStatement;
        }
        else if (parent is SwitchExpression switchExpression)
        {
            SwitchExpression = switchExpression;
        }
    }

    internal Switch(SwitchStatement parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Switch)
    {
        SwitchStatement = parent;
    }
    
    internal Switch(SwitchExpression parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Switch)
    {
        SwitchExpression = parent;
    }

    public string KeywordValue => Keyword;

    public static Switch Create()
    {
        return new Switch(new EditableBuffer(Keyword));
    }

    public static Switch Create(SwitchStatement switchStatement)
    {
        return new Switch(switchStatement, new EditableBuffer(Keyword));
    }
    
    
    public static Switch Create(SwitchExpression switchExpression)
    {
        return new Switch(switchExpression, new EditableBuffer(Keyword));
    }

    public static Switch CreateUnchecked(SwiftInternalNode parent)
    {
        return new Switch(parent, new EditableBuffer(Keyword));
    }
}