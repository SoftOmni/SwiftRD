
using System.Collections.Frozen;
using System.Collections.Generic;
using DefaultNamespace;
using JetBrains.Util.dataStructures;
using NuGet;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer;

public partial class SwiftLexer
{
    private static readonly FrozenDictionary<string, SwiftTokenNodeType> Keywords = BuildKeywords();

    public static readonly FrozenSet<char> IdentifierHeads = FillIdentifierHeadCharacters();

    public static readonly FrozenSet<char> IdentifierCharacters = FillIdentifierCharacters();

    public static readonly FrozenDictionary<string, SwiftTokenNodeType> ReservedKeywords = BuildReservedKeywords();

    private void LexIdentifierOrKeyword()
    {
        TokenStart = TokenEnd;
        
        while (TokenEnd < EOFPos && Buffer[TokenEnd].IsIdentifierCharacter())
        {
            TokenEnd++;
        }

        string identifier = GetCurrentText();
        if (Keywords.TryGetValue(identifier, out SwiftTokenNodeType keywordToken))
        {
            TokenType = keywordToken;
            return;
        }

        TokenType = new IdentifierToken(identifier);
    }

    private void LexReservedKeyword()
    {
        while (TokenEnd < EOFPos && Buffer[TokenEnd].IsIdentifierCharacter())
        {
            TokenEnd++;
        }

        string value = GetCurrentText();
        if (ReservedKeywords.ContainsKey(value))
        {
            TokenType = ReservedKeywords[value];
            return;
        }

        TokenType = new UnmatchedHashtagToken(value, UnmatchedHashtagToken.ErrorCase.UnmatchedHashtagReservedKeyword);
    }

    private static FrozenSet<char> FillIdentifierHeadCharacters()
    {
        HashSet<char> identifierHeads = new();

        identifierHeads.AddUnicodeRange('A', 'Z', inclusive: true);
        identifierHeads.AddUnicodeRange('a', 'z', inclusive: true);
        identifierHeads.Add('_');

        identifierHeads.AddRange(['\u00A8', '\u00AA', '\u00AD', '\u00AF']);
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

        return identifierHeads.ToFrozenSet();
    }

    private static FrozenSet<char> FillIdentifierCharacters()
    {
        HashSet<char> identifierCharacters = new(IdentifierHeads);
        
        identifierCharacters.AddRange(['0', '1', '2', '3', '4', '5', '6', '7', '8', '9']);
        identifierCharacters.AddUnicodeRange('\u0300', '\u036F', inclusive:true);
        identifierCharacters.AddUnicodeRange('\u1DC0', '\u1DFF', inclusive:true);
        identifierCharacters.AddUnicodeRange('\u20D0', '\u20FF', inclusive:true);
        identifierCharacters.AddUnicodeRange('\uFE20', '\uFE2F', inclusive:true);
        
        return identifierCharacters.ToFrozenSet();
    }

    private static FrozenDictionary<string, SwiftTokenNodeType> BuildKeywords()
    { 
        Dictionary<string, SwiftTokenNodeType> dictionary = new()
        {
            { "associatedtype", SwiftTokens.AssociatedTypeKeywordToken },
            { "borrowing", SwiftTokens.BorrowingKeywordToken },
            { "class", SwiftTokens.ClassKeywordToken },
            { "consuming", SwiftTokens.ConsumingKeywordToken },
            { "deinit", SwiftTokens.DeinitKeywordToken },
            { "enum", SwiftTokens.EnumKeywordToken },
            { "extension", SwiftTokens.ExtensionKeywordToken },
            { "fileprivate", SwiftTokens.FilePrivateKeywordToken },
            { "func", SwiftTokens.FuncKeywordToken },
            { "import", SwiftTokens.ImportKeywordToken },
            { "init", SwiftTokens.InitKeywordToken },
            { "inout", SwiftTokens.InoutKeywordToken },
            { "internal", SwiftTokens.InternalKeywordToken },
            { "let", SwiftTokens.LetKeywordToken },
            { "nonisolated", SwiftTokens.NonIsolatedKeywordToken },
            { "open", SwiftTokens.OpenKeywordToken },
            { "operator", SwiftTokens.OperatorKeywordToken },
            { "precedencegroup", SwiftTokens.PrecedenceGroupKeywordToken },
            { "private", SwiftTokens.PrivateKeywordToken },
            { "protocol", SwiftTokens.ProtocolLowercaseKeywordToken },
            { "public", SwiftTokens.PublicKeywordToken },
            { "rethrows", SwiftTokens.RethrowsKeywordToken },
            { "static", SwiftTokens.StaticKeywordToken },
            { "struct", SwiftTokens.StructKeywordToken },
            { "subscript", SwiftTokens.SubscriptKeywordToken },
            { "typealias", SwiftTokens.TypealiasKeywordToken },
            { "var", SwiftTokens.VarKeywordToken },
            { "break", SwiftTokens.BreakKeywordToken },
            { "case", SwiftTokens.CaseKeywordToken },
            { "catch", SwiftTokens.CatchKeywordToken },
            { "continue", SwiftTokens.ContinueKeywordToken },
            { "default", SwiftTokens.DefaultKeywordToken },
            { "defer", SwiftTokens.DeferKeywordToken },
            { "do", SwiftTokens.DoKeywordToken },
            { "else", SwiftTokens.ElseKeywordToken },
            { "fallthrough", SwiftTokens.FallthroughKeywordToken },
            { "for", SwiftTokens.ForKeywordToken },
            { "guard", SwiftTokens.GuardKeywordToken },
            { "if", SwiftTokens.IfKeywordToken },
            { "in", SwiftTokens.InKeywordToken },
            { "repeat", SwiftTokens.RepeatKeywordToken },
            { "return", SwiftTokens.ReturnKeywordToken },
            { "switch", SwiftTokens.SwitchKeywordToken },
            { "throw", SwiftTokens.ThrowKeywordToken },
            { "where", SwiftTokens.WhereKeywordToken },
            { "while", SwiftTokens.WhileKeywordToken },
            { "Any", SwiftTokens.AnyKeywordToken },
            { "as", SwiftTokens.AsKeywordToken },
            { "await", SwiftTokens.AwaitKeywordToken },
            { "false", SwiftTokens.FalseLiteralToken },
            { "is", SwiftTokens.IsKeywordToken },
            { "nil", SwiftTokens.NilLiteralToken },
            { "self", SwiftTokens.SelfLowercaseKeywordToken },
            { "Self", SwiftTokens.SelfUppercaseKeywordToken },
            { "super", SwiftTokens.SuperKeywordToken },
            { "throws", SwiftTokens.ThrowsKeywordToken },
            { "true", SwiftTokens.TrueLiteralToken },
            { "try", SwiftTokens.TryKeywordToken },
            { "_", SwiftTokens.UnderscoreKeywordToken },
            { "#available", SwiftTokens.ReservedAvailableKeywordToken },
            { "#colorLiteral", SwiftTokens.ReservedColorLiteralKeywordToken },
            { "#else", SwiftTokens.ReservedElseKeywordToken },
            { "#elseif", SwiftTokens.ReservedElseIfKeywordToken },
            { "#endif", SwiftTokens.ReservedEndIfKeywordToken },
            { "#fileLiteral", SwiftTokens.ReservedFileLiteralKeywordToken },
            { "#if", SwiftTokens.ReservedIfKeywordToken },
            { "#imageLiteral", SwiftTokens.ReservedImageLiteralKeywordToken },
            { "#keyPath", SwiftTokens.ReservedKeyPathKeywordToken },
            { "#selector", SwiftTokens.ReservedSelectorKeywordToken },
            { "#sourceLocation", SwiftTokens.ReservedSourceLocationKeywordToken },
            { "#unavailable", SwiftTokens.ReservedUnavailableKeywordToken },
            { "#column", SwiftTokens.PreviouslyReservedColumnKeywordToken },
            { "#dsohandle", SwiftTokens.PreviouslyReservedDsoHandleKeywordToken },
            { "#error", SwiftTokens.PreviouslyReservedErrorKeywordToken },
            { "#fileID", SwiftTokens.PreviouslyReservedFileIdKeywordToken },
            { "#filePath", SwiftTokens.PreviouslyReservedFilePathKeywordToken },
            { "#file", SwiftTokens.PreviouslyReservedFileKeywordToken },
            { "#function", SwiftTokens.PreviouslyReservedFunctionKeywordToken },
            { "#line", SwiftTokens.PreviouslyReservedLineKeywordToken },
            { "#warning", SwiftTokens.PreviouslyReservedWarningKeywordToken },
            { "associativity", SwiftTokens.AssociativityKeywordToken },
            { "async", SwiftTokens.AsyncKeywordToken },
            { "convenience", SwiftTokens.ConvenienceKeywordToken },
            { "didSet", SwiftTokens.DidSetKeywordToken },
            { "dynamic", SwiftTokens.DynamicKeywordToken },
            { "final", SwiftTokens.FinalKeywordToken },
            { "get", SwiftTokens.GetKeywordToken },
            { "indirect", SwiftTokens.IndirectKeywordToken },
            { "infix", SwiftTokens.InfixKeywordToken },
            { "lazy", SwiftTokens.LazyKeywordToken },
            { "left", SwiftTokens.LeftKeywordToken },
            { "mutating", SwiftTokens.MutatingKeywordToken },
            { "none", SwiftTokens.NoneKeywordToken },
            { "nonmutating", SwiftTokens.NonMutatingKeywordToken },
            { "optional", SwiftTokens.OptionalKeywordToken },
            { "override", SwiftTokens.OverrideKeywordToken },
            { "package", SwiftTokens.PackageKeywordToken },
            { "postfix", SwiftTokens.PostfixKeywordToken },
            { "precedence", SwiftTokens.PrecedenceKeywordToken },
            { "prefix", SwiftTokens.PrefixKeywordToken },
            { "Protocol", SwiftTokens.ProtocolUppercaseKeywordToken },
            { "required", SwiftTokens.RequiredKeywordToken },
            { "right", SwiftTokens.RightKeywordToken },
            { "set", SwiftTokens.SetKeywordToken },
            { "some", SwiftTokens.SomeKeywordToken },
            { "Type", SwiftTokens.TypeKeywordToken },
            { "unowned", SwiftTokens.UnownedKeywordToken },
            { "weak", SwiftTokens.WeakKeywordToken },
            { "willSet", SwiftTokens.WillSetKeywordToken }
        };

        return dictionary.ToFrozenDictionary();
    }

    private static FrozenDictionary<string, SwiftTokenNodeType> BuildReservedKeywords()
    {
        Dictionary<string, SwiftTokenNodeType> dictionary = new();

        foreach (KeyValuePair<string, SwiftTokenNodeType> keyValuePair in Keywords)
        {
            if (keyValuePair.Key.StartsWith(Hashtag.ToString()))
            {
                dictionary.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }
        
        return dictionary.ToFrozenDictionary();
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
    
    public static void Add(this SimpleTrie<char, SwiftKeywordToken> trie, string keyword, SwiftKeywordToken keywordToken)
    {
        trie.SetValue(keyword.ToCharArray(), keywordToken);
    }
}