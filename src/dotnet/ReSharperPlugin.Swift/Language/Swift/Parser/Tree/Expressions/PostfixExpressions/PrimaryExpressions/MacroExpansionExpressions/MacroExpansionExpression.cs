using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.MacroExpansionExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace DefaultNamespace;

public class MacroExpansionExpression : SwiftCompositeNode, IMacroExpansionExpression
{
    public Hash Hash { get; }

    public IIdentifier Name { get; }

    public IGenericArgumentClause? GenericArgumentClause { get; }

    public IFunctionCallArgumentList? ParametersClause { get; }

    public ITrailingClosuresGroup? TrailingClosureParameters { get; }

    internal MacroExpansionExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Hash hash, IIdentifier name, IGenericArgumentClause? genericArgumentClause,
        IFunctionCallArgumentList? parametersClause, ITrailingClosuresGroup? trailingClosureParameters)
        : base(buffer, children)
    {
        Hash = hash;
        Name = name;
        GenericArgumentClause = genericArgumentClause;
        ParametersClause = parametersClause;
        TrailingClosureParameters = trailingClosureParameters;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyIdentifier IReadOnlyMacroExpansionExpression.Name => Name;
    
    IReadOnlyGenericArgumentClause? IReadOnlyMacroExpansionExpression.GenericArgumentClause => GenericArgumentClause;

    IReadOnlyFunctionCallArgumentList? IReadOnlyMacroExpansionExpression.ParametersClause => ParametersClause;

    IReadOnlyTrailingClosuresGroup? IReadOnlyMacroExpansionExpression.TrailingClosureParameters => TrailingClosureParameters;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeName(IIdentifier newName)
    {
        throw new System.NotImplementedException();
    }

    public void SetGenericArgumentClause(IGenericArgumentClause? newGenericArgumentClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveGenericArgumentClause()
    {
        throw new System.NotImplementedException();
    }

    public void SetParametersClause(IFunctionCallArgumentList? newParametersClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveParametersClause()
    {
        throw new System.NotImplementedException();
    }

    public void SetTrailingClosureParameters(ITrailingClosuresGroup? newTrailingClosureParameters)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveTRailingClosuresGroup()
    {
        throw new System.NotImplementedException();
    }
}
