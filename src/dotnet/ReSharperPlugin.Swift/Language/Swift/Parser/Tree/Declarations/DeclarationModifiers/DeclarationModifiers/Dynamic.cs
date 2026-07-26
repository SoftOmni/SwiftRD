using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Dynamic : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Dynamic>
{
    public const string Keyword = "dynamic";
    
    public Dynamic()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Dynamic(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Dynamic;

    public string KeywordValue => Keyword;

    public static Dynamic Create()
    {
        return new Dynamic(new EditableBuffer(Keyword));
    }
}
