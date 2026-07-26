using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

public class OperatorKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<OperatorKeyword>
{
    public const string Keyword = "operator";
    
    public OperatorKeyword()
        : base(new EditableBuffer(Keyword))
    { }

    internal OperatorKeyword(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Operator;

    public string KeywordValue => Keyword;

    public static OperatorKeyword Create()
    {
        return new OperatorKeyword(new EditableBuffer(Keyword));
    }
}
