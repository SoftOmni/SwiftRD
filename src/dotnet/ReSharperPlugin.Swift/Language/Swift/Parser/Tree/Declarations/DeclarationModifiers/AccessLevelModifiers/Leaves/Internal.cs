using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.Resources;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Internal : LeafAccessLevelModifier, ISwiftKeyword
{
    public const string Keyword = "internal";
    
    internal Internal(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Internal)
    { }

    internal Internal(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Internal)
    { }


    public string KeywordValue => Keyword;

    public static Internal Create()
    {
        return new Internal(new EditableBuffer(Keyword));
    }

    public static Internal Create(SwiftInternalNode parent)
    {
        return new Internal(new EditableBuffer(Keyword));
    }
}