using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.DefaultSwitchCases;

public class Default : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Default>
{
    public const string Keyword = "default";
    
    public Default()
        : base(new EditableBuffer(Keyword))
    { }

    internal Default(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Default;

    public string KeywordValue => Keyword;

    public static Default Create()
    {
        return new Default();
    }
}
