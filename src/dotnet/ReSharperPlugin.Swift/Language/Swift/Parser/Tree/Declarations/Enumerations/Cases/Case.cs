using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;

public class Case : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Case>
{
    public const string Keyword = "case";
    
    public Case()
        : base(new EditableBuffer(Keyword))
    { }

    internal Case(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Case;

    public string KeywordValue => Keyword;

    public static Case Create()
    {
        return new Case(new EditableBuffer(Keyword));
    }
}
