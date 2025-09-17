using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using ReSharperPlugin.Swift.Language.Parser.Lexer;
using ReSharperPlugin.Swift.Language.ProjectModel;

namespace ReSharperPlugin.Swift.Language.Parser;

public class SwiftParser : IParser
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
        throw new System.NotImplementedException();
    }
}