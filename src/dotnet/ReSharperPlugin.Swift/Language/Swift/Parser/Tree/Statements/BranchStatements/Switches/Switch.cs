using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;

public class Switch : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Switch>
{
    public const string Keyword = "switch";
    
    public Switch()
        : base(new EditableBuffer(Keyword))
    { }

    internal Switch(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Switch;

    public string KeywordValue => Keyword;

    public static Switch Create()
    {
        return new Switch(new EditableBuffer(Keyword));
    }
}