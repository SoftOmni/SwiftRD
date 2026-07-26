using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public class PatternInitializer : SwiftCompositeNode, IPatternInitializer
{
    public IPattern Pattern { get; }

    public IInitializer? Initializer { get; }

    internal PatternInitializer(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPattern pattern, IInitializer? initializer = null)
        : base(buffer, children)
    {
        Pattern = pattern;
        Initializer = initializer;
    }

    IReadOnlyPattern IReadOnlyPatternInitializer.Pattern => Pattern;

    IReadOnlyInitializer? IReadOnlyPatternInitializer.Initializer => Initializer;

    public void ChangePattern(IPattern newPattern)
    {
        throw new NotImplementedException();
    }

    public void SetInitializerTo(IInitializer? initializer)
    {
        throw new NotImplementedException();
    }

    public void RemoveInitializer()
    {
        throw new NotImplementedException();
    }
}
