using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Package : LeafAccessLevelModifier, ISwiftKeywordNode
{
    public const string Keyword = "package";
    
    internal Package(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Package)
    { }

    internal Package(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Package)
    { }


    public string KeywordValue => Keyword;

    public static Package Create()
    {
        return new Package(new EditableBuffer(Keyword));
    }

    public static Package Create(SwiftInternalNode parent)
    {
        return new Package(new EditableBuffer(Keyword));
    }
}