using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Postfix : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Postfix>
{
    public const string Keyword = "postfix";
    
    public Postfix()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Postfix(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Postfix;

    public string KeywordValue => Keyword;

    public static Postfix Create()
    {
        return new Postfix(new EditableBuffer(Keyword));
    }
}
