using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public class Let : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "let";
    
    public Constant? Constant { get; private set; }
    
    internal Let(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Let)
    { }

    internal Let(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Let)
    {
        if (parent is Constant constant)
        {
            Constant = constant;
        }
    }

    internal Let(Constant constant, IEditableBuffer buffer)
        : base(constant, buffer, SwiftNodeTypes.Let)
    {
        Constant = constant;
    }

    public string KeywordValue => Keyword;

    public static Let Create()
    {
        return new Let(new EditableBuffer(Keyword));
    }

    public static Let Create(Constant constant)
    {
        return new Let(constant, new EditableBuffer(Keyword));
    }

    public static Let CreateUnchecked(SwiftInternalNode parent)
    {
        return new Let(parent, new EditableBuffer(Keyword));
    }
}