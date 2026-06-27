using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public interface IFunctionTypeArgumentList : IReadOnlyFunctionTypeArgumentList, IList<IFunctionTypeArgument>
{
    new IReadOnlyList<IFunctionTypeArgument> TypeArguments { get; }
    
    new int Count { get; }

    new IEnumerator<IFunctionTypeArgument> GetEnumerator();
    
    new IFunctionTypeArgument this[int index] { get; set; } 
}
// TODO: Implement Concrete Type