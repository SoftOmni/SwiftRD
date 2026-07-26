using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions.CompilerVersions;

public class CompilerVersionPlatformCondition : SwiftCompositeNode, ICompilerVersionPlatformCondition
{
    public IReadOnlyIdentifier PlatformConditionFunction { get; }

    public LeftParenthesis PlatformConditionFunctionArgumentsStart { get; }

    public IReadOnlyOperator Operator { get; }

    public ISwiftVersion SwiftVersion { get; }

    public RightParenthesis PlatformConditionFunctionArgumentsEnd { get; }

    internal CompilerVersionPlatformCondition(IEditableBuffer buffer,
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

    IReadOnlySwiftVersion IReadOnlyCompilerVersionPlatformCondition.SwiftVersion => SwiftVersion;

    public bool Evaluatable()
    {
        throw new System.NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new System.NotImplementedException();
    }

    public void IsLessThan()
    {
        throw new System.NotImplementedException();
    }

    public void IsGreaterThanOrEqual()
    {
        throw new System.NotImplementedException();
    }

    public void MakeLessThan()
    {
        throw new System.NotImplementedException();
    }

    public void MakeGreaterThanOrEqual()
    {
        throw new System.NotImplementedException();
    }
}
