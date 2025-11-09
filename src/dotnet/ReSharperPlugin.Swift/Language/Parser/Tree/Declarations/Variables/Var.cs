using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables;

public class Var : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "var";
    
    public Variable? Variable { get; private set; }
    
    internal Var(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Var)
    { }

    internal Var(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Var)
    {
        if (parent is Variable variable)
        {
            Variable = variable;
        }
    }

    internal Var(Variable variable, IEditableBuffer buffer)
        : base(variable, buffer, NodeTypes.NodeTypes.Var)
    {
        Variable = variable;
    }

    public string KeywordValue => Keyword;

    public static Var Create()
    {
        return new Var(new EditableBuffer(Keyword));
    }

    public static Var Create(Variable variable)
    {
        return new Var(variable, new EditableBuffer(Keyword));
    }

    public static Var CreateUnchecked(ISwiftNode parent)
    {
        return new Var(parent, new EditableBuffer(Keyword));
    }
}