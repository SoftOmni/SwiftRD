using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Prefix : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Prefix>
{
    public const string Keyword = "prefix";
    
    public Prefix()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Prefix(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Prefix;

    public string KeywordValue => Keyword;

    public static Prefix Create()
    {
        return new Prefix(new EditableBuffer(Keyword));
    }
}
