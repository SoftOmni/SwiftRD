using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;

public class IncompleteIdentifierPatternTuplePatternElement : SwiftErrorCompositeNode, ITuplePatternElement
{
    
    private IPattern? _pattern;

    private IIdentifier? _identifier;

    private Colon? _colon;

    internal IncompleteIdentifierPatternTuplePatternElement(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IIdentifier? identifier = null, 
        Colon? colon = null, IPattern? pattern = null
    ) : base(buffer, children, GenerateMessage(identifier, colon, pattern))
    {
        _pattern = pattern;
        _colon = colon;
        _identifier = identifier;
    }

    public IPattern? Pattern => _pattern;

    public IIdentifier? Identifier => _identifier;

    public Colon? Colon => _colon;

    IReadOnlyIdentifier? IReadOnlyTuplePatternElement.Identifier => _identifier;

    public void SetIdentifier(IIdentifier identifier)
    {
        throw new NotImplementedException();
    }

    public void SetPattern(IPattern pattern)
    {
        throw new NotImplementedException();
    }

    public void SetColon(Colon colon)
    {
        throw new NotImplementedException();
    }

    public bool CanMakeIntoValidTuplePatternElement()
    {
        return _identifier is not null && _colon is not null && _pattern is not null;
    }

    public void MakeIntoValidTuplePatternElement()
    {
        throw new NotImplementedException();
    }

    private static string GenerateMessage(IIdentifier? identifier, Colon? colon, IPattern? pattern)
    {
        if (identifier is null)
        {
            if (pattern is null)
            {
                return "Missing an identifier on the left of the colon and a child pattern on the right of the colon " +
                       "for this tuple-based deconstruction pattern element";
            }

            return "Missing an identifier on the left of the colon for this tuple-based deconstruction pattern element";
        }

        if (colon is null)
        {
            if (pattern is not null)
            {
                return
                    "Missing a colon between this identifier and this child-pattern for this tuple-based deconstruction pattern element";
            }

            return
                "Missing a colon and a following child pattern to the right of the colon for this tuple-based deconstruction pattern element";
        }

        if (pattern is not null)
        {
            return "False positive: this is a valid tuple-based deconstruction pattern syntactically";
        }

        return "Missing child pattern after colon for this tuple-based deconstruction pattern element";
    }
}