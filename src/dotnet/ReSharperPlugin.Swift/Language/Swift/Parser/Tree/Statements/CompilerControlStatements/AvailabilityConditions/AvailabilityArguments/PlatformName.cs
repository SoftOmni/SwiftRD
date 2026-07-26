using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.
    AvailabilityArguments;

public class PlatformName : SwiftCompositeNode, IPlatformName
{
    public IIdentifier Platform { get; }

    internal PlatformName(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier platform)
        : base(buffer, children)
    {
        Platform = platform;
    }

    IReadOnlyIdentifier IReadOnlyPlatformName.Platform => Platform;

    public const string IOsPlatformString = "iOS";
    
    public const string IOsApplicationExtensionPlatformString = "iOSApplicationExtension";

    public const string MacOsPlatformString = "macOS";
    
    public const string MacOsApplicationExtensionPlatformString = "macOSApplicationExtension";

    public const string WatchOsPlatformString = "watchOS";
    
    public const string WatchOsApplicationExtensionPlatformString = "watchOSApplicationExtension";

    public const string TvOsPlatformString = "tvOS";
    
    public const string TvOsApplicationExtensionPlatformString = "tvOSApplicationExtension";

    public const string VisionOsPlatformString = "visionOS";
    
    public const string VisionOsApplicationExtensionPlatformString = "visionOSApplicationExtension";

    public bool IsExtension()
    {
        throw new NotImplementedException();
    }

    public bool IsStandalone()
    {
        throw new NotImplementedException();
    }

    public bool IsIOs()
    {
        throw new NotImplementedException();
    }

    public bool IsMacOs()
    {
        throw new NotImplementedException();
    }

    public bool IsWatchOs()
    {
        throw new NotImplementedException();
    }

    public bool IsTvOs()
    {
        throw new NotImplementedException();
    }

    public bool IsVisionOs()
    {
        throw new NotImplementedException();
    }

    public void ChangePlatform(IIdentifier newPlatform)
    {
        throw new NotImplementedException();
    }

    public void MakeExtension()
    {
        throw new NotImplementedException();
    }

    public void MakeStandalone()
    {
        throw new NotImplementedException();
    }

    public void MakeIOs()
    {
        throw new NotImplementedException();
    }

    public void MakeMacOs()
    {
        throw new NotImplementedException();
    }

    public void MakeWatchOs()
    {
        throw new NotImplementedException();
    }

    public void MakeTvOs()
    {
        throw new NotImplementedException();
    }

    public void MakeVisionOs()
    {
        throw new NotImplementedException();
    }
}
