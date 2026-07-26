using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;

public class IdentifierPatternTuplePatternElement : SwiftCompositeNode, ITuplePatternElement
{
    private IPattern _pattern;

    private IIdentifier _identifier;

    internal IdentifierPatternTuplePatternElement(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IIdentifier identifier, Colon colon, IPattern pattern
    ) : base(buffer, children)
    {
        _pattern = pattern;
        Colon = colon;
        _identifier = identifier;
    }

    public IPattern Pattern => _pattern;

    public IIdentifier Identifier => _identifier;

    public Colon Colon { get; }

    IReadOnlyIdentifier IReadOnlyTuplePatternElement.Identifier => _identifier;
    
    public void SetIdentifier(IIdentifier identifier)
    {
        throw new NotImplementedException();
    }

    public void SetPattern(IPattern pattern)
    {
        throw new NotImplementedException();
    }
}