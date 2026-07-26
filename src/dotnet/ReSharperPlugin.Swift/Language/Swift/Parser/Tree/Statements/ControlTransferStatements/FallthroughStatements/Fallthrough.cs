using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.FallthroughStatements;

public class Fallthrough : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Fallthrough>
{
    public const string Keyword = "fallthrough";
    
    public Fallthrough()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Fallthrough(IEditableBuffer editableBuffer) 
        : base(editableBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Fallthrough;

    public string KeywordValue => Keyword;

    public static Fallthrough Create()
    {
        return new Fallthrough(new EditableBuffer(Keyword));
    }
}
