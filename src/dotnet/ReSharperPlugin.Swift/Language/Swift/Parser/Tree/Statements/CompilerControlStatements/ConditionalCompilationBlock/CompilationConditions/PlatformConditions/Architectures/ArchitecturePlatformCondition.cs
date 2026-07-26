using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions.Architectures;

public class ArchitecturePlatformCondition : SwiftCompositeNode, IArchitecturePlatformCondition
{    
    public const string ArchitecturePlatformConditionFunctionNameString = "arch";

    public IReadOnlyIdentifier PlatformConditionFunction { get; }

    public LeftParenthesis PlatformConditionFunctionArgumentsStart { get; }

    public IIdentifier Architecture { get; }

    public RightParenthesis PlatformConditionFunctionArgumentsEnd { get; }

    internal ArchitecturePlatformCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IReadOnlyIdentifier platformConditionFunction, LeftParenthesis platformConditionFunctionArgumentsStart,
        IIdentifier architecture, RightParenthesis platformConditionFunctionArgumentsEnd)
        : base(buffer, children)
    {
        PlatformConditionFunction = platformConditionFunction;
        PlatformConditionFunctionArgumentsStart = platformConditionFunctionArgumentsStart;
        Architecture = architecture;
        PlatformConditionFunctionArgumentsEnd = platformConditionFunctionArgumentsEnd;
    }

    IReadOnlyIdentifier IReadOnlyArchitecturePlatformCondition.Architecture => Architecture;

    public bool Evaluatable()
    {
        throw new NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new NotImplementedException();
    }

    public bool Is64BitX86()
    {
        throw new NotImplementedException();
    }

    public bool Is32BitX86()
    {
        throw new NotImplementedException();
    }

    public bool IsX86()
    {
        return Is64BitX86() || Is32BitX86();
    }

    public bool IsI386()
    {
        return Is32BitX86();
    }

    public bool IsArm32()
    {
        throw new NotImplementedException();
    }

    public bool IsArm64()
    {
        throw new NotImplementedException();
    }

    public bool IsArm()
    {
        return IsArm64() || IsArm32();
    }

    public bool IsWasm32()
    {
        throw new NotImplementedException();
    }

    public bool IsWasm64()
    {
        throw new NotImplementedException();
    }

    public bool IsWasm()
    {
        return IsWasm32() || IsWasm64();
    }

    public bool Is32Bit()
    {
        return Is32BitX86() || IsArm32() || IsWasm32();
    }

    public bool Is64Bit()
    {
        return Is64BitX86() || IsArm64() || IsWasm64();
    }

    public int ArchitectureBitWidth()
    {
        throw new NotImplementedException();
    }

    public int ArchitectureByeWidth()
    {
        throw new NotImplementedException();
    }

    public void ChangeOperatingSystem(IIdentifier newArchitecture)
    {
        throw new NotImplementedException();
    }

    public void ChangeTo32BitX86()
    {
        throw new NotImplementedException();
    }

    public void ChangeTo64BitX86()
    {
        throw new NotImplementedException();
    }

    public void ChangeTo32BitArm()
    {
        throw new NotImplementedException();
    }

    public void ChangeTo64BitArm()
    {
        throw new NotImplementedException();
    }

    public void ChangeTo32BitWasm()
    {
        throw new NotImplementedException();
    }

    public void ChangeTo64BitWasm()
    {
        throw new NotImplementedException();
    }

    public void ChangeTo32BitVersion()
    {
        throw new NotImplementedException();
    }

    public void ChangeTo64BitVersion()
    {
        throw new NotImplementedException();
    }
}
