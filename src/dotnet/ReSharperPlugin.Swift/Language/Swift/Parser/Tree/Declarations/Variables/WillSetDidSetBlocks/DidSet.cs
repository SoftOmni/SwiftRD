using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public class DidSet : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<DidSet>
{
    public const string Keyword = "didSet";
    
    public DidSet()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal DidSet(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.DidSet;

    public string KeywordValue => Keyword;

    public static DidSet Create()
    {
        return new DidSet(new EditableBuffer(Keyword));
    }
}
