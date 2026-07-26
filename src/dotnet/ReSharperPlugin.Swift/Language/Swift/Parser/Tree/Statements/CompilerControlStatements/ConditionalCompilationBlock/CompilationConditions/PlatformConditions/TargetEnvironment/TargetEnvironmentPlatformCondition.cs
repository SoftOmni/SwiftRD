using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.TargetEnvironment;

public class TargetEnvironmentPlatformCondition : SwiftCompositeNode, ITargetEnvironmentPlatformCondition
{
    public const string TargetEnvironmentPlatformConditionFunctionNameString = "targetEnvironment";

    public IReadOnlyIdentifier PlatformConditionFunction { get; }

    public LeftParenthesis PlatformConditionFunctionArgumentsStart { get; }

    public IIdentifier TargetEnvironment { get; }

    public RightParenthesis PlatformConditionFunctionArgumentsEnd { get; }

    internal TargetEnvironmentPlatformCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IReadOnlyIdentifier platformConditionFunction, LeftParenthesis platformConditionFunctionArgumentsStart,
        IIdentifier targetEnvironment, RightParenthesis platformConditionFunctionArgumentsEnd)
        : base(buffer, children)
    {
        PlatformConditionFunction = platformConditionFunction;
        PlatformConditionFunctionArgumentsStart = platformConditionFunctionArgumentsStart;
        TargetEnvironment = targetEnvironment;
        PlatformConditionFunctionArgumentsEnd = platformConditionFunctionArgumentsEnd;
    }

    IReadOnlyIdentifier IReadOnlyTargetEnvironmentPlatformCondition.TargetEnvironment => TargetEnvironment;

    public bool Evaluatable()
    {
        throw new NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new NotImplementedException();
    }

    public bool IsSimulator()
    {
        throw new NotImplementedException();
    }

    public bool IsMacCatalyst()
    {
        throw new NotImplementedException();
    }

    public bool IsVirtualized()
    {
        throw new NotImplementedException();
    }

    public bool IsRepl()
    {
        throw new NotImplementedException();
    }

    public bool IsPureInterpreted()
    {
        throw new NotImplementedException();
    }

    public bool IsJustInTimeCompiled()
    {
        throw new NotImplementedException();
    }

    public void MakeSimulator()
    {
        throw new NotImplementedException();
    }

    public void MakeMacCatalyst()
    {
        throw new NotImplementedException();
    }

    public void MakeVirtualized()
    {
        throw new NotImplementedException();
    }

    public void MakeRepl()
    {
        throw new NotImplementedException();
    }

    public void MakePureInterpreted()
    {
        throw new NotImplementedException();
    }

    public void MakeJustInTimeCompiled()
    {
        throw new NotImplementedException();
    }

    public void ChangeTargetEnvironment(IIdentifier newTargetEnvironment)
    {
        throw new NotImplementedException();
    }
}
