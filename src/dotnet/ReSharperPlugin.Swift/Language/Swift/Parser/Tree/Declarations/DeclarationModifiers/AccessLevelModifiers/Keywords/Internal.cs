using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

public class Internal : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Internal>
{
    public const string Keyword = "internal";
    
    public Internal()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Internal(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Internal;

    public string KeywordValue => Keyword;

    public static Internal Create()
    {
        return new Internal();
    }
}
