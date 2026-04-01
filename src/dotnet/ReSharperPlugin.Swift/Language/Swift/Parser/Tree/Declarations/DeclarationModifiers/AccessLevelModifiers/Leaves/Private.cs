using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Private : LeafAccessLevelModifier, ISwiftKeyword
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