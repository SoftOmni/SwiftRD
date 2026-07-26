using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Optional : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Optional>
{
    public const string Keyword = "optional";
    
    public Optional()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Optional(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Optional;

    public string KeywordValue => Keyword;

    public static Optional Create()
    {
        return new Optional(new EditableBuffer(Keyword));
    }
}
