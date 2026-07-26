using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class Consuming : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Consuming>
{
    public const string Keyword = "consuming";
    
    public Consuming()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Consuming(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Consuming;

    public string KeywordValue => Keyword;

    public static Consuming Create()
    {
        return new Consuming(new EditableBuffer(Keyword));
    }
}
