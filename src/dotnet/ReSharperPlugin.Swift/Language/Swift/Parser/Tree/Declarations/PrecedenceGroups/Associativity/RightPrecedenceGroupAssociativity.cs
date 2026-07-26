using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class RightPrecedenceGroupAssociativity : SwiftCompositeNode, IRightPrecedenceGroupAssociativity
{
    public Associativity AssociativityKeyword { get; }

    public Colon AssociativityIntroducer { get; }

    public Right RightKeyword { get; }

    internal RightPrecedenceGroupAssociativity(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Associativity associativityKeyword,
        Colon associativityIntroducer, Right rightKeyword)
        : base(buffer, children)
    {
        AssociativityKeyword = associativityKeyword;
        AssociativityIntroducer = associativityIntroducer;
        RightKeyword = rightKeyword;
    }
}
