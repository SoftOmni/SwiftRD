using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

public class Precedence : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Precedence>
{
    public const string Keyword = "precedence";
    
    public Precedence()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Precedence(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Precedence;

    public string KeywordValue => Keyword;

    public static Precedence Create()
    {
        return new Precedence();
    }
}
