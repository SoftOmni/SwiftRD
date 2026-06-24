using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

public class Throws: SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Throws>
{
    public const string Keyword = "throws";
    
    public Throws()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Throws(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Throws;

    public string KeywordValue => Keyword;

    public static Throws Create()
    {
        return new Throws(new EditableBuffer(Keyword));
    }
}
