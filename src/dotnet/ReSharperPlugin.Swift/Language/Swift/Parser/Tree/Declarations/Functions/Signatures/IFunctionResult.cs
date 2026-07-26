using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public interface IFunctionResult : IReadOnlyFunctionResult
{
    new IAttributeGroup? AttributeGroup { get; }
    
    new IType Type { get; }

    void SetAttributesGroupTo(IAttributeGroup? attributeGroup);

    void RemoveAttributesGroup();

    void ChangeType(IType type);
}
