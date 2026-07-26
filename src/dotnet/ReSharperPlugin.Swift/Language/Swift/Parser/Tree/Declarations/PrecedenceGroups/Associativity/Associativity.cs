using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class Associativity : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Associativity>
{
    public const string Keyword = "associativity";
    
    public Associativity()
        : base(new EditableBuffer(Keyword))
    { }

    internal Associativity(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Associativity;

    public string KeywordValue => Keyword;

    public static Associativity Create()
    {
        return new Associativity(new EditableBuffer(Keyword));
    }
}
