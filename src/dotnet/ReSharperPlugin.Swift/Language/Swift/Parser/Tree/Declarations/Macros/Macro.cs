using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Macros;

public class Macro : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Macro>
{
    public const string Keyword = "macro";
    
    public Macro()
        : base(new EditableBuffer(Keyword))
    { }

    internal Macro(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Macro;

    public string KeywordValue => Keyword;

    public static Macro Create()
    {
        return new Macro(new EditableBuffer(Keyword));
    }
}
