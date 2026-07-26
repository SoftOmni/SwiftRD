using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.
    GenericSwitchCases;

public interface IReadOnlyCaseLabel : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)>
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }

    Case Case { get; }
    
    IReadOnlyList<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)> CaseItems { get; }

    IReadOnlyCaseItemList CaseItemList { get; }
    
    new (IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause) this[int index] { get; }
    
    Colon StatementsStartColon { get; }
}
