using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeInitializers;

public class DeInit : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<DeInit>
{
    public const string Keyword = "deinit";
    
    public DeInit()
        : base(new EditableBuffer(Keyword))
    { }

    internal DeInit(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Deinit;

    public string KeywordValue => Keyword;

    public static DeInit Create()
    {
        return new DeInit(new EditableBuffer(Keyword));
    }
}