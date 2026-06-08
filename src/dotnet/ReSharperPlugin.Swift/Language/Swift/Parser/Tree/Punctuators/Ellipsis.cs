using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Ellipsis : SwiftCompositeNode
{
    public Period FirstPeriod { get; internal set; }
    
    public Period SecondPeriod { get; internal set; }
    
    public Period ThirdPeriod { get; internal set; }

    internal Ellipsis(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Period firstPeriod, Period secondPeriod, Period thirdPeriod)
        : base(buffer, children)
    {
        FirstPeriod = firstPeriod;
        SecondPeriod = secondPeriod;
        ThirdPeriod = thirdPeriod;
    }

    public static Ellipsis Create()
    {
        throw new NotImplementedException();
    }
}