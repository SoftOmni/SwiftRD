using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Util.dataStructures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Wildcards;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Errors;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.ActorIsolationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeInitializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Indirecterations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Assignment;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Structs;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISuperClassExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathStringExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Colors;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Files;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Images;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.NilLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.GenericWhereClauseClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.PreviouslyReservedElements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Guard;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.DefaultSwitchCases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.LineControlStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.BreakStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ContinueStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.FallthroughStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ReturnStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ThrowStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DeferStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.ForInStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.AnyTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.BoxedProtocolTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OpaqueTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.SelfTypes;
using Class = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Classes.Class;
using Internal = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords.Internal;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

public partial class SwiftLexer
{
    private static readonly Dictionary<string, SwiftTokenNodeType> Keywords = BuildKeywords();

    public static readonly HashSet<char> IdentifierHeads = FillIdentifierHeadCharacters();

    public static readonly HashSet<char> IdentifierCharacters = FillIdentifierCharacters();

    public static readonly Dictionary<string, SwiftTokenNodeType> ReservedKeywords = BuildReservedKeywords();

    private void LexIdentifierOrKeyword()
    {
        TokenStart = TokenEnd;

        while (TokenEnd < EOFPos && Buffer[TokenEnd].IsIdentifierCharacter())
        {
            TokenEnd++;
        }

        string identifier = GetCurrentText();
        if (Keywords.TryGetValue(identifier, out SwiftTokenNodeType? keywordToken))
        {
            TokenType = keywordToken;
            return;
        }

        TokenType = SwiftTokens.IdentifierToken;
    }

    private void LexReservedKeyword()
    {
        while (TokenEnd < EOFPos && Buffer[TokenEnd].IsIdentifierCharacter())
        {
            TokenEnd++;
        }

        string value = GetCurrentText();
        if (ReservedKeywords.TryGetValue(value, out SwiftTokenNodeType? reservedKeyword))
        {
            TokenType = reservedKeyword;
            return;
        }

        TokenType = SwiftTokens.UnmatchedHashtagToken;
        BackingUnmatchedHashtagToken backingUnmatchedHashtagToken = new(value,
                BackingUnmatchedHashtagToken.ErrorCase.UnmatchedHashtagReservedKeyword);
        
        BackPutBackingToken(backingUnmatchedHashtagToken);
    }

    private static HashSet<char> FillIdentifierHeadCharacters()
    {
        HashSet<char> identifierHeads = [];

        identifierHeads.AddUnicodeRange('A', 'Z', inclusive: true);
        identifierHeads.AddUnicodeRange('a', 'z', inclusive: true);
        identifierHeads.Add('_');

        identifierHeads.Add('\u00A8');
        identifierHeads.Add('\u00AA');
        identifierHeads.Add('\u00AD');
        identifierHeads.Add('\u00AF');
        
        identifierHeads.AddUnicodeRange('\u00B2', '\u00B5', inclusive: true);
        identifierHeads.AddUnicodeRange('\u00B7', '\u00BA', inclusive: true);

        identifierHeads.AddUnicodeRange('\u00BC', '\u00BE', inclusive: true);
        identifierHeads.AddUnicodeRange('\u00C0', '\u00D6', inclusive: true);
        identifierHeads.AddUnicodeRange('\u00D8', '\u00F6', inclusive: true);
        identifierHeads.AddUnicodeRange('\u00F8', '\u00FF', inclusive: true);

        identifierHeads.AddUnicodeRange('\u0100', '\u02FF', inclusive: true);
        identifierHeads.AddUnicodeRange('\u0370', '\u167F', inclusive: true);
        identifierHeads.AddUnicodeRange('\u1681', '\u180D', inclusive: true);
        identifierHeads.AddUnicodeRange('\u180F', '\u1DBF', inclusive: true);

        identifierHeads.AddUnicodeRange('\u1E00', '\u1FFF', inclusive: true);

        identifierHeads.AddUnicodeRange('\u200B', '\u200D', inclusive: true);
        identifierHeads.AddUnicodeRange('\u202A', '\u202E', inclusive: true);
        identifierHeads.AddUnicodeRange('\u203F', '\u2040', inclusive: true);
        identifierHeads.Add('\u2054');
        identifierHeads.AddUnicodeRange('\u2060', '\u206F', inclusive: true);

        identifierHeads.AddUnicodeRange('\u2070', '\u20CF', inclusive: true);
        identifierHeads.AddUnicodeRange('\u2100', '\u218F', inclusive: true);
        identifierHeads.AddUnicodeRange('\u2460', '\u24FF', inclusive: true);
        identifierHeads.AddUnicodeRange('\u2776', '\u2793', inclusive: true);

        identifierHeads.AddUnicodeRange('\u2C00', '\u2DFF', inclusive: true);
        identifierHeads.AddUnicodeRange('\u2E80', '\u2FFF', inclusive: true);

        identifierHeads.AddUnicodeRange('\u3004', '\u3007', inclusive: true);
        identifierHeads.AddUnicodeRange('\u3021', '\u302F', inclusive: true);
        identifierHeads.AddUnicodeRange('\u3031', '\u303F', inclusive: true);
        identifierHeads.AddUnicodeRange('\u3040', '\uD7FF', inclusive: true);

        identifierHeads.AddUnicodeRange('\uF900', '\uFD3D', inclusive: true);
        identifierHeads.AddUnicodeRange('\uFD40', '\uFDCF', inclusive: true);
        identifierHeads.AddUnicodeRange('\uFDF0', '\uFE1F', inclusive: true);
        identifierHeads.AddUnicodeRange('\uFE30', '\uFE44', inclusive: true);

        identifierHeads.AddUnicodeRange('\uFE47', '\uFFFD', inclusive: true);
        // Note: Upper Unicode planes (U+10000 and above) require surrogate pair handling
        // which is not straightforward with char type. These would need special handling.

        return identifierHeads;
    }

    private static HashSet<char> FillIdentifierCharacters()
    {
        HashSet<char> identifierCharacters = new(IdentifierHeads);
        
        identifierCharacters.Add('0');
        identifierCharacters.Add('1');
        identifierCharacters.Add('2');
        identifierCharacters.Add('3');
        identifierCharacters.Add('4');
        identifierCharacters.Add('5');
        identifierCharacters.Add('6');
        identifierCharacters.Add('7');
        identifierCharacters.Add('8');
        identifierCharacters.Add('9');
        
        identifierCharacters.AddUnicodeRange('\u0300', '\u036F', inclusive: true);
        identifierCharacters.AddUnicodeRange('\u1DC0', '\u1DFF', inclusive: true);
        identifierCharacters.AddUnicodeRange('\u20D0', '\u20FF', inclusive: true);
        identifierCharacters.AddUnicodeRange('\uFE20', '\uFE2F', inclusive: true);

        return identifierCharacters;
    }

    private static Dictionary<string, SwiftTokenNodeType> BuildKeywords()
    {
        Dictionary<string, SwiftTokenNodeType> dictionary = new()
        {
            { Assignment.Keyword, SwiftTokens.AssignmentKeywordToken },
            { AssociatedType.Keyword, SwiftTokens.AssociatedTypeKeywordToken },
            { Borrowing.Keyword, SwiftTokens.BorrowingKeywordToken },
            { Class.Keyword, SwiftTokens.ClassKeywordToken },
            { Consuming.Keyword, SwiftTokens.ConsumingKeywordToken },
            { DeInit.Keyword, SwiftTokens.DeinitKeywordToken },
            { Enum.Keyword, SwiftTokens.EnumKeywordToken },
            { Extension.Keyword, SwiftTokens.ExtensionKeywordToken },
            { FilePrivate.Keyword, SwiftTokens.FilePrivateKeywordToken },
            { Func.Keyword, SwiftTokens.FuncKeywordToken },
            { Import.Keyword, SwiftTokens.ImportKeywordToken },
            { Init.Keyword, SwiftTokens.InitKeywordToken },
            { InOut.Keyword, SwiftTokens.InoutKeywordToken },
            { Internal.Keyword, SwiftTokens.InternalKeywordToken },
            { Let.Keyword, SwiftTokens.LetKeywordToken },
            { NonIsolated.Keyword, SwiftTokens.NonIsolatedKeywordToken },
            { Open.Keyword, SwiftTokens.OpenKeywordToken },
            { OperatorKeyword.Keyword, SwiftTokens.OperatorKeywordToken },
            { PrecedenceGroupKeyword.Keyword, SwiftTokens.PrecedenceGroupKeywordToken },
            { Private.Keyword, SwiftTokens.PrivateKeywordToken },
            { Protocol.Keyword, SwiftTokens.ProtocolLowercaseKeywordToken },
            { Public.Keyword, SwiftTokens.PublicKeywordToken },
            { Rethrows.Keyword, SwiftTokens.RethrowsKeywordToken },
            { Static.Keyword, SwiftTokens.StaticKeywordToken },
            { Struct.Keyword, SwiftTokens.StructKeywordToken },
            { Subscript.Keyword, SwiftTokens.SubscriptKeywordToken },
            { TypeAliasKeyword.Keyword, SwiftTokens.TypealiasKeywordToken },
            { Var.Keyword, SwiftTokens.VarKeywordToken },
            { Break.Keyword, SwiftTokens.BreakKeywordToken },
            { Case.Keyword, SwiftTokens.CaseKeywordToken },
            { Catch.Keyword, SwiftTokens.CatchKeywordToken },
            { Continue.Keyword, SwiftTokens.ContinueKeywordToken },
            { Default.Keyword, SwiftTokens.DefaultKeywordToken },
            { Defer.Keyword, SwiftTokens.DeferKeywordToken },
            { Do.Keyword, SwiftTokens.DoKeywordToken },
            { Else.Keyword, SwiftTokens.ElseKeywordToken },
            { Fallthrough.Keyword, SwiftTokens.FallthroughKeywordToken },
            { For.Keyword, SwiftTokens.ForKeywordToken },
            { Guard.Keyword, SwiftTokens.GuardKeywordToken },
            { If.Keyword, SwiftTokens.IfKeywordToken },
            { In.Keyword, SwiftTokens.InKeywordToken },
            { Repeat.Keyword, SwiftTokens.RepeatKeywordToken },
            { Return.Keyword, SwiftTokens.ReturnKeywordToken },
            { Switch.Keyword, SwiftTokens.SwitchKeywordToken },
            { Throw.Keyword, SwiftTokens.ThrowKeywordToken },
            { Where.Keyword, SwiftTokens.WhereKeywordToken },
            { While.Keyword, SwiftTokens.WhileKeywordToken },
            { AnyLowercase.Keyword, SwiftTokens.AnyLowercaseKeywordToken },
            { AnyUppercase.Keyword, SwiftTokens.AnyUppercaseKeywordToken },
            { As.Keyword, SwiftTokens.AsKeywordToken },
            { Await.Keyword, SwiftTokens.AwaitKeywordToken },
            { FalseBooleanLiteral.Keyword, SwiftTokens.FalseLiteralToken },
            { Is.Keyword, SwiftTokens.IsKeywordToken },
            { NilLiteral.Keyword, SwiftTokens.NilLiteralToken },
            { SelfLowercase.Keyword, SwiftTokens.SelfLowercaseKeywordToken },
            { Self.Keyword, SwiftTokens.SelfUppercaseKeywordToken },
            { Super.Keyword, SwiftTokens.SuperKeywordToken },
            { Throws.Keyword, SwiftTokens.ThrowsKeywordToken },
            { TrueBooleanLiteral.Keyword, SwiftTokens.TrueLiteralToken },
            { Try.Keyword, SwiftTokens.TryKeywordToken },
            { SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Wildcards.Underscore.Value, SwiftTokens.UnderscoreKeywordToken },
            { ReservedAvailableKeyword.Keyword, SwiftTokens.ReservedAvailableKeywordToken },
            { ReservedColorLiteralKeyword.Keyword, SwiftTokens.ReservedColorLiteralKeywordToken },
            { ElseDirective.Keyword, SwiftTokens.ElseDirectiveKeywordToken },
            { ElseIfDirective.Keyword, SwiftTokens.ElseIfDirectiveKeywordToken },
            { EndIfDirective.Keyword, SwiftTokens.EndIfDirectiveKeywordToken },
            { ReservedFileLiteralKeyword.Keyword, SwiftTokens.ReservedFileLiteralKeywordToken },
            { IfDirective.Keyword, SwiftTokens.IfDirectiveKeywordToken },
            { ReservedImageLiteralKeyword.Keyword, SwiftTokens.ReservedImageLiteralKeywordToken },
            { KeyPathKeyword.Keyword, SwiftTokens.ReservedKeyPathKeywordToken },
            { SelectorKeyword.Keyword, SwiftTokens.ReservedSelectorKeywordToken },
            { ReservedSourceLocationKeyword.Keyword, SwiftTokens.ReservedSourceLocationKeywordToken },
            { ReservedUnavailableKeyword.Keyword, SwiftTokens.ReservedUnavailableKeywordToken },
            { LegacyColumn.Keyword, SwiftTokens.PreviouslyReservedColumnKeywordToken },
            { LegacyDsoHandle.Keyword, SwiftTokens.PreviouslyReservedDsoHandleKeywordToken },
            { ErrorDirective.Keyword, SwiftTokens.PreviouslyReservedErrorKeywordToken },
            { LegacyFileId.Keyword, SwiftTokens.PreviouslyReservedFileIdKeywordToken },
            { LegacyFilePath.Keyword, SwiftTokens.PreviouslyReservedFilePathKeywordToken },
            { LegacyFile.Keyword, SwiftTokens.PreviouslyReservedFileKeywordToken },
            { LegacyFunction.Keyword, SwiftTokens.PreviouslyReservedFunctionKeywordToken },
            { LegacyLine.Keyword, SwiftTokens.PreviouslyReservedLineKeywordToken },
            { WarningDirective.Keyword, SwiftTokens.PreviouslyReservedWarningKeywordToken },
            { Associativity.Keyword, SwiftTokens.AssociativityKeywordToken },
            { Async.Keyword, SwiftTokens.AsyncKeywordToken },
            { Convenience.Keyword, SwiftTokens.ConvenienceKeywordToken },
            { DidSet.Keyword, SwiftTokens.DidSetKeywordToken },
            { Dynamic.Keyword, SwiftTokens.DynamicKeywordToken },
            { Final.Keyword, SwiftTokens.FinalKeywordToken },
            { Get.Keyword, SwiftTokens.GetKeywordToken },
            { Indirect.Keyword, SwiftTokens.IndirectKeywordToken },
            { Infix.Keyword, SwiftTokens.InfixKeywordToken },
            { Lazy.Keyword, SwiftTokens.LazyKeywordToken },
            { Left.Keyword, SwiftTokens.LeftKeywordToken },
            { Mutating.Keyword, SwiftTokens.MutatingKeywordToken },
            { None.Keyword, SwiftTokens.NoneKeywordToken },
            { NonMutating.Keyword, SwiftTokens.NonMutatingKeywordToken },
            { Optional.Keyword, SwiftTokens.OptionalKeywordToken },
            { Override.Keyword, SwiftTokens.OverrideKeywordToken },
            { Package.Keyword, SwiftTokens.PackageKeywordToken },
            { Postfix.Keyword, SwiftTokens.PostfixKeywordToken },
            { Precedence.Keyword, SwiftTokens.PrecedenceKeywordToken },
            { Prefix.Keyword, SwiftTokens.PrefixKeywordToken },
            { ProtocolUppercase.Keyword, SwiftTokens.ProtocolUppercaseKeywordToken },
            { Required.Keyword, SwiftTokens.RequiredKeywordToken },
            { Right.Keyword, SwiftTokens.RightKeywordToken },
            { Set.Keyword, SwiftTokens.SetKeywordToken },
            { Some.Keyword, SwiftTokens.SomeKeywordToken },
            { Type.Keyword, SwiftTokens.TypeKeywordToken },
            { Unowned.Keyword, SwiftTokens.UnownedKeywordToken },
            { Weak.Keyword, SwiftTokens.WeakKeywordToken },
            { WillSet.Keyword, SwiftTokens.WillSetKeywordToken }
        };

        return dictionary;
    }

    private static Dictionary<string, SwiftTokenNodeType> BuildReservedKeywords()
    {
        Dictionary<string, SwiftTokenNodeType> dictionary = new();

        foreach (KeyValuePair<string, SwiftTokenNodeType> keyValuePair in Keywords)
        {
            if (keyValuePair.Key.StartsWith(Hashtag.ToString()))
            {
                dictionary.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }

        return dictionary;
    }
}

internal partial class SwiftLexerExtensions
{
    public static bool IsIdentifierHead(this char c)
    {
        return SwiftLexer.IdentifierHeads.Contains(c);
    }

    public static bool IsIdentifierCharacter(this char c)
    {
        return SwiftLexer.IdentifierCharacters.Contains(c);
    }

    public static void Add<AstLeafNode>(this SimpleTrie<char, SwiftKeywordToken<AstLeafNode>> trie, string keyword,
        SwiftKeywordToken<AstLeafNode> keywordToken) where AstLeafNode : LeafElementBase, ISwiftKeywordNode<AstLeafNode>, new()
    {
        trie.SetValue(keyword.ToCharArray(), keywordToken);
    }
}
