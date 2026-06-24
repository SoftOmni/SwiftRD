using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Public : LeafAccessLevelModifier, ISwiftKeywordNode
{
    public const string Keyword = "public";
    
    internal Public(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Public)
    { }

    internal Public(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Public)
    { }


    public string KeywordValue => Keyword;

    public static Public Create()
    {
        return new Public(new EditableBuffer(Keyword));
    }

    public static Public Create(SwiftInternalNode parent)
    {
        return new Public(new EditableBuffer(Keyword));
    }
}