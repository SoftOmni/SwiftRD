using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

public class AssociatedType : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<AssociatedType>
{
    public const string Keyword = "associatedtype";
    
    public AssociatedType()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal AssociatedType(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.AssociatedType;

    public string KeywordValue => Keyword;

    public static AssociatedType Create()
    {
        return new AssociatedType();
    }
}
