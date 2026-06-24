using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;

[assembly: Apartment(ApartmentState.STA)]

namespace SoftOmni.SwiftRd.Tests
{
    [ZoneDefinition]
    public class SwiftTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<ISwiftZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<SwiftTestEnvironmentZone> { }

    [SetUpFixture]
    public class SwiftTestsAssembly : ExtensionTestEnvironmentAssembly<SwiftTestEnvironmentZone> { }
}
