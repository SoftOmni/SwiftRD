using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public interface IPlatformVersion : IReadOnlyPlatformVersion
{
    new IIntegerLiteral MajorVersion { get; }
    
    new IIntegerLiteral? MinorVersion { get; }
    
    new IIntegerLiteral? PatchVersion { get; }

    void ChangeMajorVersion(IIntegerLiteral newValue);

    void SetMinorVersionTo(IIntegerLiteral value);

    void RemoveAndNullifyMinorAndPatchVersion();

    void SetPatchVersionTo(IIntegerLiteral value);

    void SetMinorAndPatchVersionTo(IIntegerLiteral minorValue, IIntegerLiteral patchValue);

    void RemoveAndNullifyPatchVersion();
}
