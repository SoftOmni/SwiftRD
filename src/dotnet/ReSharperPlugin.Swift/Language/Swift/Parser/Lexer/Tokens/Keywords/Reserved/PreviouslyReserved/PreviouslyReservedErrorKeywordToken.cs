using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedErrorKeywordToken : PreviouslyReservedKeywordToken<ErrorDirective>
{
    internal PreviouslyReservedErrorKeywordToken()
        : base(ErrorDirective.Keyword, SwiftTokens.PreviouslyReservedErrorId, SwiftTokens.PreviouslyReservedErrorIndex)
    { }

    public override ISwiftVersion RemovalVersion => SwiftVersion.FromVersion(new Version(5, 9));
}
