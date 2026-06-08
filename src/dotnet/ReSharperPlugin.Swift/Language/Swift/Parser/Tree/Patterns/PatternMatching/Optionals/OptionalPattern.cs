using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.Optionals;

public class OptionalPattern : SwiftCompositeNode, IOptionalPattern
{
    public QuestionMark? QuestionMark { get; }

    public IIdentifierPattern IdentifierPattern { get; }

    internal OptionalPattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifierPattern identifierPattern, QuestionMark questionMark)
        : base(buffer, children)
    {
        IdentifierPattern = identifierPattern;
        QuestionMark = questionMark;
    }

    IReadOnlyIdentifierPattern IReadOnlyOptionalPattern.IdentifierPattern => IdentifierPattern;

    public void SetIdentifierPattern(IIdentifierPattern identifierPattern)
    {
        throw new System.NotImplementedException();
    }
}