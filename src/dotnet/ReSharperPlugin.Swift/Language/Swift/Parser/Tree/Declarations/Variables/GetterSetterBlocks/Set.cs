using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;

public class Set : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Set>
{
    public const string Keyword = "set";
    
    public Set()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Set(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Set;

    public string KeywordValue => Keyword;

    public static Set Create()
    {
        return new Set(new EditableBuffer(Keyword));
    }
}
