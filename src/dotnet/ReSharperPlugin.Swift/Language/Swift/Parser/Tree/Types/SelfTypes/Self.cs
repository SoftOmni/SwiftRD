using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.SelfTypes;

public class Self : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Self>
{
    public const string Keyword = "Self";
    
    public Self() 
        : base(new EditableBuffer(Keyword))
    { }

    internal Self(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.SelfUppercase;

    public string KeywordValue => Keyword;

    public static Self Create()
    {
        return new Self(new EditableBuffer(Keyword));
    }
}
