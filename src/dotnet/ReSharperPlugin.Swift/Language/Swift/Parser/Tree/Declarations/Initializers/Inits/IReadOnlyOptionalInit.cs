using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;

public interface IReadOnlyOptionalInit : IReadOnlyInit
{
    QuestionMark QuestionMark { get; }
}
