using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Private : LeafAccessLevelModifier, ISwiftKeywordNode
{
    public const string Keyword = "private";
    
    internal Private(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Private)
    { }

    internal Private(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Private)
    { }


    public string KeywordValue => Keyword;

    public static Private Create()
    {
        return new Private(new EditableBuffer(Keyword));
    }

    public static Private Create(SwiftInternalNode parent)
    {
        return new Private(new EditableBuffer(Keyword));
    }
}