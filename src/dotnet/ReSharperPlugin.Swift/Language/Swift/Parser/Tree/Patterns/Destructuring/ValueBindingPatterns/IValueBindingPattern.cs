namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.ValueBinding;

public interface IValueBindingPattern : IReadOnlyValueBindingPattern
{
    void MakeLet();

    void MakeVar();

    void SetPattern(IPattern pattern);
}