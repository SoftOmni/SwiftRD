using System;
using System.Linq;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Resources.Shell;
using JetBrains.TestFramework;
using NUnit.Framework;
using ReSharperPlugin.Swift.Language.File;

namespace ReSharperPlugin.Swift.Tests.test.Registration;

[TestFixture]
public class SwiftProjectFileTypeTests : BaseTest
{
    [Test]
    public void SwiftFileTypeIsRegistered()
    {
        Assert.NotNull(SwiftProjectFileType.Instance);

        IProjectFileTypes projectFileTypes = Shell.Instance.GetComponent<IProjectFileTypes>();
        Assert.NotNull(projectFileTypes.GetFileType(SwiftProjectFileType.Name));
    }

    [Test]
    public void SwiftFileTypeFromExtension()
    {
        IProjectFileTypes projectFileTypes = Shell.Instance.GetComponent<IProjectFileTypes>();
        Assert.AreSame(SwiftProjectFileType.Instance, projectFileTypes.GetFileType(SwiftProjectFileType.Name));
    }

    [Test, Explicit]
    public void DumpProjectFileTypes()
    {
        IProjectFileTypes projectFileTypes = Shell.Instance.GetComponent<IProjectFileTypes>();
        foreach (ProjectFileType projectFileType in projectFileTypes.All)
        {
            Console.WriteLine(projectFileType.PresentableName);
        }
    }
}