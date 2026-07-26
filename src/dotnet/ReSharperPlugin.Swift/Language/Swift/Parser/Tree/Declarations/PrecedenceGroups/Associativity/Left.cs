using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class Left : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Left>
{
    public const string Keyword = "left";
    
    public Left()
        : base(new EditableBuffer(Keyword))
    { }

    internal Left(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Left;

    public string KeywordValue => Keyword;

    public static Left Create()
    {
        return new Left(new EditableBuffer(Keyword));
    }
}
