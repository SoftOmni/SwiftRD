using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

public class Open : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Open>
{
    public const string Keyword = "open";
    
    public Open()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Open(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Open;

    public string KeywordValue => Keyword;

    public static Open Create()
    {
        return new Open();
    }
}
