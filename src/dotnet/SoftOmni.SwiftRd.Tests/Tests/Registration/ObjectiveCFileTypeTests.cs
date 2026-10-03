using System;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Resources.Shell;
using JetBrains.TestFramework;
using NUnit.Framework;
using SoftOmni.SwiftRd.Language.ObjectiveC.File;

namespace SoftOmni.SwiftRd.Tests.Tests.Registration;

[TestFixture]
public class ObjectiveCFileTypeTests : BaseTest
{
    [Test]
    public void ObjectiveCFileTypeIsRegistered()
    {
        Assert.NotNull(ObjectiveCFileType.Instance);

        IProjectFileTypes projectFileTypes = Shell.Instance.GetComponent<IProjectFileTypes>();
        Assert.NotNull(projectFileTypes.GetFileType(ObjectiveCFileType.Name));
    }

    [Test]
    public void ObjectiveCFileTypeFromExtension()
    {
        IProjectFileTypes projectFileTypes = Shell.Instance.GetComponent<IProjectFileTypes>();
        Assert.AreSame(ObjectiveCFileType.Instance, projectFileTypes.GetFileType(ObjectiveCFileType.Name));
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