using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.AnyTypes;

public class AnyUppercase : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<AnyUppercase>
{
    public const string Keyword = "Any";
    
    public AnyUppercase() 
        : base(new EditableBuffer(Keyword))
    { }
    
    internal AnyUppercase(IEditableBuffer buffer) 
        : base(buffer)
    { }
    
    public string KeywordValue => Keyword;

    public override NodeType NodeType => SwiftNodeTypes.AnyUppercase;

    public static AnyUppercase Create()
    {
        return new AnyUppercase(new EditableBuffer(Keyword));
    }
}