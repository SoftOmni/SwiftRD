using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

public class Private : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Private>
{
    public const string Keyword = "private";
    
    public Private()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Private(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Private;

    public string KeywordValue => Keyword;

    public static Private Create()
    {
        return new Private();
    }
}
