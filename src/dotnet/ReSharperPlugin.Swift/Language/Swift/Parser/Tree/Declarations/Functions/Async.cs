using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public class Async: SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Async>
{
    public const string Keyword = "async";
    
    public Async()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Async(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Async;

    public string KeywordValue => Keyword;

    public static Async Create()
    {
        return new Async(new EditableBuffer(Keyword));
    }
}
