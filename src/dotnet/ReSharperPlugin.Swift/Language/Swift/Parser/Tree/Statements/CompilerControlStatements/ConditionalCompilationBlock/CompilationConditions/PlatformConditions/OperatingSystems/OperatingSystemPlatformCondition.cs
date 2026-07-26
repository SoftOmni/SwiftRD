using System;
using System.Collections.Generic;
using JetBrains.Text;
using JetBrains.Util;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions.OperatingSystems;

public class OperatingSystemPlatformCondition : SwiftCompositeNode, IOperatingSystemPlatformCondition
{
    public const string OperatingSystemPlatformConditionFunctionNameString = "os";
    
    public IReadOnlyIdentifier PlatformConditionFunction { get; }

    public LeftParenthesis PlatformConditionFunctionArgumentsStart { get; }

    public RightParenthesis PlatformConditionFunctionArgumentsEnd { get; }

    public IIdentifier OperatingSystem { get; }

    internal OperatingSystemPlatformCondition(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IReadOnlyIdentifier platformConditionFunction,
        LeftParenthesis platformConditionFunctionArgumentsStart, RightParenthesis platformConditionFunctionArgumentsEnd,
        IIdentifier operatingSystem)
        : base(buffer, children)
    {
        PlatformConditionFunction = platformConditionFunction;
        PlatformConditionFunctionArgumentsStart = platformConditionFunctionArgumentsStart;
        PlatformConditionFunctionArgumentsEnd = platformConditionFunctionArgumentsEnd;
        OperatingSystem = operatingSystem;
    }

    IReadOnlyIdentifier IReadOnlyOperatingSystemPlatformCondition.OperatingSystem => OperatingSystem;
    
    public const string MacOsOperatingSystemString = "macOS";

    public const string IOsOperatingSystemString = "iOS";

    public const string WatchOsOperatingSystemString = "watchOS";

    public const string TvOsOperatingSystemString = "tvOS";

    public const string VisionOsOperatingSystemString = "visionOS";

    public const string LinuxOperatingSystemString = "Linux";

    public const string WindowsOperatingSystemString = "Windows";

    public const string AndroidOperatingSystemString = "Android";

    public const string BsdOperatingSystemString = "BSD";

    public bool Evaluatable()
    {
        return Environment.OSVersion.Platform switch
        {
            PlatformID.MacOSX or
                PlatformID.Win32NT or
                PlatformID.Win32S or
                PlatformID.WinCE
                or PlatformID.Win32Windows => true,
            _ => false
        };
    }

    public bool Evaluate()
    {
        return Environment.OSVersion.Platform switch
        {
            PlatformID.MacOSX => IsMacOs(),
            PlatformID.Win32NT or PlatformID.Win32S or PlatformID.WinCE or PlatformID.Win32Windows => IsWindows(),
            _ => false
        };
    }

    public bool IsMacOs()
    {
        return OperatingSystem.Buffer.CompareBufferText(new TextRange(), MacOsOperatingSystemString);
    }

    public bool IsIOs()
    {
        return OperatingSystem.Buffer.CompareBufferText(new TextRange(), IOsOperatingSystemString);
    }

    public bool IsWatchOs()
    {
        return OperatingSystem.Buffer.CompareBufferText(new TextRange(), WatchOsOperatingSystemString);
    }

    public bool IsTvOs()
    {
        return OperatingSystem.Buffer.CompareBufferText(new TextRange(), TvOsOperatingSystemString);
    }

    public bool IsVisionOs()
    {
        return OperatingSystem.Buffer.CompareBufferText(new TextRange(), VisionOsOperatingSystemString);
    }

    public bool IsLinux()
    {
        return OperatingSystem.Buffer.CompareBufferText(new TextRange(), LinuxOperatingSystemString);
    }

    public bool IsWindows()
    {
        return OperatingSystem.Buffer.CompareBufferText(new TextRange(), WindowsOperatingSystemString);
    }

    public bool IsAndroid()
    {
        return OperatingSystem.Buffer.CompareBufferText(new TextRange(), AndroidOperatingSystemString);
    }

    public bool IsBsd()
    {
        return OperatingSystem.Buffer.CompareBufferText(new TextRange(), BsdOperatingSystemString);
    }

    public bool IsXnuBased()
    {
        return IsMacOs() || IsIOs() || IsWatchOs() || IsTvOs() || IsVisionOs();
    }

    public void ChangeOperatingSystem(IIdentifier newOperatingSystemIdentifier)
    {
        throw new NotImplementedException();
    }

    public void ChangeToMacOs()
    {
        throw new NotImplementedException();
    }

    public void ChangeToIOs()
    {
        throw new NotImplementedException();
    }

    public void ChangeToWatchOs()
    {
        throw new NotImplementedException();
    }

    public void ChangeToTvOs()
    {
        throw new NotImplementedException();
    }

    public void ChangeToVisionOs()
    {
        throw new NotImplementedException();
    }

    public void ChangeToLinux()
    {
        throw new NotImplementedException();
    }

    public void ChangeToWindows()
    {
        throw new NotImplementedException();
    }

    public void ChangeToAndroid()
    {
        throw new NotImplementedException();
    }
}