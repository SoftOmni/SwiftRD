using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Files;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Products;
using SoftOmni.SwiftRd.Language.Swift.Semantics.Context;
using SoftOmni.SwiftRd.Resources.Icons.Language;
using IStatement = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.IStatement;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;

public class TopLevelDeclaration : SwiftCompositeNode, IFile, ITopLevelDeclaration
{
    public bool HasExecutableCode { get; private set; }

    public bool IsAllowedExecutableCode { get; internal set; }

    public IStatementGroup Statements { get; }

    internal readonly List<IExecutableProduct> UnderlyingExecutableProductsWhichAllowExecutableCode;

    internal readonly LocalSwiftSemanticalContext UnderlyingLocalFileSemanticalContext;

    internal TopLevelDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IStatementGroup statements)
        : base(buffer, children)
    {
        Statements = statements;

        CachingLexer = null!;
        ModificationCounter = 0;

        Icon = SwiftIcons.ConstantIcon;
        UnderlyingExecutableProductsWhichAllowExecutableCode = [];

        UnderlyingLocalFileSemanticalContext = new LocalSwiftSemanticalContext();
    }

    public AnyCompiledIconClass Icon { get; }

    IReadOnlyStatementGroup IReadOnlyTopLevelDeclaration.Statements => Statements;

    public IReadOnlyList<IStatement> StatementsAsList => Statements.Statements;

    public IReadOnlyList<IExecutableProduct> ExecutableProductsWhichAllowExecutableCode =>
        UnderlyingExecutableProductsWhichAllowExecutableCode;

    IReadOnlyList<IReadOnlyStatement> IReadOnlyTopLevelDeclaration.StatementsAsList => StatementsAsList;

    public ILocalSwiftSemanticalContext LocalFileSemanticalContext => UnderlyingLocalFileSemanticalContext;

    IReadOnlyLocalSwiftSemanticalContext IReadOnlyTopLevelDeclaration.LocalFileSemanticalContext =>
        LocalFileSemanticalContext;

    public int Count => Statements.Count;

    public bool IsReadOnly => false;

    public PsiFileModificationInfo? GetReParseResult(TreeTextRange modifiedRange, string text)
    {
        throw new NotImplementedException();
    }

    public IFile? ReParse(TreeTextRange modifiedRange, string text)
    {
        throw new NotImplementedException();
    }

    public bool IsInjected()
    {
        throw new NotImplementedException();
    }

    public CachingLexer CachingLexer { get; }

    public int ModificationCounter { get; }

    public bool CanContainCaseInsensitiveReferences => false;

    public new IStatement this[int index]
    {
        get => Statements[index];
        set => Statements[index] = value;
    }

    IReadOnlyStatement IReadOnlyList<IReadOnlyStatement>.this[int index]
        => Statements[index];

    public IEnumerator<IStatement> GetEnumerator()
    {
        return Statements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyStatement> IEnumerable<IReadOnlyStatement>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IStatement item)
    {
        return Statements.Contains(item);
    }

    public int IndexOf(IStatement item)
    {
        return Statements.IndexOf(item);
    }

    public void CopyTo(IStatement[] array, int arrayIndex)
    {
        Statements.CopyTo(array, arrayIndex);
    }

    public void Add(IStatement item)
    {
        Statements.Add(item);
    }

    public void Clear()
    {
        Statements.Clear();
    }

    public bool Remove(IStatement item)
    {
        return Statements.Remove(item);
    }

    public void Insert(int index, IStatement item)
    {
        Statements.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        Statements.RemoveAt(index);
    }

    public void ChangeStatements(IStatementGroup newStatements)
    {
        throw new NotImplementedException();
    }
}
