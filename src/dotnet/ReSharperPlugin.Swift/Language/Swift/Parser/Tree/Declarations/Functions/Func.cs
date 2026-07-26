using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public class Func : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Func>
{
    public const string Keyword = "function";
    
    public Func()
        : base(new EditableBuffer(Keyword))
    { }

    internal Func(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Func;

    public string KeywordValue => Keyword;

    public static Func Create()
    {
        return new Func(new EditableBuffer(Keyword));
    }
}
