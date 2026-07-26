using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public class WillSet : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<WillSet>
{
    public const string Keyword = "willSet";
    
    public WillSet()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal WillSet(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.WillSet;

    public string KeywordValue => Keyword;

    public static WillSet Create()
    {
        return new WillSet(new EditableBuffer(Keyword));
    }
}
