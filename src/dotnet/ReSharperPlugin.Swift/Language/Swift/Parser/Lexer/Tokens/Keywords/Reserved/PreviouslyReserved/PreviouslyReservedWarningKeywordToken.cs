using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedWarningKeywordToken : PreviouslyReservedKeywordToken<WarningDirective>
{
    internal PreviouslyReservedWarningKeywordToken()
        : base(WarningDirective.Keyword, SwiftTokens.PreviouslyReservedWarningId, SwiftTokens.PreviouslyReservedWarningIndex)
    { }

    public override ISwiftVersion RemovalVersion => SwiftVersion.FromVersion(new Version(5, 9));
}