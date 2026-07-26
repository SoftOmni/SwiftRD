using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Static : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Static>
{
    public const string Keyword = "static";
    
    public Static()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Static(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Static;

    public string KeywordValue => Keyword;

    public static Static Create()
    {
        return new Static(new EditableBuffer(Keyword));
    }
}
