using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

public class CodeBlock : SwiftCompositeNode, IList<IReadOnlyStatement>
{
    public LeftCurlyBrace LeftCurlyBrace { get; protected set; }

    public IStatementGroup StatementGroup { get; private set; }

    public RightCurlyBrace RightCurlyBrace { get; protected set; }

    internal CodeBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftCurlyBrace leftCurlyBrace, IStatementGroup statementGroup, RightCurlyBrace rightCurlyBrace)
        : base(buffer, children)
    {
        LeftCurlyBrace = leftCurlyBrace;
        StatementGroup = statementGroup;
        RightCurlyBrace = rightCurlyBrace;
    }

    public bool IsEmpty => StatementGroup.IsEmpty;

    public bool HasStatements => StatementGroup.HasStatements;

    public static CodeBlock Create()
    {
        IEditableBuffer buffer = new EditableBuffer(LeftCurlyBrace.Value + RightCurlyBrace.Value);

        LeftCurlyBrace leftCurlyBrace = new(new SubEditableBuffer(buffer, 0, LeftCurlyBrace.Value.Length));
        StatementGroup statementGroup = new(new SubEditableBuffer(buffer, LeftCurlyBrace.Value.Length, 0), [], []);
        RightCurlyBrace rightCurlyBrace = new(new SubEditableBuffer(buffer, LeftCurlyBrace.Value.Length, RightCurlyBrace.Value.Length));

        return new CodeBlock(buffer, [leftCurlyBrace, statementGroup, rightCurlyBrace], leftCurlyBrace, statementGroup, rightCurlyBrace);
    }

    public static CodeBlock Create(IEnumerable<IReadOnlyStatement> statements)
    {
        CodeBlock codeBlock = Create();
        foreach (IReadOnlyStatement statement in statements)
        {
            codeBlock.Add(statement);
        }

        return codeBlock;
    }

    public static CodeBlock Create(IEnumerable<IReadOnlyStatement> statements, int start)
    {
        CodeBlock codeBlock = Create();
        IEnumerator<IReadOnlyStatement> enumerator = statements.GetEnumerator();
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

    public static CodeBlock Create(IEnumerable<IReadOnlyStatement> statements, int start, int end)
    {
        CodeBlock codeBlock = Create();
        IEnumerator<IReadOnlyStatement> enumerator = statements.GetEnumerator();
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

    public static CodeBlock Create(List<IReadOnlyStatement> statements)
    {
        CodeBlock codeBlock = Create();
        foreach (IReadOnlyStatement statement in statements)
        {
            codeBlock.Add(statement);
        }

        return codeBlock;
    }

    public static CodeBlock Create(List<IReadOnlyStatement> statements, int start)
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

    public static CodeBlock Create(List<IReadOnlyStatement> statements, int start, int end)
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

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex)
    {
        CodeBlock codeBlock = Create();
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex,
        IEnumerable<IReadOnlyStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex,
        IEnumerable<IReadOnlyStatement> statements, int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex,
        IEnumerable<IReadOnlyStatement> statements, int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex,
        List<IReadOnlyStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex,
        List<IReadOnlyStatement> statements, int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex,
        List<IReadOnlyStatement> statements, int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex,
        StatementGroup statementGroup)
    {
        CodeBlock codeBlock = Create(statementGroup);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex,
        StatementGroup statementGroup, int startIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsInsertedInto(ISwiftInternalNode<SwiftCompositeNode> parent, int parentIndex,
        StatementGroup statementGroup, int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex, endIndex);
        parent.AttachChild(parentIndex, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent)
    {
        CodeBlock codeBlock = Create();
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent, IEnumerable<IReadOnlyStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent,
        IEnumerable<IReadOnlyStatement> statements, int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent,
        IEnumerable<IReadOnlyStatement> statements, int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent, List<IReadOnlyStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent, List<IReadOnlyStatement> statements,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent, List<IReadOnlyStatement> statements, int startIndex,
        int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent, StatementGroup statementGroup)
    {
        CodeBlock codeBlock = Create(statementGroup);
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent, StatementGroup statementGroup,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex);
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsPrependedTo(ISwiftInternalNode<SwiftCompositeNode> parent, StatementGroup statementGroup,
        int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex, endIndex);
        parent.AttachChild(0, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent)
    {
        CodeBlock codeBlock = Create();
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent, IEnumerable<IReadOnlyStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent, IEnumerable<IReadOnlyStatement> statements,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent, IEnumerable<IReadOnlyStatement> statements,
        int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent, List<IReadOnlyStatement> statements)
    {
        CodeBlock codeBlock = Create(statements);
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent, List<IReadOnlyStatement> statements,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex);
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent, List<IReadOnlyStatement> statements,
        int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statements, startIndex, endIndex);
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent, StatementGroup statementGroup)
    {
        CodeBlock codeBlock = Create(statementGroup);
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent, StatementGroup statementGroup,
        int startIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex);
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    public static CodeBlock CreateAsAppendedTo(ISwiftInternalNode<SwiftCompositeNode> parent, StatementGroup statementGroup,
        int startIndex, int endIndex)
    {
        CodeBlock codeBlock = Create(statementGroup, startIndex, endIndex);
        parent.AttachChild(parent.NumberOfChildren, codeBlock);

        return codeBlock;
    }

    /*
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

        if (child is not IReadOnlyStatement statement)
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
    }*/

    public IEnumerator<IReadOnlyStatement> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(IReadOnlyStatement item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(IReadOnlyStatement item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(IReadOnlyStatement[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(IReadOnlyStatement item)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }

    public bool IsReadOnly { get; }

    public int IndexOf(IReadOnlyStatement item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IReadOnlyStatement item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public new IReadOnlyStatement this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}