using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ArrayTypes;

public class ArrayType : TypeInternalNode
{
    public LeftSquareBracket? LeftSquareBracket { get; internal set; }

    public IType? Type { get; internal set; }

    public RightSquareBracket? RightSquareBracket { get; internal set; }

    private List<LeftSquareBracket> _leftSquareBrackets = [];

    private List<IType> _types = [];

    private List<RightSquareBracket> _rightSquareBrackets = [];

    internal ArrayType(IEditableBuffer buffer)
        : base(buffer, [])
    { }

    internal ArrayType(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    {
        SetupChildren();
    }

    private ArrayType(LeftSquareBracket leftSquareBracket, IType type, RightSquareBracket rightSquareBracket)
        : base(
            EditableBufferExtensions.CombineBuffers(leftSquareBracket.Buffer, type.GetBuffer(),
                rightSquareBracket.Buffer),
            [leftSquareBracket, type, rightSquareBracket])
    {
        LeftSquareBracket = leftSquareBracket;
        Type = type;
        RightSquareBracket = rightSquareBracket;

        LeftSquareBracket.AttachToParent(this, 0);
        Type.AttachToParent(this, 1);
        RightSquareBracket.AttachToParent(this, 2);
    }

    private ArrayType(IEditableBuffer buffer, LeftSquareBracket? leftSquareBracket, IType? type,
        RightSquareBracket? rightSquareBracket)
        : base(buffer, [])
    {
        LeftSquareBracket = leftSquareBracket;
        Type = type;
        RightSquareBracket = rightSquareBracket;

        if (leftSquareBracket is not null)
        {
            Children.Add(leftSquareBracket);
        }
        else if (type is not null)
        {
            Children.Add(type);
        }
        else if (rightSquareBracket is not null)
        {
            Children.Add(rightSquareBracket);
        }
    }

    private ArrayType(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer,
        LeftSquareBracket? leftSquareBracket, IType? type,
        RightSquareBracket? rightSquareBracket)
        : base(parent, parentIndex, parentTextIndex, buffer, [])
    {
        LeftSquareBracket = leftSquareBracket;
        Type = type;
        RightSquareBracket = rightSquareBracket;

        if (leftSquareBracket is not null)
        {
            Children.Add(leftSquareBracket);
        }
        else if (type is not null)
        {
            Children.Add(type);
        }
        else if (rightSquareBracket is not null)
        {
            Children.Add(rightSquareBracket);
        }
    }

    internal ArrayType(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer,
        List<ISwiftNode> nodes)
        : base(parent, parentIndex, parentTextIndex, buffer, nodes)
    {
        SetupChildren();
    }

    protected override SwiftInternalNode Duplicate()
    {
        return new ArrayType(EditableBufferExtensions.CloneBuffer(EditableBuffer), LeftSquareBracket, Type,
            RightSquareBracket);
    }

    protected override SwiftInternalNode DuplicateWithoutChildren()
    {
        return new ArrayType(new EditableBuffer()); // TODO: Review this API
    }

    private void SetupChildren()
    {
        Dictionary<Type, int> doubledUpTypes = [];
        foreach (ISwiftNode child in Children)
        {
            switch (child)
            {
                case LeftSquareBracket leftSquareBracket when LeftSquareBracket is null:
                    LeftSquareBracket = leftSquareBracket;
                    continue;
                case LeftSquareBracket _ when doubledUpTypes.ContainsKey(typeof(LeftSquareBracket)):
                    doubledUpTypes[typeof(LeftSquareBracket)]++;
                    continue;
                case IType type when Type is null:
                    Type = type;
                    break;
                case IType _ when doubledUpTypes.ContainsKey(typeof(IType)):
                    doubledUpTypes[typeof(IType)]++;
                    break;
                case RightSquareBracket rightSquareBracket when RightSquareBracket is null:
                    RightSquareBracket = rightSquareBracket;
                    continue;
                case RightSquareBracket _ when doubledUpTypes.ContainsKey(typeof(RightSquareBracket)):
                    doubledUpTypes[typeof(RightSquareBracket)]++;
                    continue;
            }
        }

        if (doubledUpTypes.Count > 0)
        {
            throw new MultipleErroneousSameChildrenException(doubledUpTypes);
        }
        
        UpdateTypeSignature();
    }

    public override bool IsValid()
    {
        return LeftSquareBracket is not null && Type is not null && RightSquareBracket is not null
               && LeftSquareBracket.ParentIndex < Type.ParentIndex && Type.ParentIndex < RightSquareBracket.ParentIndex;
    }

    public static ArrayType Create(IType type)
    {
        ArrayType arrayType = new(new EditableBuffer());

        LeftSquareBracket leftSquareBracket = LeftSquareBracket.Create(arrayType, 0);
        arrayType.AttachChild(1, type);
        RightSquareBracket rightSquareBracket = RightSquareBracket.Create(arrayType, 2);

        arrayType.LeftSquareBracket = leftSquareBracket;
        arrayType.Type = type;
        arrayType.RightSquareBracket = rightSquareBracket;

        return arrayType;
    }

    public static ArrayType Create(LeftSquareBracket leftSquareBracket, IType type,
        RightSquareBracket rightSquareBracket)
    {
        ArrayType arrayType = new(new EditableBuffer());

        arrayType.AttachChild(0, leftSquareBracket);
        arrayType.AttachChild(1, type);
        arrayType.AttachChild(2, rightSquareBracket);

        arrayType.LeftSquareBracket = leftSquareBracket;
        arrayType.Type = type;
        arrayType.RightSquareBracket = rightSquareBracket;

        return arrayType;
    }

    public static ArrayType Create(SwiftInternalNode parent, int parentIndex, IType type)
    {
        ArrayType arrayType = Create(type);
        arrayType.AttachToParent(parent, parentIndex);

        return arrayType;
    }

    public static ArrayType Create(SwiftInternalNode parent, int parentIndex, LeftSquareBracket leftSquareBracket,
        IType type,
        RightSquareBracket rightSquareBracket)
    {
        ArrayType arrayType = Create(leftSquareBracket, type, rightSquareBracket);
        arrayType.AttachToParent(parent, parentIndex);

        return arrayType;
    }

    internal static ArrayType CreateUnchecked(SwiftInternalNode parent, int parentIndex, IType type)
    {
        return Create(parent, parentIndex, type); // TODO: Review this API
    }

    internal static ArrayType CreateUnchecked(SwiftInternalNode parent, int parentIndex,
        LeftSquareBracket leftSquareBracket,
        IType type,
        RightSquareBracket rightSquareBracket)
    {
        //TODO: Investigate swift internal nodes around empty buffers with parent
        ArrayType arrayType = new(new EditableBuffer());

        arrayType.AttachToParent(parent, parentIndex);

        arrayType.LeftSquareBracket = leftSquareBracket;
        arrayType.Type = type;
        arrayType.RightSquareBracket = rightSquareBracket;

        return arrayType;
    }

    protected override void CheckChildrenForSetting(List<ISwiftNode> newNodes)
    {
        CheckChildren(typeof(ArrayType), newNodes,
            [typeof(LeftSquareBracket), typeof(IType), typeof(RightSquareBracket)],
            [typeof(IWhitespaceNode), typeof(ICommentNode)]);
        base.CheckChildrenForSetting(newNodes);
    }

    protected override List<ISwiftNode> CheckChildrenForSetting(IEnumerable<ISwiftNode> newNodes)
    {
        List<ISwiftNode> children = newNodes.ToList();
        CheckChildrenForSetting(children);

        return children;
    }

    public override int AttachChild(int index, ISwiftNode child)
    {
        if (child is Whitespace.IWhitespaceNode or Comments.ICommentNode)
        {
            return base.AttachChild(index, child);
        }

        if (child is not Punctuators.LeftSquareBracket and not IType and not Punctuators.RightSquareBracket)
        {
            throw new NotSupportedException(
                "Only whitespace, comments, a left square bracket, a type or a right square " +
                "bracket may be attached to an array node");
        }

        if (child is RightSquareBracket rightSquareBracket)
        {
            if (RightSquareBracket is not null)
            {
                throw new ArgumentException(
                    "The right square bracket is already set. No second right square brackets allowed");
            }

            RightSquareBracket = rightSquareBracket;
            return base.AttachChild(index, child);
        }

        if (child is IType type)
        {
            if (Type is not null)
            {
                throw new ArgumentException("The type is already set. No second type brackets allowed");
            }

            if (RightSquareBracket is not null && RightSquareBracket.ParentIndex < index)
            {
                throw new ArgumentException(
                    $"The type must be before the right square bracket's index (position {RightSquareBracket.ParentIndex} (you tried to set at {index}))",
                    nameof(index));
            }

            Type = type;
            UpdateTypeSignature();
            return base.AttachChild(index, child);
        }

        // child is left square bracket
        LeftSquareBracket leftSquareBracket = (child as LeftSquareBracket)!;
        if (LeftSquareBracket is not null)
        {
            throw new ArgumentException(
                "The left square bracket is already set. No second left square brackets allowed");
        }

        if (Type is not null && Type.ParentIndex < index)
        {
            throw new ArgumentException(
                $"The left square bracket must be before the type's index (position {Type.ParentIndex} (you tried to set at {index}))",
                nameof(index));
        }

        if (RightSquareBracket is not null && RightSquareBracket.ParentIndex < index)
        {
            throw new ArgumentException(
                $"The left square bracket must be before the right square bracket's index (position {RightSquareBracket.ParentIndex} (you tried to set at {index}))",
                nameof(index));
        }

        LeftSquareBracket = leftSquareBracket;
        return base.AttachChild(index, child);
    }


    internal override int AttachChildForcibly(int index, ISwiftNode child)
    {
        switch (child)
        {
            case LeftSquareBracket leftSquareBracket:
            {
                _leftSquareBrackets.Add(leftSquareBracket);
                LeftSquareBracket ??= leftSquareBracket;
                break;
            }
            case IType type:
            {
                _types.Add(type);
                Type ??= type;
                break;
            }
            case RightSquareBracket rightSquareBracket:
            {
                _rightSquareBrackets.Add(rightSquareBracket);
                RightSquareBracket ??= rightSquareBracket;
                break;
            }
        }

        return base.AttachChildForcibly(index, child);
    }

    public override void ClearChildren()
    {
        throw new NotSupportedException("You cannot clear the children of this composite node " +
                                        "because doing so would make the code invalid");
    }

    internal override void ClearChildrenForcibly()
    {
        LeftSquareBracket = null;
        Type = null;
        RightSquareBracket = null;

        base.ClearChildrenForcibly();
    }

    public override void DetachChild(int childIndex)
    {
        if (childIndex < 0 || childIndex >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(childIndex));
        }

        if (LeftSquareBracket is not null && LeftSquareBracket.ParentIndex == childIndex)
        {
            LeftSquareBracket = null;
        }

        base.DetachChild(childIndex);
    }

    private void UpdateTypeSignature()
    {
        UpdateTypeSignature(Type);
    }

    private void UpdateTypeSignature(IType? type)
    {
        if (type is null)
        {
            TypeSignature = "Array<>";
            return;
        }
        
        TypeSignature = $"Array<{type}>";
    }

    public override bool IsFiltered()
    {
        return false;
    }
}