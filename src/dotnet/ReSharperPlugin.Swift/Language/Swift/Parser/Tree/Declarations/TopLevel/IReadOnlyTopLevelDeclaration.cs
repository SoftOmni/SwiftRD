using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Products;
using IFile = JetBrains.ReSharper.Psi.Tree.IFile;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;

public interface IReadOnlyTopLevelDeclaration : IReadOnlyDeclaration, IFile
{
    bool HasExecutableCode { get; }

    bool IsAllowedExecutableCode { get; }

    IReadOnlyList<IExecutableProduct> ExecutableProductsWhichAllowExecutableCode { get; }
    // TODO: Make read only executable product. Once the rest is done and XCode support is being brought in, make a generic executable target and think this one through

    IReadOnlyStatementGroup StatementGroup { get; }

    IReadOnlySet<IReadOnlyDeclaration<IReadOnlyType>> TypeDeclarations { get; }

    IReadOnlyDictionary<IReadOnlyIdentifier, IReadOnlyDeclaration<IReadOnlyType>> TypeDeclarationsLookup { get; }

    IReadOnlySet<IReadOnlyDeclaration<IReadOnlyCallExpression>> FunctionDeclarations { get; }

    IReadOnlyDictionary<IReadOnlyIdentifier, IReadOnlyDeclaration<IReadOnlyCallExpression>> FunctionDeclarationsLookup
    {
        get;
    }

    IReadOnlySet<IReadOnlyDeclaration<IReadOnlyVariableCall>> GlobalVariableDeclarations { get; }
    
    IReadOnlyDictionary<IReadOnlyIdentifier, IReadOnlyVariableCall> GlobalVariableDeclarationsLookup { get; }
}
