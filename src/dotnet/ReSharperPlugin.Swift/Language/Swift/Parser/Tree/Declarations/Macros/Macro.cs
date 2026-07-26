using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Macros;

public class MacroKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<MacroKeyword>
{
    public const string Keyword = "macro";
    
    public MacroKeyword()
        : base(new EditableBuffer(Keyword))
    { }

    internal MacroKeyword(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Macro;

    public string KeywordValue => Keyword;

    public static MacroKeyword Create()
    {
        return new MacroKeyword(new EditableBuffer(Keyword));
    }
}
