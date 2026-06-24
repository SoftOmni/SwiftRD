namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ParenthesizedTypes;

public interface IParenthesizedType : IReadOnlyParenthesizedType, IType
{
    new IType Type { get; }

    void ChangeType(IType type);
}
