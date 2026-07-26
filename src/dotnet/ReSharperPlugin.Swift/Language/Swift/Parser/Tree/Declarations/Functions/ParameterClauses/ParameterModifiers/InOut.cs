using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class InOut : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<InOut>
{
    public const string Keyword = "inout";
    
    public InOut()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal InOut(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Inout;

    public string KeywordValue => Keyword;

    public static InOut Create()
    {
        return new InOut(new EditableBuffer(Keyword));
    }
}
