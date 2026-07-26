using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;

public class Init : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Init>
{
    public const string Keyword = "init";
    
    public Init()
        : base(new EditableBuffer(Keyword))
    { }

    internal Init(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Init;

    public string KeywordValue => Keyword;

    public static Init Create()
    {
        return new Init(new EditableBuffer(Keyword));
    }
}
