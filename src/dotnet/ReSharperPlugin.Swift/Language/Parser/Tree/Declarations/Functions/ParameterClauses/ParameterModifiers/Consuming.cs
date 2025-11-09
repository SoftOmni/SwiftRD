using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class Consuming : ParameterModifier, ISwiftKeyword
{
    public const string Keyword = "consuming";
    
    internal Consuming(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Consuming)
    { }

    internal Consuming(ISwiftNode parent, IEditableBuffer buffer) :
        base(parent, buffer, NodeTypes.NodeTypes.Consuming)
    { }

    internal Consuming(Parameter parameter, IEditableBuffer buffer) 
        : base(parameter, buffer, NodeTypes.NodeTypes.Consuming)
    { }

    public string KeywordValue => Keyword;

    public static Consuming Create()
    {
        return new Consuming(new EditableBuffer(Keyword));
    }

    public static Consuming Create(Parameter parameter)
    {
        return new Consuming(parameter, new EditableBuffer(Keyword));
    }

    public static Consuming CreateUnchecked(ISwiftNode parent)
    {
        return new Consuming(parent, new EditableBuffer(Keyword));
    }
}