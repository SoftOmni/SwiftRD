using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

public class Public : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Public>
{
    public const string Keyword = "public";
    
    public Public()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Public(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Public;

    public string KeywordValue => Keyword;

    public static Public Create()
    {
        return new Public();
    }
}
