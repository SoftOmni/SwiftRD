using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Required : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Required>
{
    public const string Keyword = "required";

    public Required()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Required(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Required;

    public string KeywordValue => Keyword;

    public static Required Create()
    {
        return new Required(new EditableBuffer(Keyword));
    }
}
