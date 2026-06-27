using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.BoxedProtocolTypes;

public class AnyLowercase : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<AnyLowercase>
{
    public const string Keyword = "any";
    
    public AnyLowercase()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal AnyLowercase(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.AnyLowercase;

    public string KeywordValue => Keyword;

    public static AnyLowercase Create()
    {
        return new AnyLowercase(new EditableBuffer(Keyword));
    }
}
