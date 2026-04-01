using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

public class OperatorKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "operator";
    
    public OperatorDeclaration? OperatorDeclaration { get; internal set; }

    internal OperatorKeyword(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Operator)
    { }

    internal OperatorKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Operator)
    {
        if (parent is OperatorDeclaration operatorDeclaration)
        {
            OperatorDeclaration = operatorDeclaration;
        }
    }

    internal OperatorKeyword(OperatorDeclaration parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Operator)
    {
        OperatorDeclaration = parent;
    }

    public string KeywordValue => Keyword;

    public static OperatorKeyword Create()
    {
        return new OperatorKeyword(new EditableBuffer(Keyword));
    }

    public static OperatorKeyword Create(OperatorDeclaration operatorDeclaration)
    {
        return new OperatorKeyword(operatorDeclaration, new EditableBuffer(Keyword));
    }

    public static OperatorKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new OperatorKeyword(parent, new EditableBuffer(Keyword));
    }
}