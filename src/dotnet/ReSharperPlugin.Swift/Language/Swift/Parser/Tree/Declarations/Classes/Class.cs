using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Classures;

public class Class : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Class>
{
    public const string Keyword = "class";
    
    public Class()
        : base(new EditableBuffer())
    { }

    internal Class(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Class;

    public string KeywordValue => Keyword;

    public static Class Create()
    {
        return new Class(new EditableBuffer(Keyword));
    }
}
