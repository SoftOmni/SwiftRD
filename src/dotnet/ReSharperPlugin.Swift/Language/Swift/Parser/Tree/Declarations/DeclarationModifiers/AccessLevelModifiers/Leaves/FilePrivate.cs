using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class FilePrivate : LeafAccessLevelModifier, ISwiftKeyword
{
    public const string Keyword = "filePrivate";
    
    internal FilePrivate(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.FilePrivate)
    { }

    internal FilePrivate(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.FilePrivate)
    { }


    public string KeywordValue => Keyword;

    public static FilePrivate Create()
    {
        return new FilePrivate(new EditableBuffer(Keyword));
    }

    public static FilePrivate Create(SwiftInternalNode parent)
    {
        return new FilePrivate(new EditableBuffer(Keyword));
    }
}