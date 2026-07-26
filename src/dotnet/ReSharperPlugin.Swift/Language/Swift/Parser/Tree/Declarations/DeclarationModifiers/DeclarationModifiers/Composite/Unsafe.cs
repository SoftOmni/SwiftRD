using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public class Unsafe : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Unsafe>
{
    public const string Keyword = "unsafe";

    public Unsafe()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Unsafe(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Unsafe;

    public string KeywordValue => Keyword;

    public static Unsafe Create()
    {
        return new Unsafe(new EditableBuffer(Keyword));
    }
}
