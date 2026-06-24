using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public class Type : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Type>
{
    public const string Keyword = "Type";
    
    public Type()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Type(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Type;

    public string KeywordValue => Keyword;

    public static Type Create()
    {
        return new Type(new EditableBuffer(Keyword));
    }
}
