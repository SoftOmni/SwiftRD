namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public interface INamelessTupleTypeElement : IReadOnlyNamelessTupleTypeElement, ITupleTypeElement
{
    new IType Type { get; }
    
    void ChangeType(IType type);
}
