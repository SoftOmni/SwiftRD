using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;

public class TypeAliasKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeyword
{
    public const string Keyword = "typealias";
    
    public TypeAlias? TypeAlias { get; internal set; }

    internal TypeAliasKeyword(IEditableBuffer buffer) 
        : base(buffer)
    { }

    internal TypeAliasKeyword(TypeAlias parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        TypeAlias = parent;
    }

    public override NodeType NodeType => SwiftNodeTypes.Typealias;

    public string KeywordValue => Keyword;

    public static TypeAliasKeyword Create()
    {
        return new TypeAliasKeyword(new EditableBuffer(Keyword));
    }
}