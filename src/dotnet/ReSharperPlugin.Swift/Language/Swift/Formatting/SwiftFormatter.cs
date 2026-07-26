using System;
using JetBrains.Application.Settings;
using JetBrains.DataFlow;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CodeStyle;
using JetBrains.ReSharper.Psi.Format;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util;

namespace SoftOmni.SwiftRd.Language.Formatting;

public class SwiftFormatter : ICodeFormatter
{
    public bool IsWhitespaceToken(ITokenNode token)
    {
        throw new NotImplementedException();
    }

    public bool IsWhitespaceToken(ITreeNode node)
    {
        throw new NotImplementedException();
    }

    public bool IsNewLine(ITreeNode ws)
    {
        throw new NotImplementedException();
    }

    public bool IsPureSpace(ITreeNode ws)
    {
        throw new NotImplementedException();
    }

    public bool CanBeMultilineToken(ITreeNode node)
    {
        throw new NotImplementedException();
    }

    public ITreeNode? NextFormattableSibling(ITreeNode node)
    {
        throw new NotImplementedException();
    }

    public ITreeNode? PrevFormattableSibling(ITreeNode node)
    {
        throw new NotImplementedException();
    }

    public FormatSettingsKeyBase GetFormatterSettings(ISolution solution, IPsiSourceFile? sourceFile,
        IContextBoundSettingsStore? settingsStore = null, bool autodetectIndentSettings = true)
    {
        throw new NotImplementedException();
    }

    public IProperty<FormatSettingsKeyBase> GetFormatterSettingsLive(Lifetime lifetime, ISolution solution, IPsiSourceFile sourceFile)
    {
        throw new NotImplementedException();
    }

    public Type GetSettingsKeyType()
    {
        throw new NotImplementedException();
    }

    public void FormatFile(IFile file, CodeFormatProfile profile, AdditionalFormatterParameters? parameters = null)
    {
        throw new NotImplementedException();
    }

    public void Format(ITreeNode root, CodeFormatProfile profile, AdditionalFormatterParameters? parameters = null)
    {
        throw new NotImplementedException();
    }

    public ITreeRange Format(ITreeNode firstElement, ITreeNode lastElement, CodeFormatProfile profile,
        AdditionalFormatterParameters? parameters = null)
    {
        throw new NotImplementedException();
    }

    public void Format(FormatTask[] formatTasks, AdditionalFormatterParameters? parameters = null)
    {
        throw new NotImplementedException();
    }

    public void FormatInsertedNodes(ITreeNode nodeFirst, ITreeNode nodeLast, bool formatSurround, bool indentSurround = false)
    {
        throw new NotImplementedException();
    }

    public ITreeRange FormatInsertedRange(ITreeNode nodeFirst, ITreeNode nodeLast, ITreeRange origin)
    {
        throw new NotImplementedException();
    }

    public void FormatReplacedNode(ITreeNode oldNode, ITreeNode newNode)
    {
        throw new NotImplementedException();
    }

    public void FormatReplacedRange(ITreeNode first, ITreeNode last, ITreeRange oldNodes)
    {
        throw new NotImplementedException();
    }

    public void FormatDeletedNodes(ITreeNode parent, ITreeNode? prevNode, ITreeNode? nextNode)
    {
        throw new NotImplementedException();
    }

    public void FormatTextRange(IFile file, TreeTextRange range, CodeFormatProfile profile,
        OuterSpaceFormatType formatSpacesBefore, OuterSpaceFormatType formatSpacesAfter,
        AdditionalFormatterParameters parameters = null)
    {
        throw new NotImplementedException();
    }

    public void InsertLineFeedAtFileEndIfNeeded(IFile fileNode, IContextBoundSettingsStore? overrideSettingsStore)
    {
        throw new NotImplementedException();
    }

    public Pair<string, FormatterDirectiveType> GetFormatterRegionTypeFromComment(IComment comment)
    {
        throw new NotImplementedException();
    }

    public Pair<string, string> GenerateOverrideComments(Pair<SettingsScalarEntry, object>[] settings, string lineEnding)
    {
        throw new NotImplementedException();
    }

    public bool SupportsFormatterDaemon(IFile fileNode, IContextBoundSettingsStore? overrideSettingsStore)
    {
        throw new NotImplementedException();
    }

    public FileChangeAccu CalculateFormattingChanges(DocumentRangeFormatTask[] formatTasks, IPsiSourceFile sourceFile,
        AdditionalFormatterParameters parameters)
    {
        throw new NotImplementedException();
    }

    public PsiLanguageType LanguageType { get; }
    
    public bool SupportsSettingsTracking { get; }
    
    public bool SupportsAdditionalProfiles { get; }
    
    public bool SupportsWrapping { get; }
    
    public bool SupportsAutoDetect { get; }
    
    public bool SupportsReindenting { get; }
    
    public bool PotentiallySupportsFormatterDaemon { get; }
    
    public bool SupportsFormattingWithAccu { get; }
}