using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Public : LeafAccessLevelModifier, ISwiftKeyword
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