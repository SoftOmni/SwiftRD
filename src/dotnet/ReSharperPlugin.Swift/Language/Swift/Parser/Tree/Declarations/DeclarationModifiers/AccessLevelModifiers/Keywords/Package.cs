using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

public class Package : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Package>
{
    public const string Keyword = "package";
    
    public Package()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Package(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Package;

    public string KeywordValue => Keyword;

    public static Package Create()
    {
        return new Package();
    }
}
