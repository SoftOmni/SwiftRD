using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public class InfixOperatorGroup : SwiftCompositeNode, IInfixOperatorGroup
{
    public Colon InfixOperatorGroupIntroducer { get; }

    public IIdentifier PrecedenceGroupName { get; }

    internal InfixOperatorGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Colon infixOperatorGroupIntroducer, IIdentifier precedenceGroupName)
        : base(buffer, children)
    {
        InfixOperatorGroupIntroducer = infixOperatorGroupIntroducer;
        PrecedenceGroupName = precedenceGroupName;
    }

    IReadOnlyIdentifier IReadOnlyInfixOperatorGroup.PrecedenceGroupName => PrecedenceGroupName;

    public void ChangePrecedenceGroupName(IIdentifier newPrecedenceGroupName)
    {
        throw new System.NotImplementedException();
    }
}
