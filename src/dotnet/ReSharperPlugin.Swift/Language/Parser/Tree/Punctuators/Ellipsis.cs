using System;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using Should.Core.Exceptions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

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

    public Ellipsis(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public Ellipsis(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }


    public static Ellipsis Create()
    {
        throw new NotImplementedException();
    }

    public static Ellipsis Create(ISwiftNode parent)
    {
        throw new NotImplementedException();
    }
}