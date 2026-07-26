using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class Right : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Right>
{
    public const string Keyword = "right";
    
    public Right()
        : base(new EditableBuffer(Keyword))
    { }

    internal Right(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Right;

    public string KeywordValue => Keyword;

    public static Right Create()
    {
        return new Right(new EditableBuffer(Keyword));
    }
}
