using System;
using JetBrains.Application.UI.Icons.CompiledIcons;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules;

public sealed class ModuleKind : IEquatable<ModuleKind>, IEquatable<string>
{
    public string Name { get; }

    public string Description { get; }

    public AnyCompiledIconClass Icon { get; }

    public static readonly ModuleKind Executable = new ModuleKind("executable", "A module that contains code for an executable's main module",);

    public static readonly ModuleKind Test = new ModuleKind("test", "A module that contains unit tests",);

    public static readonly ModuleKind Generic = new ModuleKind("generic", "A module that contains generic code (not a test nor an executable)",);

    public static readonly ModuleKind Macro = new ModuleKind("macro", "A module that contains code for a macro",);

    public static readonly ModuleKind Snippet = new ModuleKind("snippet", "A module that contains code for a snippet",);

    private ModuleKind(string name, string description, AnyCompiledIconClass icon)
    {
        Name = name;
        Description = description;
        Icon = icon;
    }

    public override bool Equals(object? obj)
    {
        return obj is ModuleKind moduleKind && Equals(moduleKind);
    }

    public bool Equals(ModuleKind other)
    {
        return Name == other.Name;
    }

    public bool Equals(string other)
    {
        return Name == other;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}