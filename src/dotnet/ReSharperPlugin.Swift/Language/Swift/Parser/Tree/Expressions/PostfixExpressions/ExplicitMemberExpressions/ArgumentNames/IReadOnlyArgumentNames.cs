using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;

public interface IReadOnlyArgumentNames : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyIdentifier>
{
    IReadOnlyList<IReadOnlyIdentifier> Names { get; }
    
    IReadOnlyList<Colon> Colons { get; }
}

