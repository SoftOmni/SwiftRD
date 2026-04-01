using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class Borrowing : ParameterModifier, ISwiftKeyword
{
    public const string Keyword = "borrowing";
    
    internal Borrowing(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Borrowing)
    { }

    internal Borrowing(SwiftInternalNode parent, IEditableBuffer buffer) :
        base(parent, buffer, SwiftNodeTypes.Borrowing)
    { }

    internal Borrowing(Parameter parameter, IEditableBuffer buffer) 
        : base(parameter, buffer, SwiftNodeTypes.Borrowing)
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

    public static Borrowing CreateUnchecked(SwiftInternalNode parent)
    {
        return new Borrowing(parent, new EditableBuffer(Keyword));
    }
}