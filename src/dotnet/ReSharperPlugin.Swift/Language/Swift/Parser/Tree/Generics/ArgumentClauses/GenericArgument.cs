using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public class GenericArgument : IGenericArgument
{
    public IType Type { get; }
    
    public IGenericArgumentDefinition? GenericArgumentDefinition { get; internal set; }

    internal GenericArgument(IType type, IGenericArgumentDefinition? genericArgumentDefinition = null)
    {
        Type = type;
        GenericArgumentDefinition = genericArgumentDefinition;
    }

    public bool IsValid()
    {
        return GenericArgumentDefinition is not null && AreConstraintsSatisfied();
    }
    
    public bool AreConstraintsSatisfied()
    {
        if (GenericArgumentDefinition is null)
        {
            return true;
        }

        throw new NotImplementedException();
    }
}