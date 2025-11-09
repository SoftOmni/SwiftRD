using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class Borrowing : ParameterModifier, ISwiftKeyword
{
    public const string Keyword = "borrowing";
    
    internal Borrowing(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Borrowing)
    { }

    internal Borrowing(ISwiftNode parent, IEditableBuffer buffer) :
        base(parent, buffer, NodeTypes.NodeTypes.Borrowing)
    { }

    internal Borrowing(Parameter parameter, IEditableBuffer buffer) 
        : base(parameter, buffer, NodeTypes.NodeTypes.Borrowing)
    { }

    public string KeywordValue => Keyword;

    public static Borrowing Create()
    {
        return new Borrowing(new EditableBuffer(Keyword));
    }

    public static Borrowing Create(Parameter parameter)
    {
        return new Borrowing(parameter, new EditableBuffer(Keyword));
    }

    public static Borrowing CreateUnchecked(ISwiftNode parent)
    {
        return new Borrowing(parent, new EditableBuffer(Keyword));
    }
}