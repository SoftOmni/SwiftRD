using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Final : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "final";
    
    internal Final(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public Final(IEditableBuffer buffer, SwiftCompositeNode parent, int parentIndex, int parentTextIndex)
        : base(buffer, parent, parentIndex, parentTextIndex)
    { }

    public string KeywordValue => Keyword;

    public override NodeType NodeType => SwiftNodeTypes.Final;

    public static Final Create()
    {
        return new Final(new EditableBuffer(Keyword));
    }

    public static Final Create(SwiftCompositeNode parent, int parentIndex, int parentTextIndex)
    {
        return new Final(new EditableBuffer(Keyword), parent, parentIndex, parentTextIndex);
    }
}