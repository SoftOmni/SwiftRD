using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public class HigherThan : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<HigherThan>
{
    public const string Keyword = "higherThan";
    
    public HigherThan()
        : base(new EditableBuffer(Keyword))
    { }

    internal HigherThan(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.HigherThan;

    public string KeywordValue => Keyword;

    public static HigherThan Create()
    {
        return new HigherThan(new EditableBuffer(Keyword));
    }
}
