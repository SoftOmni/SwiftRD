using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Class : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "class";
    
    public Classes.Class? ClassDeclaration { get; internal set; } 
    
    internal Class(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Class, buffer)
    { }

    internal Class(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Class)
    {
        if (parent is Classes.Class @class)
        {
            ClassDeclaration = @class;
        }
    }

    internal Class(Classes.Class @class, IEditableBuffer buffer)
        : base(@class, buffer, SwiftNodeTypes.Class)
    {
        ClassDeclaration = @class;
    }


    public string KeywordValue => Keyword;

    public static Class Create()
    {
        return new Class(new EditableBuffer(Keyword));
    }

    public static Class Create(SwiftInternalNode parent)
    {
        return new Class(parent, new EditableBuffer(Keyword));
    }

    public static Class Create(Classes.Class parent)
    {
        return new Class(parent, new EditableBuffer(Keyword));
    }
}