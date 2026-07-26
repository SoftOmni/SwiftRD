using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.CaptureSpecifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    ClosureExpressions.CaptureLists;

public class SimpleNamedCaptureListItem : SwiftCompositeNode, INamedCaptureListItem
{
    public ICaptureSpecifier? CaptureSpecifier { get; }

    public IIdentifier Name { get; }

    public Equal? Equal { get; }

    public IExpression? DefaultValueExpression { get; }

    internal SimpleNamedCaptureListItem(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ICaptureSpecifier? captureSpecifier, IIdentifier name, Equal? equal, IExpression? defaultValueExpression)
        : base(buffer, children)
    {
        CaptureSpecifier = captureSpecifier;
        Name = name;
        Equal = equal;
        DefaultValueExpression = defaultValueExpression;
    }

    internal SimpleNamedCaptureListItem(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier name, Equal? equal, IExpression? defaultValueExpression)
        : base(buffer, children)
    {
        CaptureSpecifier = null;
        Name = name;
        Equal = equal;
        DefaultValueExpression = defaultValueExpression;
    }

    internal SimpleNamedCaptureListItem(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ICaptureSpecifier? captureSpecifier, IIdentifier name)
        : base(buffer, children)
    {
        CaptureSpecifier = captureSpecifier;
        Name = name;
        Equal = null;
        DefaultValueExpression = null;
    }

    internal SimpleNamedCaptureListItem(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier name)
        : base(buffer, children)
    {
        CaptureSpecifier = null;
        Name = name;
        Equal = null;
        DefaultValueExpression = null;
    }

    IReadOnlyCaptureSpecifier? IReadOnlyCaptureListItem.CaptureSpecifier => CaptureSpecifier;

    IReadOnlyIdentifier IReadOnlyNamedCaptureListItem.Name => Name;

    IReadOnlyExpression? IReadOnlyNamedCaptureListItem.DefaultValueExpression => DefaultValueExpression;

    public bool HasDefaultValue => DefaultValueExpression is not null;

    public void ChangeName(IIdentifier name)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultValueTo(IExpression expression)
    {
        throw new NotImplementedException();
    }

    public void RemoveDefaultValue()
    {
        throw new NotImplementedException();
    }

    public void SetCaptureSpecifier(ICaptureSpecifier? newCaptureSpecifier)
    {
        throw new NotImplementedException();
    }

    public void RemoveCaptureSpecifier()
    {
        throw new NotImplementedException();
    }

    public void MakeWeak()
    {
        throw new NotImplementedException();
    }

    public void MakeUnowned()
    {
        throw new NotImplementedException();
    }

    public void MakeUnownedSafe()
    {
        throw new NotImplementedException();
    }

    public void MakeUnownedUnsafe()
    {
        throw new NotImplementedException();
    }
}
