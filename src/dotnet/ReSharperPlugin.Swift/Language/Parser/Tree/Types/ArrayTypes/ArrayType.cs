using System;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.ArrayTypes;

public class ArrayType : TypeInternalNode
{
    public LeftSquareBracket? LeftSquareBracket { get; internal set; }

    public IType? Type { get; internal set; }

    public RightSquareBracket? RightSquareBracket { get; internal set; }

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

    public static ArrayType Create(SwiftInternalNode parent, int parentIndex, LeftSquareBracket leftSquareBracket, IType type,
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

    internal static ArrayType CreateUnchecked(SwiftInternalNode parent, int parentIndex, LeftSquareBracket leftSquareBracket,
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
        CheckChildren(typeof(ArrayType), newNodes, [typeof(LeftSquareBracket), typeof(IType), typeof(RightSquareBracket)], [typeof(IWhitespaceNode), typeof(ICommentNode)]);
    }

    protected override List<ISwiftNode> CheckChildrenForSetting(IEnumerable<ISwiftNode> newNodes)
    {
        return base.CheckChildrenForSetting(newNodes);
    }

    public override int AttachChild(int index, ISwiftNode child)
    {
        return base.AttachChild(index, child);
    }

    internal override int AttachChildForcibly(int index, ISwiftNode child)
    {
        return base.AttachChildForcibly(index, child);
    }

    public override void ClearChildren()
    {
        base.ClearChildren();
    }

    internal override void ClearChildrenForcibly()
    {
        base.ClearChildrenForcibly();
    }

    public override void AttachToParent(SwiftInternalNode newParent, int parentIndex)
    {
        base.AttachToParent(newParent, parentIndex);
    }

    internal override void AttachToParentForcibly(SwiftInternalNode newParent, int parentIndex)
    {
        base.AttachToParentForcibly(newParent, parentIndex);
    }

    public override void DetachChild(int childIndex)
    {
        base.DetachChild(childIndex);
    }

    public override bool IsFiltered()
    {
        return base.IsFiltered();
    }
}