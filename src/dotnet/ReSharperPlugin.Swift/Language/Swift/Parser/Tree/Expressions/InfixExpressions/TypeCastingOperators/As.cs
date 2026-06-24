using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public class As : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<As>, ITypeCastingOperator
{
    public const string Keyword = "as";
    
    public As()
        : base(new EditableBuffer(Keyword))
    { }

    internal As(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public IReadOnlyTypeCastingOperator.Kind CurrentKind => IReadOnlyTypeCastingOperator.Kind.As;

    public override NodeType NodeType => SwiftNodeTypes.As;

    public string KeywordValue => Keyword;

    public static As Create()
    {
        return new As(new EditableBuffer(Keyword));
    }
}
