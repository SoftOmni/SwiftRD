using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

public interface IReadOnlyForcefulOptionalInit : IReadOnlyInit
{
    ExclamationMark ExclamationMark { get; }
}
