using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public interface IInfixOperatorGroup : IReadOnlyInfixOperatorGroup
{
    new IIdentifier PrecedenceGroupName { get; }

    void ChangePrecedenceGroupName(IIdentifier newPrecedenceGroupName);
}
