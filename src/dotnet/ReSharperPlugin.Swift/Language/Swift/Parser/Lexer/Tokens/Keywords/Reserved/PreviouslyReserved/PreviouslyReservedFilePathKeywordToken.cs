using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.PreviouslyReservedElements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFilePathKeywordToken : PreviouslyReservedKeywordToken<LegacyFilePath>
{
    internal PreviouslyReservedFilePathKeywordToken()
        : base(LegacyFilePath.Keyword, SwiftTokens.PreviouslyReservedFilePathId, SwiftTokens.PreviouslyReservedFilePathIndex)
    { }

    public override ISwiftVersion RemovalVersion => SwiftVersion.FromVersion(new Version(5, 9));
}
