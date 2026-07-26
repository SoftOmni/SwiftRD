using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public class Catch : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Catch>
{
    public const string Keyword = "catch";
    
    public Catch()
        : base(new EditableBuffer(Keyword))
    { }

    internal Catch(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Catch;

    public string KeywordValue => Keyword;

    public static Catch Create()
    {
        return new Catch(new EditableBuffer(Keyword));
    }
}
