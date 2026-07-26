using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

public class FilePrivate : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<FilePrivate>
{
    public const string Keyword = "fileprivate";
    
    public FilePrivate()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal FilePrivate(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.FilePrivate;

    public string KeywordValue => Keyword;

    public static FilePrivate Create()
    {
        return new FilePrivate();
    }
}