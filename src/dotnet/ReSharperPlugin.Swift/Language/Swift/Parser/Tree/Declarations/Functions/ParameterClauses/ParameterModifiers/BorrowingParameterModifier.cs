using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class BorrowingParameterModifier : SwiftCompositeNode, IBorrowingParameterModifier
{
    public Borrowing Keyword { get; }

    internal BorrowingParameterModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Borrowing keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}