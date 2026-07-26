using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Override : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Override>
{
    public const string Keyword = "override";
    
    public Override()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Override(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Override;

    public string KeywordValue => Keyword;

    public static Override Create()
    {
        return new Override(new EditableBuffer(Keyword));
    }
}
