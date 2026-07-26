using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

public class Var : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Var>
{
    public const string Keyword = "var";
    
    public Var()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Var(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Var;

    public string KeywordValue => Keyword;

    public static Var Create()
    {
        return new Var(new EditableBuffer(Keyword));
    }
}
