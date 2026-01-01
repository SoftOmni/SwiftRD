using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.Resources;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Internal : LeafAccessLevelModifier, ISwiftKeyword
{
    public const string Keyword = "internal";
    
    internal Internal(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Internal)
    { }

    internal Internal(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Internal)
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