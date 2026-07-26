using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;

public class Get : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Get>
{
    public const string Keyword = "get";

    public Get()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Get(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Get;

    public string KeywordValue => Keyword;

    public static Get Create()
    {
        return new Get(new EditableBuffer(Keyword));
    }
}
