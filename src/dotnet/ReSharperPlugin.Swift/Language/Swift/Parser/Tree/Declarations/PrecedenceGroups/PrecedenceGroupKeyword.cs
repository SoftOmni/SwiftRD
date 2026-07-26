using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

public class PrecedenceGroupKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<PrecedenceGroupKeyword>
{
    public const string Keyword = "precedencegroup";
    
    public PrecedenceGroupKeyword()
        : base(new EditableBuffer(Keyword))
    { }

    internal PrecedenceGroupKeyword(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PrecedenceGroup;

    public string KeywordValue => Keyword;

    public static PrecedenceGroupKeyword Create()
    {
        return new PrecedenceGroupKeyword(new EditableBuffer(Keyword));
    }
}
