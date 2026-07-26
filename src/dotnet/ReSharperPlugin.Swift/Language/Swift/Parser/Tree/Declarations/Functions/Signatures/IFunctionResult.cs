using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public interface IFunctionResult : IReadOnlyFunctionResult
{
    new IAttributeGroup? Attributes { get; }
    
    new IType Type { get; }

    void SetAttributesGroupTo(IAttributeGroup? newAttributes);

    void RemoveAttributesGroup();

    void ChangeType(IType newType);
}
