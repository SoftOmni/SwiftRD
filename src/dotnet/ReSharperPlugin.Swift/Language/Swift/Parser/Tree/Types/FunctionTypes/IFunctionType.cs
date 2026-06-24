using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;
using SoftOmni.SwiftRd.Language.Swift.Semantics;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

public interface IFunctionType : IReadOnlyFunctionType, IType
{
    new IAttributeGroup? AttributeGroup { get; }
    
    new IFunctionTypeArgumentList ArgumentList { get; }
    
    new IThrowsClause? ThrowsClause { get; }
    
    new IType ReturnType { get; }

    bool AddIfNotAlreadyPresentAttributeGroup(IAttributeGroup attributeGroup);
    
    void ChangeAttributeGroup(IAttributeGroup? attributeGroup);

    void RemoveAttributeGroup();

    void SetToNotThrow();

    void SetThrowsClauseToThrowGenerically();

    void SetThrowsClauseToThrowError(IType errorType);

    void ChangeReturnType(IType type);

    void MakeFunctionReturnVoid(VoidFormatting voidFormatting);

    void MakeFunctionNotReturn();

    void MakeFunctionVariadic();

    void MakeFunctionNonVariadic();
}
