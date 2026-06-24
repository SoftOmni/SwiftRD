namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.SelfTypes;

public interface IReadOnlySelfType : IReadOnlyType
{
    Self Self { get; }
}
