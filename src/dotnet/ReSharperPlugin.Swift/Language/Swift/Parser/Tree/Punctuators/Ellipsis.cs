using System;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using Should.Core.Exceptions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Ellipsis : SwiftInternalNode
{
    public Period? FirstPeriod { get; internal set; }
    
    public Period? SecondPeriod { get; internal set; }
    
    public Period? ThirdPeriod { get; internal set; }

    public Ellipsis(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Ellipsis(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Ellipsis(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public Ellipsis(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }


    public static Ellipsis Create()
    {
        throw new NotImplementedException();
    }

    public static Ellipsis Create(SwiftInternalNode parent)
    {
        throw new NotImplementedException();
    }
}