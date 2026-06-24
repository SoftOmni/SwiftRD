using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ImplicitlyUnwrappedOptionalType;

public class ImplicitlyUnwrappedOptionalType : SwiftCompositeNode, IImplicitlyUnwrappedOptionalType
{
    public IType Type { get; internal set; }

    public ExclamationMark ExclamationMark { get; }

    internal ImplicitlyUnwrappedOptionalType(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IType type, ExclamationMark exclamationMark)
        : base(buffer, children)
    {
        Type = type;
        ExclamationMark = exclamationMark;
        
        ActualType = GenerateUnderlyingType();
    }

    IReadOnlyType IReadOnlyImplicitlyUnwrappedOptionalType.Type => Type;

    public IReadOnlyDeclaration? Declaration => ActualType.Declaration;

    public IReadOnlyType ActualType { get; }

    public string TypeSignature => $"Optional<{Type.TypeSignature}>";

    public IReadOnlyType? SuperType => ActualType.SuperType;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains => ActualType.SubTypeChains;

    public IReadOnlySet<IReadOnlyType> SubTypes => ActualType.SubTypes;

    public IReadOnlySet<string> SubTypeNames => ActualType.SubTypeNames;

    public bool IsFromStandardLibrary => ActualType.IsFromStandardLibrary;

    public int Size => ActualType.Size;

    public void ChangeType(IType type)
    {
        throw new NotImplementedException();
    }

    private IType GenerateUnderlyingType()
    {
        throw new NotImplementedException();
    }
}