using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Unowned : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Unowned>
{
    public const string Keyword = "unowned";

    public Unowned()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Unowned(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Unowned;

    public string KeywordValue => Keyword;

    public static Unowned Create()
    {
        return new Unowned(new EditableBuffer(Keyword));
    }
}
