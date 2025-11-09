namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements;

public interface IStatement
{
    public bool CanHaveMultipleOnOneLineSeparatedBySemicolons { get; }
}