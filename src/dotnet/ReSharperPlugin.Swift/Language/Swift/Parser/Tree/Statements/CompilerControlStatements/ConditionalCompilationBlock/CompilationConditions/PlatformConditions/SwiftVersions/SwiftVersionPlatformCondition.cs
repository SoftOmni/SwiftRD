using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions.SwiftVersions;

public class SwiftVersionPlatformCondition : SwiftCompositeNode, ISwiftVersionPlatformCondition
{
    public IReadOnlyIdentifier PlatformConditionFunction { get; }

    public LeftParenthesis PlatformConditionFunctionArgumentsStart { get; }

    public IReadOnlyOperator Operator { get; }

    public ISwiftVersion SwiftVersion { get; }

    public RightParenthesis PlatformConditionFunctionArgumentsEnd { get; }

    internal SwiftVersionPlatformCondition(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IReadOnlyIdentifier platformConditionFunction, LeftParenthesis platformConditionFunctionArgumentsStart,
        IReadOnlyOperator @operator, ISwiftVersion swiftVersion, RightParenthesis platformConditionFunctionArgumentsEnd)
        : base(buffer, children)
    {
        PlatformConditionFunction = platformConditionFunction;
        PlatformConditionFunctionArgumentsStart = platformConditionFunctionArgumentsStart;
        Operator = @operator;
        SwiftVersion = swiftVersion;
        PlatformConditionFunctionArgumentsEnd = platformConditionFunctionArgumentsEnd;
    }

    IReadOnlySwiftVersion IReadOnlySwiftVersionPlatformCondition.SwiftVersion => SwiftVersion;

    public bool Evaluatable()
    {
        throw new NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new NotImplementedException();
    }

    public void IsLessThan()
    {
        throw new NotImplementedException();
    }

    public void IsGreaterThanOrEqual()
    {
        throw new NotImplementedException();
    }

    public void MakeLessThan()
    {
        throw new NotImplementedException();
    }

    public void MakeGreaterThanOrEqual()
    {
        throw new NotImplementedException();
    }
}
