using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Exceptions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;
using SoftOmni.SwiftRd.Technology;
using SoftOmni.SwiftRd.Technology.RelativePositions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

public class CodeBlock : SwiftInternalNode, IList<IStatement>
{
    public LeftCurlyBrace? LeftCurlyBrace { get; protected set; }

    public StatementGroup? StatementGroup { get; private set; }

    public RightCurlyBrace? RightCurlyBrace { get; protected set; }

    internal CodeBlock(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    internal CodeBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    internal CodeBlock(IEditableBuffer buffer, List<ISwiftNode> swiftNodes, LeftCurlyBrace leftCurlyBrace,
        RightCurlyBrace rightCurlyBrace, StatementGroup? statementGroup = null)
        : base(buffer, swiftNodes)
    {
        LeftCurlyBrace = leftCurlyBrace;
        StatementGroup = statementGroup;
        RightCurlyBrace = rightCurlyBrace;
    }

    internal CodeBlock(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer,
        List<ISwiftNode> nodes)
        : base(parent, parentIndex, parentTextIndex, buffer, nodes)
    { }

    internal CodeBlock(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer,
        IEnumerable<ISwiftNode> nodes)
        : base(parent, parentIndex, parentTextIndex, buffer, nodes)
    { }

    public bool IsEmpty => StatementGroup is null or StatementGroup.IsEmpty;

    public bool HasStatements => StatementGroup is not null and StatementGroup.HasStatements;

    public static CodeBlock Create()
    {
        IEditableBuffer buffer = new EditableBuffer(LeftCurlyBrace.Value + RightCurlyBrace.Value);

        LeftCurlyBrace leftCurlyBrace = new(new SubEditableBuffer(buffer, 0, 0));
        RightCurlyBrace rightCurlyBrace = new(new SubEditableBuffer(buffer, 1, LeftCurlyBrace.Value.Length));

        return new CodeBlock(buffer, [leftCurlyBrace, rightCurlyBrace], leftCurlyBrace, rightCurlyBrace);
    }

    public static CodeBlock Create(IEnumerable<IStatement> statements)
    {
        CodeBlock codeBlock = Create();
        foreach (IStatement statement in statements)
        {
            codeBlock.Add(statement);
        }

        return codeBlock;
    }

    public static CodeBlock Create(IEnumerable<IStatement> statements, int start)
    {
        CodeBlock codeBlock = Create();
        IEnumerator<IStatement> enumerator = statements.GetEnumerator();
        int index = 0;
        while (enumerator.MoveNext() && index < start)
        {
            index++;
        }

        if (index < start)
        {
            enumerator.Dispose();
            return codeBlock;
        }

        do
        {
            codeBlock.Add(enumerator.Current!);
        } while (enumerator.MoveNext());

        return codeBlock;
    }

    public static CodeBlock Create(IEnumerable<IStatement> statements, int start, int end)
    {
        CodeBlock codeBlock = Create();
        IEnumerator<IStatement> enumerator = statements.GetEnumerator();
        int index = 0;
        while (enumerator.MoveNext() && index < start)
        {
            index++;
        }

        if (index < start)
        {
            enumerator.Dispose();
            return codeBlock;
        }

        do
        {
            codeBlock.Add(enumerator.Current!);
            index++;
        } while (enumerator.MoveNext() && index < end);

        return codeBlock;
    }

    public static CodeBlock Create(List<IStatement> statements)
    {
        CodeBlock codeBlock = Create();
        foreach (IStatement statement in statements)
        {
            codeBlock.Add(statement);
        }

        return codeBlock;
    }

    public static CodeBlock Create(List<IStatement> statements, int start)
    {
        if (start < 0 || start >= statements.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        CodeBlock codeBlock = Create();
        int index = start;
        while (index < statements.Count)
        {
            codeBlock.Add(statements[index++]);
        }

        return codeBlock;
    }

    public static CodeBlock Create(List<IStatement> statements, int start, int end)
    {
        if (start < 0 || start >= statements.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (end < 0 || end > statements.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(end));
        }

        CodeBlock codeBlock = Create();
        for (int i = start; i < end; i++)
        {
            codeBlock.Add(statements[i]);
        }

        return codeBlock;
    }

    public static CodeBlock Create(StatementGroup statementGroup)
    {
        CodeBlock codeBlock = Create();
        int index = 0;
        while (index < statementGroup.Count)
        {
            codeBlock.Add(statementGroup[index++]);
        }

        return codeBlock;
    }

    public static CodeBlock Create(StatementGroup statementGroup, int start)
    {
        if (start < 0 || start >= statementGroup.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        CodeBlock codeBlock = Create();
        int index = start;
        while (index < statementGroup.Count)
        {
            codeBlock.Add(statementGroup[index++]);
        }

        return codeBlock;
    }

    public static CodeBlock Create(StatementGroup statementGroup, int start, int end)
    {
        if (start < 0 || start >= statementGroup.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (end < 0 || end > statementGroup.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(end));
        }

        CodeBlock codeBlock = Create();
        int index = start;
        while (index < end)
        {
            codeBlock.Add(statementGroup[index++]);
        }

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex)
    {
        CodeBlock codeBlock = Create();
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex,
        IEnumerable<IStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex,
        IEnumerable<IStatement> statements, int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex,
        IEnumerable<IStatement> statements, int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex,
        List<IStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex,
        List<IStatement> statements, int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex,
        List<IStatement> statements, int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex,
        StatementGroup statementGroup)
    {
        CodeBlock codeBlock = Create(statementGroup);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex,
        StatementGroup statementGroup, int startIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(SwiftInternalNode parent, int parentIndex,
        StatementGroup statementGroup, int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex, endIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent)
    {
        CodeBlock codeBlock = Create();
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent, IEnumerable<IStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent,
        IEnumerable<IStatement> statements, int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent,
        IEnumerable<IStatement> statements, int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent, List<IStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent, List<IStatement> statements,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent, List<IStatement> statements, int startIndex,
        int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent, StatementGroup statementGroup)
    {
        CodeBlock codeBlock = Create(statementGroup);
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent, StatementGroup statementGroup,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex);
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(SwiftInternalNode parent, StatementGroup statementGroup,
        int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex, endIndex);
        parent.PrependChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent)
    {
        CodeBlock codeBlock = Create();
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent, IEnumerable<IStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent, IEnumerable<IStatement> statements,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent, IEnumerable<IStatement> statements,
        int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent, List<IStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent, List<IStatement> statements,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent, List<IStatement> statements,
        int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent, StatementGroup statementGroup)
    {
        CodeBlock codeBlock = Create(statementGroup);
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent, StatementGroup statementGroup,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex);
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(SwiftInternalNode parent, StatementGroup statementGroup,
        int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex, endIndex);
        parent.AppendChild(codeBlock);

        return codeBlock;
    }

    protected override SwiftInternalNode Duplicate()
    {
        throw new NotImplementedException();
    }

    protected override SwiftInternalNode DuplicateWithoutChildren()
    {
        throw new NotImplementedException();
    }

    protected override void CheckChildrenForSetting(List<ISwiftNode> newNodes)
    {
        base.CheckChildrenForSetting(newNodes);
    }

    protected override List<ISwiftNode> CheckChildrenForSetting(IEnumerable<ISwiftNode> newNodes)
    {
        return base.CheckChildrenForSetting(newNodes);
    }

    public override int AttachChild(int index, ISwiftNode child)
    {
        if (child is IWhitespaceNode or ICommentNode)
        {
            return base.AttachChild(index, child);
        }

        if (child is RightCurlyBrace rightCurlyBrace)
        {
            if (RightCurlyBrace is not null)
            {
                throw new DuplicateAttachmentException<CodeBlock, RightCurlyBrace>("right curly brace",
                    nameof(rightCurlyBrace));
            }

            RightCurlyBrace = rightCurlyBrace;
            return base.AttachChild(index, child);
        }

        if (child is LeftCurlyBrace leftCurlyBrace)
        {
            if (LeftCurlyBrace is not null)
            {
                throw new DuplicateAttachmentException<CodeBlock, LeftCurlyBrace>("left curly brace",
                    nameof(leftCurlyBrace));
            }

            if (StatementGroup is not null && StatementGroup.Count > 0 && StatementGroup[0].ParentIndex < index)
            {
                throw new IncorrectChildPlacementException("left curly brace", index,
                    "first statement", StatementGroup[0].ParentIndex);
            }

            if (RightCurlyBrace is not null && RightCurlyBrace.ParentIndex < index)
            {
                throw new IncorrectChildPlacementException("left curly brace", index,
                    "right curly brace", RightCurlyBrace.ParentIndex);
            }

            LeftCurlyBrace = leftCurlyBrace;
            return base.AttachChild(index, child);
        }

        if (child is not IStatement statement)
        {
            throw new ArgumentException("The type you tried to attach is neither a whitespace, a comment, " +
                                        "a left curly brace, a right curly brace or a statement.\n" +
                                        "Only such elements are allowed to be attached to code blocks");
        }

        if (RightCurlyBrace is not null && RightCurlyBrace.ParentIndex < index)
        {
            throw new IncorrectChildPlacementException("statement", index,
                "right curly brace", RightCurlyBrace.ParentIndex);
        }

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

    public override void DetachChild(int childIndex)
    {
        base.DetachChild(childIndex);
    }

    public static implicit operator StatementGroup?(CodeBlock codeBlock)
    {
        return codeBlock.StatementGroup;
    }

    public IEnumerator<IStatement> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(IStatement item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(IStatement item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(IStatement[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(IStatement item)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }

    public bool IsReadOnly { get; }

    public int IndexOf(IStatement item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IStatement item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public new IStatement this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}