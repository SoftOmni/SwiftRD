using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;

public class Enum : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Enum>
{
    public const string Keyword = "enum";
    
    public Enum()
        : base(new EditableBuffer(Keyword))
    { }

    internal Enum(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Enum;

    public string KeywordValue => Keyword;

    public static Enum Create()
    {
        return new Enum(new EditableBuffer(Keyword));
    }
}
