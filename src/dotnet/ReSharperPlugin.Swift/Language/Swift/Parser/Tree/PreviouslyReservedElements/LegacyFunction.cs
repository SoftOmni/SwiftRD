using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.PreviouslyReservedElements;

public class LegacyFunction : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<LegacyFunction>
{
    public const string Keyword = "#function";
    
    public LegacyFunction()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal LegacyFunction(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PreviouslyReservedFunction;

    public string KeywordValue => Keyword;

    public static LegacyFunction Create()
    {
        return new LegacyFunction();
    }
}

