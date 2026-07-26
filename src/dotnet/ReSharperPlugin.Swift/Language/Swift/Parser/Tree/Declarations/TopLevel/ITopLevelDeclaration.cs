using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Products;
using SoftOmni.SwiftRd.Language.Swift.Semantics.Context;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;

public interface ITopLevelDeclaration : IReadOnlyTopLevelDeclaration, IList<IStatement>
{
    new IReadOnlyList<IExecutableProduct> ExecutableProductsWhichAllowExecutableCode { get; }
    
    new ILocalSwiftSemanticalContext LocalFileSemanticalContext { get; }

    new IStatementGroup Statements { get; }
    
    new IReadOnlyList<IStatement> StatementsAsList { get; }
    
    new int Count { get; }

    new IEnumerator<IStatement> GetEnumerator();
    
    new IStatement this[int index] { get; set; }

    void ChangeStatements(IStatementGroup newStatements);
}
