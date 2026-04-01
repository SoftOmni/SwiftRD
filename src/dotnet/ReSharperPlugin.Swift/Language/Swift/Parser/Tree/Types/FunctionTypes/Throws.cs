using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

public class Throws: SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "throws";
    
    public ThrowsClause? ThrowsClause { get; internal set; }
    
    internal Throws(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Throws)
    { }

    internal Throws(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Throws)
    {
        if (parent is ThrowsClause throwsClause)
        {
            ThrowsClause = throwsClause;
        }
    }

    internal Throws(ThrowsClause parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Throws)
    {
        ThrowsClause = parent;
    }


    public string KeywordValue => Keyword;

    public static Throws Create()
    {
        return new Throws(new EditableBuffer(Keyword));
    }

    public static Throws Create(ThrowsClause parent)
    {
        return new Throws(new EditableBuffer(Keyword));
    }
    
    public static Throws CreateUnchecked(SwiftInternalNode parent)
    {
        return new Throws(new EditableBuffer(Keyword));
    }
}