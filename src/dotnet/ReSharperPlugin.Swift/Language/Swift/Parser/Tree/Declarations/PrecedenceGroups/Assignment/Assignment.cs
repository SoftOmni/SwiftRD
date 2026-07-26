using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Assignment;

public class Assignment : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Assignment>
{
    public const string Keyword = "assignment";
    
    public Assignment()
        : base(new EditableBuffer(Keyword))
    { }

    internal Assignment(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Assignment;

    public string KeywordValue => Keyword;

    public static Assignment Create()
    {
        return new Assignment(new EditableBuffer(Keyword));
    }
}
