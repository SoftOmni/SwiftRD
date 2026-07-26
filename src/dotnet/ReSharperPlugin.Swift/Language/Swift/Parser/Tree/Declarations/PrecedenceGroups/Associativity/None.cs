using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class None : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<None>
{
    public const string Keyword = "none";
    
    public None()
        : base(new EditableBuffer(Keyword))
    { }

    internal None(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.None;

    public string KeywordValue => Keyword;

    public static None Create()
    {
        return new None(new EditableBuffer(Keyword));
    }
}
