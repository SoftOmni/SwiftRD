using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public class PlatformVersion : SwiftCompositeNode, IPlatformVersion
{
    public IIntegerLiteral MajorVersion { get; }
    
    public Period? MajorMinorVersionSeparator { get; }
    
    public IIntegerLiteral? MinorVersion { get; }
    
    public Period? MinorPatchVersionSeparator { get; }
    
    public IIntegerLiteral? PatchVersion { get; }

    internal PlatformVersion(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IIntegerLiteral majorVersion, Period? majorMinorVersionSeparator, IIntegerLiteral? minorVersion, Period? minorPatchVersionSeparator, IIntegerLiteral? patchVersion)
        : base(buffer, children)
    {
        MajorVersion = majorVersion;
        MajorMinorVersionSeparator = majorMinorVersionSeparator;
        MinorVersion = minorVersion;
        MinorPatchVersionSeparator = minorPatchVersionSeparator;
        PatchVersion = patchVersion;
    }

    IReadOnlyIntegerLiteral IReadOnlyPlatformVersion.MajorVersion => MajorVersion;

    IReadOnlyIntegerLiteral? IReadOnlyPlatformVersion.MinorVersion => MinorVersion;

    IReadOnlyIntegerLiteral? IReadOnlyPlatformVersion.PatchVersion => PatchVersion;

    public void ChangeMajorVersion(IIntegerLiteral newValue)
    {
        throw new NotImplementedException();
    }

    public void SetMinorVersionTo(IIntegerLiteral value)
    {
        throw new NotImplementedException();
    }

    public void RemoveAndNullifyMinorAndPatchVersion()
    {
        throw new NotImplementedException();
    }

    public void SetPatchVersionTo(IIntegerLiteral value)
    {
        throw new NotImplementedException();
    }

    public void SetMinorAndPatchVersionTo(IIntegerLiteral minorValue, IIntegerLiteral patchValue)
    {
        throw new NotImplementedException();
    }

    public void RemoveAndNullifyPatchVersion()
    {
        throw new NotImplementedException();
    }
}
