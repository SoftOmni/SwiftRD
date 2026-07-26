using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.
    AvailabilityArguments;

public class PlatformAvailabilityArgument : SwiftCompositeNode, IPlatformAvailabilityArgument
{
    public IPlatformName Platform { get; }

    public IPlatformVersion Version { get; }

    internal PlatformAvailabilityArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPlatformName platform, IPlatformVersion version)
        : base(buffer, children)
    {
        Platform = platform;
        Version = version;
    }

    IReadOnlyPlatformName IReadOnlyPlatformAvailabilityArgument.Platform => Platform;

    IReadOnlyPlatformVersion IReadOnlyPlatformAvailabilityArgument.Version => Version;

    public void ChangePlatform(IPlatformName newPlatform)
    {
        throw new NotImplementedException();
    }

    public void ChangePlatformVersion(IPlatformVersion newVersion)
    {
        throw new NotImplementedException();
    }
}
