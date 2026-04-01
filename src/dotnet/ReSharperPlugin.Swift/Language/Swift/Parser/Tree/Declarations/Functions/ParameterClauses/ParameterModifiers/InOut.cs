using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class InOut : ParameterModifier, ISwiftKeyword
{
    public const string Keyword = "inout";
    
    internal InOut(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Inout)
    { }

    internal InOut(SwiftInternalNode parent, IEditableBuffer buffer) :
        base(parent, buffer, SwiftNodeTypes.Inout)
    { }

    internal InOut(Parameter parameter, IEditableBuffer buffer) 
        : base(parameter, buffer, SwiftNodeTypes.Inout)
    { }

    public string KeywordValue => Keyword;

    public static InOut Create()
    {
        return new InOut(new EditableBuffer(Keyword));
    }

    public static InOut Create(Parameter parameter)
    {
        return new InOut(parameter, new EditableBuffer(Keyword));
    }

    public static InOut CreateUnchecked(SwiftInternalNode parent)
    {
        return new InOut(parent, new EditableBuffer(Keyword));
    }
}