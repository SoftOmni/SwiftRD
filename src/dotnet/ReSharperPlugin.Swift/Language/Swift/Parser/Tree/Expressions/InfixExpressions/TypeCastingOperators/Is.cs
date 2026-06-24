using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public class Is : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Is>, ITypeCastingOperator
{
    public const string Keyword = "is";
    
    public Is()
        : base(new EditableBuffer(Keyword))
    { }

    internal Is(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Is;

    public IReadOnlyTypeCastingOperator.Kind CurrentKind => IReadOnlyTypeCastingOperator.Kind.Is;

    public string KeywordValue => Keyword;

    public static Is Create()
    {
        return new Is(new EditableBuffer(Keyword));
    }
}