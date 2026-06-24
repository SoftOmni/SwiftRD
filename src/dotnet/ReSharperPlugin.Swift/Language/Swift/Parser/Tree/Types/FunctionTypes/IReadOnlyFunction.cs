using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

public interface IReadOnlyFunctionType : IReadOnlyType
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }

    LeftParenthesis LeftParenthesis { get; }

    IReadOnlyFunctionTypeArgumentList ArgumentList { get; }
    
    Ellipsis? Ellipsis { get; }
    
    Async? Async { get; }
    
    IReadOnlyThrowsClause? ThrowsClause { get; }
    
    Arrow Arrow { get; }
    
    IReadOnlyType ReturnType { get; }
}
