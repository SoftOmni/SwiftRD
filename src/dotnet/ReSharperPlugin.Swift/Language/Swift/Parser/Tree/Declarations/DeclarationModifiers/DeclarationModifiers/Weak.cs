using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Weak : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Weak>
{
    public const string Keyword = "weak";
    
    public Weak()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Weak(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Weak;

    public string KeywordValue => Keyword;

    public static Weak Create()
    {
        return new Weak(new EditableBuffer(Keyword));
    }
}
