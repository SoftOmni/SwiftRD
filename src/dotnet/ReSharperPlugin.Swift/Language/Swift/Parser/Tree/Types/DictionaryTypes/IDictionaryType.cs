namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.DictionaryTypes;

public interface IDictionaryType : IReadOnlyDictionaryType, IType
{
    new IType KeyType { get; }
    
    new IType ValueType { get; }

    void ChangeKeyType(IType keyType);

    void ChangeValueType(IType valueType);
}
