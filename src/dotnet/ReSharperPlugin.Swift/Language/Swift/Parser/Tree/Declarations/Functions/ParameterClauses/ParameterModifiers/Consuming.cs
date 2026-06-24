using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class Consuming : ParameterModifier, ISwiftKeywordNode
{
    public const string Keyword = "consuming";
    
    internal Consuming(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Consuming)
    { }

    internal Consuming(SwiftInternalNode parent, IEditableBuffer buffer) :
        base(parent, buffer, SwiftNodeTypes.Consuming)
    { }

    internal Consuming(Parameter parameter, IEditableBuffer buffer) 
        : base(parameter, buffer, SwiftNodeTypes.Consuming)
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

    public static Consuming CreateUnchecked(SwiftInternalNode parent)
    {
        return new Consuming(parent, new EditableBuffer(Keyword));
    }
}