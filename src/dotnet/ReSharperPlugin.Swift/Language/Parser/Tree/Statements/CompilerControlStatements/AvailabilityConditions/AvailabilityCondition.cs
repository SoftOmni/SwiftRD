using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.Conditions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public class AvailabilityCondition : StatementInternalNode, ICondition, IList<AvailabilityArgument>
{
    public Identifier? AvailableIdentifier { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }

    private List<AvailabilityArgument> _availabilityArguments = [];
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public AvailabilityCondition(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AvailabilityCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AvailabilityCondition(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public AvailabilityCondition(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<AvailabilityArgument> AvailabilityArguments => _availabilityArguments;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<AvailabilityArgument> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(AvailabilityArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(AvailabilityArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(AvailabilityArgument[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(AvailabilityArgument item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(AvailabilityArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, AvailabilityArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public AvailabilityArgument this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}