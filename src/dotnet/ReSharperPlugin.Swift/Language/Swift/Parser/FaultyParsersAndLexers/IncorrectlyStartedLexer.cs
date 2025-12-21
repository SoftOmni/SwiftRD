using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Files;
using JetBrains.ReSharper.Psi.Impl;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.FaultyParsers;

public class IncorrectlyStartedLexer : IParser
{
    public IPsiModule? Module { get; }
    
    public IPsiSourceFile? SourceFile { get; }
    
    public IncorrectlyStartedLexer(IPsiModule? module, IPsiSourceFile? sourceFile)
    {
        Module = module;
        SourceFile = sourceFile;
    }

    public IFile? ParseFile()
    {
        return new IncorrectlyStartedLexerFile(Module, SourceFile);
    }

    public class IncorrectlyStartedLexerFile : IFile
    {
        public IPsiModule? Module { get; }
    
        public IPsiSourceFile? SourceFile { get; }

        public IncorrectlyStartedLexerFile(IPsiModule? module, IPsiSourceFile? sourceFile)
        {
            Module = module;
            SourceFile = sourceFile;
        }

        public IPsiServices GetPsiServices()
        {
            throw new NotImplementedException();
        }

        public IPsiModule GetPsiModule()
        {
            return Module ?? null!;
        }

        public IPsiSourceFile? GetSourceFile()
        {
            return SourceFile ?? null!;
        }

        public ReferenceCollection GetFirstClassReferences()
        {
            throw new NotImplementedException();
        }

        public void ProcessDescendantsForResolve(IRecursiveElementProcessor processor)
        {
            throw new NotImplementedException();
        }

        public TTreeNode? GetContainingNode<TTreeNode>(bool returnThis = false) where TTreeNode : ITreeNode
        {
            throw new NotImplementedException();
        }

        public bool Contains(ITreeNode other)
        {
            throw new NotImplementedException();
        }

        public bool IsPhysical()
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public bool IsFiltered()
        {
            throw new NotImplementedException();
        }

        public DocumentRange GetNavigationRange()
        {
            throw new NotImplementedException();
        }

        public TreeOffset GetTreeStartOffset()
        {
            throw new NotImplementedException();
        }

        public int GetTextLength()
        {
            throw new NotImplementedException();
        }

        public StringBuilder GetText(StringBuilder to)
        {
            throw new NotImplementedException();
        }

        public IBuffer GetTextAsBuffer()
        {
            throw new NotImplementedException();
        }

        public string GetText()
        {
            throw new NotImplementedException();
        }

        public ITreeNode? FindNodeAt(TreeTextRange treeRange)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<ITreeNode> FindNodesAt(TreeOffset treeOffset)
        {
            throw new NotImplementedException();
        }

        public ITreeNode? FindTokenAt(TreeOffset treeTextOffset)
        {
            throw new NotImplementedException();
        }

        public ITreeNode? Parent { get; }
        public ITreeNode? FirstChild { get; }
        public ITreeNode? LastChild { get; }
        public ITreeNode? NextSibling { get; }
        public ITreeNode? PrevSibling { get; }
        public NodeType NodeType { get; }
        public PsiLanguageType Language { get; }
        public NodeUserData UserData { get; }
        public NodeUserData PersistentUserData { get; }
        public IFile? ReParse(TreeTextRange modifiedRange, string text)
        {
            throw new NotImplementedException();
        }

        public PsiFileModificationInfo? GetReParseResult(TreeTextRange modifiedRange, string text)
        {
            throw new NotImplementedException();
        }

        public bool IsInjected()
        {
            throw new NotImplementedException();
        }

        public CachingLexer CachingLexer { get; }
        public int ModificationCounter { get; }
        public bool CanContainCaseInsensitiveReferences { get; }
    }
}