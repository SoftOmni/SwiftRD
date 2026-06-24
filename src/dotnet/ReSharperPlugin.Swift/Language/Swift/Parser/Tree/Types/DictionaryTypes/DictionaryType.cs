using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.DictionaryTypes;

public class DictionaryType : SwiftCompositeNode, IDictionaryType
{
    public LeftSquareBracket LeftSquareBracket { get; }

    public IType KeyType { get; private set; }
    
    public Colon Colon { get; }
    
    public IType ValueType { get; private set; }
    
    public RightSquareBracket RightSquareBracket { get; }

    public DictionaryType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftSquareBracket leftSquareBracket, IType keyType, Colon colon, IType valueType,
        RightSquareBracket rightSquareBracket)
        : base(buffer, children)
    {
        LeftSquareBracket = leftSquareBracket;
        KeyType = keyType;
        Colon = colon;
        ValueType = valueType;
        RightSquareBracket = rightSquareBracket;

        ActualType = GenerateDictionaryUnderlyingType();
    }

    IReadOnlyType IReadOnlyDictionaryType.KeyType => KeyType;
    
    IReadOnlyType IReadOnlyDictionaryType.ValueType => ValueType;

    public IReadOnlyDeclaration? Declaration => ActualType.Declaration;
    
    public IReadOnlyType ActualType { get; }
    
    public string TypeSignature => $"Dictionary<{KeyType.TypeSignature}, {ValueType.TypeSignature}>";

    public IReadOnlyType? SuperType => ActualType.SuperType;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains => ActualType.SubTypeChains;

    public IReadOnlySet<IReadOnlyType> SubTypes => ActualType.SubTypes;

    public IReadOnlySet<string> SubTypeNames => ActualType.SubTypeNames;

    public bool IsFromStandardLibrary => ActualType.IsFromStandardLibrary;

    public int Size => ActualType.Size;

    public void ChangeKeyType(IType keyType)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeValueType(IType valueType)
    {
        throw new System.NotImplementedException();
    }

    private IReadOnlyType GenerateDictionaryUnderlyingType()
    {
        throw new System.NotImplementedException();
    }
}