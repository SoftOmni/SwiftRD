using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;

public interface IReadOnlyStatement : ISwiftNode<SwiftCompositeNode>
{
    // public bool CanHaveMultipleOnOneLineSeparatedBySemicolons { get; }
}