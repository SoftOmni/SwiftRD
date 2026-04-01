using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using SoftOmni.SwiftRd.Language.ProjectModel;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.Modules;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser : IParser
{
    public SwiftFilteringLexer FilteringLexer { get; internal set; }
    
    public SwiftLexer CoreLexer { get; }

    public SwiftParser(SwiftFilteringLexer filteringLexer, SwiftPsiModule? swiftPsiModule = null,
        SwiftPsiSourceFile? sourceFile = null)
    {
        FilteringLexer = filteringLexer;
        CoreLexer = filteringLexer.CoreLexer;
    }
    
    public IFile ParseFile()
    {
        TopLevelDeclaration topLevelDeclaration = TopLevelDeclaration.Parse(CoreLexer);
        return topLevelDeclaration;
    }
}