using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

public interface IReadOnlyUsableDeclaration<TUsage> : IReadOnlyDeclaration
{
    public IReadOnlyDictionary<TUsage, IReadOnlyTopLevelDeclaration> Usages { get; }
}
