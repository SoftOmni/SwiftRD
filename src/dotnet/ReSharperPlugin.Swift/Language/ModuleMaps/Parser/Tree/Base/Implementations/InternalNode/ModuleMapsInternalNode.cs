using System.Collections.Generic;
using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.InternalNodes;

public abstract class ModuleMapsInternalNode<TSelf> : InternalNode<IModuleMapsNodeFamily<TSelf>, TSelf, ModuleMapsLeafNode<TSelf>>, IModuleMapsInternalNode<TSelf>,
    IModuleMapsNode<TSelf> where TSelf : ModuleMapsInternalNode<TSelf>
{
    protected ModuleMapsInternalNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected ModuleMapsInternalNode(TSelf parent, int index, IEditableBuffer editableBuffer, IEnumerable<IModuleMapsNode<TSelf>>? children = null)
        : base(parent, index, editableBuffer, children)
    { }

    protected ModuleMapsInternalNode(TSelf parent, int index, int textIndex, int lengthInParent, IEnumerable<IModuleMapsNode<TSelf>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children)
    { }

    protected ModuleMapsInternalNode(IEditableBuffer buffer, IEnumerable<IModuleMapsNode<TSelf>> children)
        : base(buffer, children)
    { }

    public override PsiLanguageType Language => ModuleMapsLanguage.Instance!;

    /*protected void CheckChildren(Type expectedChildType, HashSet<Type> alwaysAllowedTypes, bool allowMultiples = false)
    {
        CheckChildren(GetType(), ChildNodes, expectedChildType, alwaysAllowedTypes, allowMultiples);
    }

    protected static void CheckChildren(Type currentType, IEnumerable<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> childrenToCheck, Type expectedChildType,
        HashSet<Type> alwaysAllowedTypes, bool allowMultiples = false)
    {
        bool sawChild = false;
        foreach (INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>> directChild in childrenToCheck)
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

    protected static void CheckChildren(Type currentType, List<ISwiftNode<TSelf>> childrenToCheck, Type expectedChildType, HashSet<Type> alwaysAllowedTypes,
        bool allowMultiples = false)
    {
        bool sawChild = false;
        foreach (ISwiftNode<TSelf> directChild in childrenToCheck)
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
        CheckChildren(GetType(), ChildNodes, expectedChildTypes, alwaysAllowedTypes, allowIncomplete);
    }


    protected static void CheckChildren(Type currentType, IEnumerable<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> childrenToCheck, IEnumerable<Type> expectedChildTypes,
        HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        IEnumerator<Type> expectedTypesEnumerator = expectedChildTypes.GetEnumerator();
        IEnumerator<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> childEnumerator = childrenToCheck.GetEnumerator();
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

    protected static void CheckChildren(Type currentType, List<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> childrenToCheck, IEnumerable<Type> expectedChildTypes,
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
        CheckChildren(GetType(), ChildNodes, expectedChildTypes, alwaysAllowedTypes, allowIncomplete);
    }

    protected static void CheckChildren(Type currentType, IEnumerable<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> newChildren, List<Type> expectedChildTypes,
        HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        int childTypesIndex = 0;
        IEnumerator<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> childEnumerator = newChildren.GetEnumerator();
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
        CheckChildren(GetType(), ChildNodes, expectedTypesStateMachine, alwaysAllowedTypes);
    }

    protected static void CheckChildren(Type currentType, IEnumerable<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> newChildren, ReadOnlyStateMachine<Type> expectedTypesStateMachine,
        HashSet<Type> alwaysAllowedTypes)
    {
        ReadOnlyStateMachine<Type>.ReadOnlyStateMachineNode current = expectedTypesStateMachine.StartNode;
        IEnumerator<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> childEnumerator = newChildren.GetEnumerator();
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

    protected static void CheckChildren(Type currentType, List<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> newChildren, List<Type> expectedChildTypes,
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

    protected static void CheckChildren(Type currentType, List<INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>> newChildren, ReadOnlyStateMachine<Type> expectedTypesStateMachine,
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
        if (index < 0 || index >= NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == 0)
        {
            return 0;
        }

        ISwiftNode<TSelf> precedingChild = (ISwiftNode<TSelf>)ChildNodes[index - 1];
        return precedingChild.ParentTextIndex + precedingChild.GetTextLength();
    }*/
}