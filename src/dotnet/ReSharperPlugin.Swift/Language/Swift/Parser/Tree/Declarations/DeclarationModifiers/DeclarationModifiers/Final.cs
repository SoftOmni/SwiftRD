using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Final : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Final>
{
    public const string Keyword = "final";
    
    public Final()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Final(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Final;
    
    public string KeywordValue => Keyword;

    public static Final Create()
    {
        return new Final(new EditableBuffer(Keyword));
    }
}
