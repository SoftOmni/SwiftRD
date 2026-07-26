using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

public class Import : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Import>
{
    public const string Keyword = "import";
    
    public Import()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Import(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Import;

    public string KeywordValue => Keyword;

    public static Import Create()
    {
        return new Import(new EditableBuffer(Keyword));
    }
}
