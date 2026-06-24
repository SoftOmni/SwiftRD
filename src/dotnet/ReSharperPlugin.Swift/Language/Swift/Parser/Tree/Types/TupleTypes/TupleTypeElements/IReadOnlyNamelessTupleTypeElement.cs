namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public interface IReadOnlyNamelessTupleTypeElement : IReadOnlyTupleTypeElement
{
    IReadOnlyType Type { get; }
}