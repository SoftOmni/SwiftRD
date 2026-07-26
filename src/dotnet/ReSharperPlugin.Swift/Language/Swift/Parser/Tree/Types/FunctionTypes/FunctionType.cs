using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;
using SoftOmni.SwiftRd.Language.Swift.Semantics;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

public class FunctionType : SwiftCompositeNode, IFunctionType
{
    public FunctionType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children)
        : base(buffer, children)
    { }

    public IReadOnlyDeclaration? Declaration { get; }
    public IReadOnlyType ActualType { get; }
    public string TypeSignature { get; }
    public IReadOnlyType? SuperType { get; }
    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains { get; }
    public IReadOnlySet<IReadOnlyType> SubTypes { get; }
    public IReadOnlySet<string> SubTypeNames { get; }
    public bool IsFromStandardLibrary { get; }
    IReadOnlyAttributeGroup? IReadOnlyFunctionType.AttributeGroup => AttributeGroup;

    public IFunctionTypeArgumentList ArgumentList { get; }
    public Ellipsis? Ellipsis { get; }
    public IThrowsClause? ThrowsClause { get; }
    public IType ReturnType { get; }

    public int Size { get; }

    public bool AddIfNotAlreadyPresentAttributeGroup(IAttributeGroup attributeGroup)
    {
        throw new NotImplementedException();
    }

    public void ChangeAttributeGroup(IAttributeGroup? attributeGroup)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributeGroup()
    {
        throw new NotImplementedException();
    }

    public void SetToNotThrow()
    {
        throw new NotImplementedException();
    }

    public void SetThrowsClauseToThrowGenerically()
    {
        throw new NotImplementedException();
    }

    public void SetThrowsClauseToThrowError(IType errorType)
    {
        throw new NotImplementedException();
    }

    public void ChangeReturnType(IType type)
    {
        throw new NotImplementedException();
    }

    public void MakeFunctionReturnVoid(VoidFormatting voidFormatting)
    {
        throw new NotImplementedException();
    }

    public void MakeFunctionNotReturn()
    {
        throw new NotImplementedException();
    }

    public void MakeFunctionVariadic()
    {
        throw new NotImplementedException();
    }

    public void MakeFunctionNonVariadic()
    {
        throw new NotImplementedException();
    }

    public IAttributeGroup? AttributeGroup { get; }
    public LeftParenthesis LeftParenthesis { get; }
    IReadOnlyFunctionTypeArgumentList IReadOnlyFunctionType.ArgumentList => ArgumentList;

    public Async? Async { get; }
    IReadOnlyThrowsClause? IReadOnlyFunctionType.ThrowsClause => ThrowsClause;

    public Arrow Arrow { get; }
    IReadOnlyType IReadOnlyFunctionType.ReturnType => ReturnType;
}
