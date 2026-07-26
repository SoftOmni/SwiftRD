using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Products;
using SoftOmni.SwiftRd.Language.Swift.Semantics.Context;
using IFile = JetBrains.ReSharper.Psi.Tree.IFile;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;

public interface IReadOnlyTopLevelDeclaration : IReadOnlyDeclaration, IFile, IReadOnlyList<IReadOnlyStatement>
{
    bool HasExecutableCode { get; }

    bool IsAllowedExecutableCode { get; }

    IReadOnlyList<IExecutableProduct> ExecutableProductsWhichAllowExecutableCode { get; }
    // TODO: Make read only executable product. Once the rest is done and XCode support is being brought in, make a generic executable target and think this one through

    IReadOnlyStatementGroup Statements { get; }
    
    IReadOnlyList<IReadOnlyStatement> StatementsAsList { get; }
    
    IReadOnlyLocalSwiftSemanticalContext LocalFileSemanticalContext { get; }
}
