using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Indirecterations;

public class Indirect : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Indirect>
{
    public const string Keyword = "indirect";
    
    public Indirect()
        : base(new EditableBuffer(Keyword))
    { }

    internal Indirect(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Indirect;

    public string KeywordValue => Keyword;

    public static Indirect Create()
    {
        return new Indirect(new EditableBuffer(Keyword));
    }
}
