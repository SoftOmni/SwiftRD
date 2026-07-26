using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Identifiers;

public class IdentifierPattern : SwiftCompositeNode, IIdentifierPattern
{
    public IIdentifier Identifier { get; }

    internal IdentifierPattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier identifier)
        : base(buffer, children)
    {
        Identifier = identifier;
    }

    IReadOnlyIdentifier IReadOnlyIdentifierPattern.Identifier => Identifier;

    public void SetIdentifier(IIdentifier identifier)
    {
        throw new NotImplementedException();
    }
}
