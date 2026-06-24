using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

public interface IReadOnlyConditionList : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyCondition>
{
    IReadOnlyList<IReadOnlyCondition> Conditions { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    new IReadOnlyCondition this[int index] { get; }
}
