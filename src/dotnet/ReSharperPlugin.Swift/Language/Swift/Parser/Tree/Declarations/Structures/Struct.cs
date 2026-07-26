using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Structs;

public class Struct : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Struct>
{
    public const string Keyword = "struct";
    
    public Struct()
        : base(new EditableBuffer())
    { }

    internal Struct(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Struct;

    public string KeywordValue => Keyword;

    public static Struct Create()
    {
        return new Struct(new EditableBuffer(Keyword));
    }
}
