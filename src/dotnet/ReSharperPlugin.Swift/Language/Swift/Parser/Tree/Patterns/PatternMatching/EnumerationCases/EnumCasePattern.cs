using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.EnumerationCases;

public class EnumCasePattern : SwiftCompositeNode, IEnumCasePattern
{
    public IIdentifier? TypeIdentifier { get; }

    public Period Period { get; }

    public IIdentifier EnumCaseName { get; }

    public ITuplePattern? TuplePattern { get; }

    internal EnumCasePattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier? typeIdentifier, Period period, IIdentifier enumCaseName, ITuplePattern? tuplePattern)
        : base(buffer, children)
    {
        TypeIdentifier = typeIdentifier;
        Period = period;
        EnumCaseName = enumCaseName;
        TuplePattern = tuplePattern;
    }

    IReadOnlyIdentifier IReadOnlyEnumCasePattern.EnumCaseName => EnumCaseName;

    IReadOnlyTuplePattern? IReadOnlyEnumCasePattern.TuplePattern => TuplePattern;

    IReadOnlyIdentifier? IReadOnlyEnumCasePattern.TypeIdentifier => TypeIdentifier;

    public void SetTypeIdentifierTo(IIdentifier? newTypeIdentifier)
    {
        throw new NotImplementedException();
    }

    public void RemoveTypeIdentifier()
    {
        throw new NotImplementedException();
    }

    public void ChangeEnumCase(IIdentifier newEnumCase)
    {
        throw new NotImplementedException();
    }

    public void ChangeTuplePattern(ITuplePattern newTuplePattern)
    {
        throw new NotImplementedException();
    }
}
