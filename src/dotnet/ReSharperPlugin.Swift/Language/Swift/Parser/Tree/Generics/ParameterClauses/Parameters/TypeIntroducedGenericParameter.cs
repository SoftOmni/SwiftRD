using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public class TypeIntroducedGenericParameter : SwiftCompositeNode, ITypeIntroducedGenericParameter
{
    public Let LetKeyword { get; }

    public IIdentifier GenericParameterName { get; }

    public Colon TypeIntroducer { get; }

    public IType Type { get; }

    public IReadOnlyOperator Backslash { get; }

    internal TypeIntroducedGenericParameter(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Let letKeyword, IIdentifier genericParameterName, Colon typeIntroducer, IType type, IReadOnlyOperator backslash)
        : base(buffer, children)
    {
        LetKeyword = letKeyword;
        GenericParameterName = genericParameterName;
        TypeIntroducer = typeIntroducer;
        Type = type;
        Backslash = backslash;
    }

    IReadOnlyIdentifier IReadOnlyGenericParameter.GenericParameterName => GenericParameterName;

    IReadOnlyType IReadOnlyTypeIntroducedGenericParameter.Type => Type;

    public void ChangeGenericParameterName(IIdentifier newGenericParameterName)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeType(IType newType)
    {
        throw new System.NotImplementedException();
    }
}
