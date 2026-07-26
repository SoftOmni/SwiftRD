using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public class Safe : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Safe>
{
    public const string Keyword = "safe";

    public Safe()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Safe(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Safe;

    public string KeywordValue => Keyword;

    public static Safe Create()
    {
        return new Safe(new EditableBuffer(Keyword));
    }
}
