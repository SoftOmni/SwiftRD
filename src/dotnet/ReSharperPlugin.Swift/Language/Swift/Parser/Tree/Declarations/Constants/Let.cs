using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public class Let : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Let>
{
    public const string Keyword = "let";
    
    public Let()
        : base(new EditableBuffer())
    { }
    
    internal Let(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Let;

    public string KeywordValue => Keyword;

    public static Let Create()
    {
        return new Let(new EditableBuffer(Keyword));
    }
}