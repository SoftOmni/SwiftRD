using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;

public class TypeAliasKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<TypeAliasKeyword>
{
    public const string Keyword = "typealias";
    
    public TypeAliasKeyword()
        : base(new EditableBuffer(Keyword))
    { }

    internal TypeAliasKeyword(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Typealias;

    public string KeywordValue => Keyword;

    public static TypeAliasKeyword Create()
    {
        return new TypeAliasKeyword(new EditableBuffer(Keyword));
    }
}
