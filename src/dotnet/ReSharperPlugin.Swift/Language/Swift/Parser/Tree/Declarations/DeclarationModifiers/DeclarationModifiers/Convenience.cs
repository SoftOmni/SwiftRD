using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Convenience : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Convenience>
{
    public const string Keyword = "convenience";
    
    public Convenience()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Convenience(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Convenience;

    public string KeywordValue => Keyword;

    public static Convenience Create()
    {
        return new Convenience(new EditableBuffer(Keyword));
    }
}
