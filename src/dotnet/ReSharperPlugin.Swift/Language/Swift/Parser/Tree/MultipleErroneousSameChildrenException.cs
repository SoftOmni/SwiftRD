using System;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

// TODO
[Serializable]
public class MultipleErroneousSameChildrenException
    : ArgumentException
{
    public MultipleErroneousSameChildrenException(Type node)
    {
        throw new NotImplementedException();
    }
    
    public MultipleErroneousSameChildrenException(string message)
        : base(message)
    { }
    
    public MultipleErroneousSameChildrenException(string message, Exception inner)
        : base(message, inner)
    { }

    public MultipleErroneousSameChildrenException(Dictionary<Type, int> doubledUpTypes)
    {
        throw new NotImplementedException();
    }
}