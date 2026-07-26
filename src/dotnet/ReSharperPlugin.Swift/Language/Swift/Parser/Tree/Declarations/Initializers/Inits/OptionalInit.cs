using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;

public class OptionalInit : SwiftCompositeNode, IOptionalInit
{
    public Init InitKeyword { get; }

    public QuestionMark QuestionMark { get; }

    internal OptionalInit(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Init initKeyword, QuestionMark questionMark)
        : base(buffer, children)
    {
        InitKeyword = initKeyword;
        QuestionMark = questionMark;
    }
}
