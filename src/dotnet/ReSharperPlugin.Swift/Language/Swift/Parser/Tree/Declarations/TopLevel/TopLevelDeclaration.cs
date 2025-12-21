using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Files;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.StatementGroups;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.TopLevel;

public class TopLevelDeclaration : SwiftInternalNode, IFile
{
    public bool HasExecutableCode { get; private set; }
    
    public bool IsAllowedExecutableCode { get; internal set; }
    
    public StatementGroup? StatementGroup { get; private set; }
    
    private List<StatementInternalNode> _statements = [];

    private List<Declaration> _declarations = [];
    
    internal TopLevelDeclaration(IEditableBuffer buffer, List<ISwiftNode> children) : base(buffer, children)
    { }

    internal TopLevelDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) : base(buffer, children)
    { }

    public override NodeType NodeType { get; }

    public IReadOnlyList<StatementInternalNode> Statements => _statements;

    public IReadOnlyList<Declaration> Declarations => _declarations;
    
    public IFile? ReParse(TreeTextRange modifiedRange, string text)
    {
        throw new System.NotImplementedException();
    }

    public PsiFileModificationInfo? GetReParseResult(TreeTextRange modifiedRange, string text)
    {
        throw new System.NotImplementedException();
    }

    public bool IsInjected()
    {
        throw new System.NotImplementedException();
    }
    
    public CachingLexer CachingLexer { get; }
    
    public int ModificationCounter { get; }
    
    public bool CanContainCaseInsensitiveReferences { get; }

    protected override SwiftInternalNode Duplicate()
    {
        throw new System.NotImplementedException();
    }

    protected override SwiftInternalNode DuplicateWithoutChildren()
    {
        throw new System.NotImplementedException();
    }

    public static TopLevelDeclaration Parse(SwiftLexer lexer)
    {
        throw new NotImplementedException();
    }
}