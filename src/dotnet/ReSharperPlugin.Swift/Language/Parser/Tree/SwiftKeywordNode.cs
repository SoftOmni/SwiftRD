using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

public interface ISwiftKeyword
{
    public string KeywordValue { get; }
}