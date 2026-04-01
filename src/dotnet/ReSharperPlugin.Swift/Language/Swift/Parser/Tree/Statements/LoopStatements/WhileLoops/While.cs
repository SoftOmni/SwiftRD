using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

public class While : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "while";
    
    public WhileStatement? WhileStatement { get; internal set; }
    
    public RepeatWhileStatement? RepeatWhileStatement { get; internal set; }

    internal While(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.While)
    { }

    internal While(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.While)
    {
        if (parent is WhileStatement whileStatement)
        {
            WhileStatement = whileStatement;
        }
        else if (parent is RepeatWhileStatement repeatWhileStatement)
        {
            RepeatWhileStatement = repeatWhileStatement;
        }
    }

    internal While(WhileStatement parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.While)
    {
        WhileStatement = parent;
    }
    
    internal While(RepeatWhileStatement parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.While)
    {
        RepeatWhileStatement = parent;
    }

    public string KeywordValue => Keyword;

    public static While Create()
    {
        return new While(new EditableBuffer(Keyword));
    }

    public static While Create(WhileStatement whileStatement)
    {
        return new While(whileStatement, new EditableBuffer(Keyword));
    }
    
    
    public static While Create(RepeatWhileStatement repeatWhileStatement)
    {
        return new While(repeatWhileStatement, new EditableBuffer(Keyword));
    }

    public static While CreateUnchecked(SwiftInternalNode parent)
    {
        return new While(parent, new EditableBuffer(Keyword));
    }
}