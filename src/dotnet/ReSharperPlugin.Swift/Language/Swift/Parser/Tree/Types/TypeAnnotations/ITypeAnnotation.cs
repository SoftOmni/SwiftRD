using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Types.TypeAnnotations;

public interface ITypeAnnotation : IReadOnlyTypeAnnotation, IList<IAttribute>
{
    new IAttributeGroup AttributeGroup { get; }

    void SetType(IType type);
}