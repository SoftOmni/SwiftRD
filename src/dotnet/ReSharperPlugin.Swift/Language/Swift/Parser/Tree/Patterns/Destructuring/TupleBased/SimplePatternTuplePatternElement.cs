using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;

public class SimplePatternTuplePatternElement : SwiftCompositeNode, ITuplePatternElement
{
    private IPattern _pattern;

    internal SimplePatternTuplePatternElement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPattern pattern)
        : base(buffer, children)
    {
        _pattern = pattern;
    }

    public IPattern Pattern => _pattern;

    IIdentifier? ITuplePatternElement.Identifier => null;

    public IReadOnlyIdentifier? Identifier => null;

    public Colon? Colon => null;

    public void SetPattern(IPattern pattern)
    {
        throw new System.NotImplementedException();
    }

    public void SetIdentifier(IIdentifier identifier)
    {
        throw new System.NotImplementedException();
    }
}