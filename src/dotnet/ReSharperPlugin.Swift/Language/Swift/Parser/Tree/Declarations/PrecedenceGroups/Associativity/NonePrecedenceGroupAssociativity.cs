using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class NonePrecedenceGroupAssociativity : SwiftCompositeNode, INonePrecedenceGroupAssociativity
{
    public Associativity AssociativityKeyword { get; }

    public Colon AssociativityIntroducer { get; }

    public None NoneKeyword { get; }

    internal NonePrecedenceGroupAssociativity(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Associativity associativityKeyword,
        Colon associativityIntroducer, None noneKeyword)
        : base(buffer, children)
    {
        AssociativityKeyword = associativityKeyword;
        AssociativityIntroducer = associativityIntroducer;
        NoneKeyword = noneKeyword;
    }
}
