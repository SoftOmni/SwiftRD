using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public class LowerThan : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<LowerThan>
{
    public const string Keyword = "lowerThan";
    
    public LowerThan()
        : base(new EditableBuffer(Keyword))
    { }

    internal LowerThan(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.LowerThan;

    public string KeywordValue => Keyword;

    public static LowerThan Create()
    {
        return new LowerThan(new EditableBuffer(Keyword));
    }
}
