using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class Borrowing : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Borrowing>
{
    public const string Keyword = "borrowing";
    
    public Borrowing()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Borrowing(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Borrowing;

    public string KeywordValue => Keyword;

    public static Borrowing Create()
    {
        return new Borrowing(new EditableBuffer(Keyword));
    }
}
