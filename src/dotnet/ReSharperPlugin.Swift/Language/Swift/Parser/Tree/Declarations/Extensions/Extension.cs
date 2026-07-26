using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

public class Extension : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Extension>
{
    public const string Keyword = "extension";
    
    public Extension()
        : base(new EditableBuffer())
    { }

    internal Extension(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Extension;

    public string KeywordValue => Keyword;

    public static Extension Create()
    {
        return new Extension(new EditableBuffer(Keyword));
    }
}
