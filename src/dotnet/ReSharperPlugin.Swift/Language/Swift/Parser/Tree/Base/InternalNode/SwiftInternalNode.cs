using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Technology;
using ReSharperPlugin.Swift.Technology.Graphs;
using ReSharperPlugin.Swift.Technology.Graphs.StateMachines;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

public abstract partial class SwiftInternalNode : TreeElement, ISwiftNode
{
    protected readonly List<ISwiftNode> Children;

    public SwiftInternalNode? CoreParent { get; protected set; }

    protected SwiftInternalNode(IEditableBuffer buffer, List<ISwiftNode> children)
    {
        EditableBuffer = buffer;
        Children = children;
    }

    protected SwiftInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
    {
        EditableBuffer = buffer;
        Children = [..children];
    }

    protected SwiftInternalNode(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer, List<ISwiftNode> nodes)
    {
        CoreParent = parent;
        Children = nodes;
        EditableBuffer = buffer;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }

    protected SwiftInternalNode(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
    {
        CoreParent = parent;
        EditableBuffer = buffer;
        Children = [..nodes];
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }

    protected IEditableBuffer EditableBuffer { get; set; }

    public override NodeType NodeType => NodeTypes.NodeTypes.InternalNode;

    public ISwiftNode this[int index]
    {
        get => GetChildAt(index);
        set => SetChildAt(index, value);
    }

    public ISwiftNode GetChildAt(int index)
    {
        return Children[index];
    }

    

    public virtual void ClearChildren()
    {
        while (Children.Count > 0)
        {
            DetachChild(Children.Count - 1);
        }
    }

    internal virtual void ClearChildren(Action<ISwiftNode> onChildDetachment)
    {
        while (Children.Count > 0)
        {
            DetachChild(Children.Count - 1, onChildDetachment);
        }
    }

    internal virtual void ClearChildrenForcibly()
    {
        while (Children.Count > 0)
        {
            DetachChildForcibly(Children.Count - 1);
        }
    }

    internal virtual void ClearChildrenForcibly(Action<ISwiftNode> onChildDetachment)
    {
        while (Children.Count > 0)
        {
            DetachChildForcibly(Children.Count - 1, onChildDetachment);
        }
    }

    public SwiftInternalNode? GetParent()
    {
        return CoreParent;
    }

    public bool HasParent()
    {
        return CoreParent is not null;
    }

    public int ParentIndex { get; internal set; }

    public int ParentTextIndex { get; internal set; }

    public IBuffer GetBuffer()
    {
        return EditableBuffer;
    }

    public int NumberOfChildren()
    {
        return Children.Count;
    }

    // In future, optimize more cloning algorithms for performance
    protected abstract SwiftInternalNode DuplicateWithoutChildren();

    protected abstract SwiftInternalNode Duplicate();

    public ISwiftNode CloneAsDetachedDeep()
    {
        SwiftInternalNode newNode = DuplicateWithoutChildren();
        for (int index = 0; index < Children.Count; index++)
        {
            ISwiftNode child = Children[index];
            ISwiftNode cloned = child.CloneAsDetachedDeep();

            newNode.AttachChildForcibly(index, cloned);
        }

        return newNode;
    }

    public ISwiftNode CloneAsAttachedToDeep(SwiftInternalNode newParent, int index)
    {
        ISwiftNode cloned = CloneAsDetachedDeep();
        cloned.AttachToParent(newParent, index);

        return cloned;
    }

    public virtual void AttachToParent(SwiftInternalNode newParent, int parentIndex)
    {
        CoreParent?.DetachChild(ParentIndex);
        ParentTextIndex = newParent.AttachChild(parentIndex, this);
        CoreParent = newParent;
        ParentIndex = parentIndex;
    }

    internal virtual void AttachToParentForcibly(SwiftInternalNode newParent, int parentIndex)
    {
        CoreParent?.DetachChild(ParentIndex);
        ParentTextIndex = newParent.AttachChildForcibly(parentIndex, this);
        CoreParent = newParent;
        ParentIndex = parentIndex;
    }

    public override string GetText()
    {
        return EditableBuffer.GetText();
    }

    public override int GetTextLength()
    {
        return EditableBuffer.Length;
    }

    public override StringBuilder GetText(StringBuilder to)
    {
        return StringBuilderExtensions.Append(EditableBuffer, to);
    }

    public override IBuffer GetTextAsBuffer()
    {
        return EditableBuffer;
    }

    public override ITreeNode? FirstChild => Children.Count > 0 ? Children[0] : null;

    public override ITreeNode? LastChild => Children.Count > 0 ? Children[Children.Count - 1] : null;

    public override PsiLanguageType Language => SwiftLanguage.Instance!;

    public override ITreeNode FindNodeAt(TreeTextRange treeRange)
    {
        throw new NotImplementedException();
    }

    public override void FindNodesAtInternal(TreeTextRange relativeRange, List<ITreeNode> result, bool includeContainingNodes)
    {
        throw new NotImplementedException();
    }

    protected void CheckChildren(Type expectedChildType, HashSet<Type> alwaysAllowedTypes, bool allowMultiples = false)
    {
        CheckChildren(GetType(), Children, expectedChildType, alwaysAllowedTypes, allowMultiples);
    }

    protected static void CheckChildren(Type currentType, IEnumerable<ISwiftNode> childrenToCheck, Type expectedChildType,
        HashSet<Type> alwaysAllowedTypes, bool allowMultiples = false)
    {
        bool sawChild = false;
        foreach (ISwiftNode directChild in childrenToCheck)
        {
            Type directChildType = directChild.GetType();
            if (directChildType == expectedChildType)
            {
                if (sawChild && !allowMultiples)
                {
                    throw new SyntaxError(
                        $"The child of type {expectedChildType} was only allowed once but showed up more than once as a child of {currentType} (not semantically)");
                }

                sawChild = true;
            }
            else if (!alwaysAllowedTypes.Contains(directChildType))
            {
                throw new SyntaxError(
                    $"The child of type {directChildType} is forbidden as a child of {currentType} syntactically (not semantically)");
            }
        }
    }

    protected static void CheckChildren(Type currentType, List<ISwiftNode> childrenToCheck, Type expectedChildType, HashSet<Type> alwaysAllowedTypes,
        bool allowMultiples = false)
    {
        bool sawChild = false;
        foreach (ISwiftNode directChild in childrenToCheck)
        {
            Type directChildType = directChild.GetType();
            if (directChildType == expectedChildType)
            {
                if (sawChild && !allowMultiples)
                {
                    throw new SyntaxError(
                        $"The child of type {expectedChildType} was only allowed once but showed up more than once as a child of {currentType} (not semantically)");
                }

                sawChild = true;
            }
            else if (!alwaysAllowedTypes.Contains(directChildType))
            {
                throw new SyntaxError(
                    $"The child of type {directChildType} is forbidden as a child of {currentType} syntactically (not semantically)");
            }
        }
    }

    protected void CheckChildren(IEnumerable<Type> expectedChildTypes, HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        CheckChildren(GetType(), Children, expectedChildTypes, alwaysAllowedTypes, allowIncomplete);
    }


    protected static void CheckChildren(Type currentType, IEnumerable<ISwiftNode> childrenToCheck, IEnumerable<Type> expectedChildTypes,
        HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        IEnumerator<Type> expectedTypesEnumerator = expectedChildTypes.GetEnumerator();
        IEnumerator<ISwiftNode> childEnumerator = childrenToCheck.GetEnumerator();
        while (expectedTypesEnumerator.MoveNext())
        {
            Type childType = expectedTypesEnumerator.Current!;
            bool containsMoreChildren = childEnumerator.MoveNext();
            while (containsMoreChildren && childType != childEnumerator.Current!.GetType())
            {
                if (!alwaysAllowedTypes.Contains(childType))
                {
                    expectedTypesEnumerator.Dispose();
                    childEnumerator.Dispose();
                    throw new SyntaxError($"Error: came across a forbidden {childType} as a child of {currentType}");
                }

                containsMoreChildren = childEnumerator.MoveNext();
            }

            if (containsMoreChildren)
            {
                continue;
            }

            childEnumerator.Dispose();
            expectedTypesEnumerator.Dispose();
            if (!allowIncomplete)
            {
                return;
            }

            throw new SyntaxError($"Error: did not come across the expected {childType} as a child of {currentType}");
        }

        expectedTypesEnumerator.Dispose();
        while (childEnumerator.MoveNext())
        {
            if (!alwaysAllowedTypes.Contains(childEnumerator.Current!.GetType()))
            {
                throw new SyntaxError($"Error: came across a forbidden {childEnumerator.Current!.GetType()} as a child of {currentType}");
            }
        }

        childEnumerator.Dispose();
    }

    protected static void CheckChildren(Type currentType, List<ISwiftNode> childrenToCheck, IEnumerable<Type> expectedChildTypes,
        HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        IEnumerator<Type> enumerator = expectedChildTypes.GetEnumerator();
        int childIndex = 0;
        while (enumerator.MoveNext())
        {
            Type childType = enumerator.Current!;
            while (childIndex < childrenToCheck.Count && childType != childrenToCheck[childIndex].GetType())
            {
                if (!alwaysAllowedTypes.Contains(childType))
                {
                    enumerator.Dispose();
                    throw new SyntaxError($"Error: came across a forbidden {childType} as a child of {currentType}");
                }

                childIndex++;
            }

            if (childIndex != childrenToCheck.Count)
            {
                childIndex++;
                continue;
            }

            enumerator.Dispose();
            if (!allowIncomplete)
            {
                return;
            }

            throw new SyntaxError($"Error: did not come across the expected {childType} as a child of {currentType}");
        }

        enumerator.Dispose();
        while (childIndex < childrenToCheck.Count)
        {
            if (!alwaysAllowedTypes.Contains(childrenToCheck[childIndex].GetType()))
            {
                throw new SyntaxError($"Error: came across a forbidden {childrenToCheck[childIndex].GetType()} as a child of {currentType}");
            }
        }
    }

    protected void CheckChildren(List<Type> expectedChildTypes, HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        CheckChildren(GetType(), Children, expectedChildTypes, alwaysAllowedTypes, allowIncomplete);
    }

    protected static void CheckChildren(Type currentType, IEnumerable<ISwiftNode> newChildren, List<Type> expectedChildTypes,
        HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        int childTypesIndex = 0;
        IEnumerator<ISwiftNode> childEnumerator = newChildren.GetEnumerator();
        while (childTypesIndex < expectedChildTypes.Count)
        {
            Type expectedChildType = expectedChildTypes[childTypesIndex];
            bool containsMoreChildren = childEnumerator.MoveNext();
            while (containsMoreChildren && !expectedChildType.IsInstanceOfType(childEnumerator.Current!))
            {
                if (!alwaysAllowedTypes.Contains(expectedChildType))
                {
                    childEnumerator.Dispose();
                    throw new SyntaxError($"Error: came across a forbidden {expectedChildType} as a child of {currentType}");
                }

                containsMoreChildren = childEnumerator.MoveNext();
            }

            if (containsMoreChildren)
            {
                childTypesIndex++;
                continue;
            }

            childEnumerator.Dispose();
            if (!allowIncomplete)
            {
                return;
            }

            throw new SyntaxError($"Error: did not come across the expected {expectedChildType} as a child of {currentType}");
        }

        while (childEnumerator.MoveNext())
        {
            if (!alwaysAllowedTypes.Contains(childEnumerator.Current!.GetType()))
            {
                throw new SyntaxError($"Error: came across a forbidden {childEnumerator.Current!.GetType()} as a child of {currentType}");
            }
        }
    }

    protected void CheckChildren(ReadOnlyStateMachine<Type> expectedTypesStateMachine, HashSet<Type> alwaysAllowedTypes)
    {
        CheckChildren(GetType(), Children, expectedTypesStateMachine, alwaysAllowedTypes);
    }

    protected static void CheckChildren(Type currentType, IEnumerable<ISwiftNode> newChildren, ReadOnlyStateMachine<Type> expectedTypesStateMachine,
        HashSet<Type> alwaysAllowedTypes)
    {
        ReadOnlyStateMachine<Type>.ReadOnlyStateMachineNode current = expectedTypesStateMachine.StartNode;
        IEnumerator<ISwiftNode> childEnumerator = newChildren.GetEnumerator();
        bool containsMoreChildren = childEnumerator.MoveNext();
        while (containsMoreChildren && current.Value != childEnumerator.Current!.GetType())
        {
            if (!alwaysAllowedTypes.Contains(childEnumerator.Current!.GetType()))
            {
                throw new SyntaxError($"Error: came across a forbidden {childEnumerator.Current!.GetType()} as a child of {currentType}");
            }
        }

        if (!containsMoreChildren)
        {
            if (!current.IsAcceptState)
            {
                SyntaxError syntaxError =
                    new($"Error: did not come across the expected {childEnumerator.Current!.GetType()} as a child of {currentType}");
                childEnumerator.Dispose();
                throw syntaxError;
            }

            childEnumerator.Dispose();
            return;
        }

        while (childEnumerator.MoveNext())
        {
            if (current.TryGetEdgeTo(childEnumerator.Current!.GetType(), out IReadOnlyNode<Type>? newCurrent))
            {
                current = newCurrent as ReadOnlyStateMachine<Type>.ReadOnlyStateMachineNode ?? throw new ArgumentNullException(nameof(current));
                continue;
            }

            if (!alwaysAllowedTypes.Contains(childEnumerator.Current!.GetType()))
            {
                throw new SyntaxError($"Error: came across a forbidden {childEnumerator.Current!.GetType()} as a child of {currentType}");
            }
        }

        if (current.IsAcceptState)
        {
            return;
        }

        string joinedChildren = string.Join(", ", current.GetOutgoingEdges().Select((node => node.Value)));
        throw new SyntaxError($"Expected one of the following nodes: {joinedChildren} after {current.Value} as a child of {currentType}");
    }

    protected static void CheckChildren(Type currentType, List<ISwiftNode> newChildren, List<Type> expectedChildTypes,
        HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        int childTypesIndex = 0;
        int childIndex = 0;
        while (childTypesIndex < expectedChildTypes.Count)
        {
            Type childType = expectedChildTypes[childTypesIndex];
            while (childIndex < newChildren.Count && childType != newChildren[childIndex].GetType())
            {
                if (!alwaysAllowedTypes.Contains(childType))
                {
                    throw new SyntaxError($"Error: came across a forbidden {childType} as a child of {currentType}");
                }

                childIndex++;
            }

            if (childIndex != newChildren.Count)
            {
                childIndex++;
                childTypesIndex++;
                continue;
            }

            if (!allowIncomplete)
            {
                return;
            }

            throw new SyntaxError($"Error: did not come across the expected {childType} as a child of {currentType}");
        }

        while (childIndex < newChildren.Count)
        {
            if (!alwaysAllowedTypes.Contains(newChildren[childIndex].GetType()))
            {
                throw new SyntaxError($"Error: came across a forbidden {newChildren[childIndex].GetType()} as a child of {currentType}");
            }
        }
    }

    protected static void CheckChildren(Type currentType, List<ISwiftNode> newChildren, ReadOnlyStateMachine<Type> expectedTypesStateMachine,
        HashSet<Type> alwaysAllowedTypes)
    {
        ReadOnlyStateMachine<Type>.ReadOnlyStateMachineNode current = expectedTypesStateMachine.StartNode;
        int childIndex = 0;
        while (childIndex < newChildren.Count && current.Value != newChildren[childIndex].GetType())
        {
            if (!alwaysAllowedTypes.Contains(newChildren[childIndex].GetType()))
            {
                throw new SyntaxError($"Error: came across a forbidden {newChildren[childIndex].GetType()} as a child of {currentType}");
            }

            childIndex++;
        }

        if (childIndex == newChildren.Count)
        {
            if (!current.IsAcceptState)
            {
                throw new SyntaxError($"Error: did not come across the expected {newChildren[childIndex].GetType()} as a child of {currentType}");
            }

            return;
        }

        while (childIndex < newChildren.Count)
        {
            if (current.TryGetEdgeTo(newChildren[childIndex].GetType(), out IReadOnlyNode<Type>? newCurrent))
            {
                current = newCurrent as ReadOnlyStateMachine<Type>.ReadOnlyStateMachineNode ?? throw new ArgumentNullException(nameof(current));
                childIndex++;
                continue;
            }

            if (!alwaysAllowedTypes.Contains(newChildren[childIndex].GetType()))
            {
                throw new SyntaxError($"Error: came across a forbidden {newChildren[childIndex].GetType()} as a child of {currentType}");
            }
        }

        if (current.IsAcceptState)
        {
            return;
        }

        string joinedChildren = string.Join(", ", current.GetOutgoingEdges().Select((node => node.Value)));
        throw new SyntaxError($"Expected one of the following nodes: {joinedChildren} after {current.Value} as a child of {currentType}");
    }

    public int TextIndexOfInsertingAt(int index)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == 0)
        {
            return 0;
        }

        ISwiftNode precedingChild = Children[index - 1];
        return precedingChild.ParentTextIndex + precedingChild.GetTextLength();
    }
}

internal static class EditableBufferExtensions
{
    public static IEditableBuffer CloneBuffer(IEditableBuffer editableBuffer)
    {
        EditableBuffer newBuffer = new(editableBuffer.Length);
        for (int i = 0; i < editableBuffer.Length; i++)
        {
            newBuffer.Insert(i, editableBuffer[i].ToString());
        }

        return newBuffer;
    }

    public static IEditableBuffer CloneBuffer(IEditableBuffer editableBuffer, int start, int end)
    {
        if (start < 0 || start > editableBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (end < 0 || end > editableBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(end));
        }

        EditableBuffer newBuffer = new(editableBuffer.Length);
        for (int i = start; i < end; i++)
        {
            newBuffer.Insert(i, editableBuffer[i].ToString());
        }

        return newBuffer;
    }

    internal static IEditableBuffer CombineBuffers(int capacity, params IBuffer[] buffers)
    {
        EditableBuffer finalBuffer = new(capacity);

        for (int buffersIndex = 0; buffersIndex < finalBuffer.Length; buffersIndex++)
        {
            IBuffer buffer = buffers[buffersIndex];

            for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
            {
                finalBuffer.Insert(finalBuffer.Length, buffer[bufferIndex].ToString());
            }
        }

        return finalBuffer;
    }

    internal static IEditableBuffer CombineBuffers(params IBuffer[] buffers)
    {
        EditableBuffer finalBuffer = new();

        for (int buffersIndex = 0; buffersIndex < finalBuffer.Length; buffersIndex++)
        {
            IBuffer buffer = buffers[buffersIndex];

            for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
            {
                finalBuffer.Insert(finalBuffer.Length, buffer[bufferIndex].ToString());
            }
        }

        return finalBuffer;
    }
}