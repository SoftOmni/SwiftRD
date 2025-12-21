using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

public class OperatingSystem
{
    private IBuffer _buffer;
    
    public const string MacOsString = "macOS";
    
    // ReSharper disable once InconsistentNaming
    public const string IOsString = "iOS";
    
    public const string WatchOsString = "watchOS";
    
    public const string TvOsString = "tvOS";
    
    public const string VisionOsString = "visionOS";
    
    public const string LinuxString = "Linux";
    
    public const string WindowsString = "Windows";
    
    public OsPlatformCondition? OsPlatformCondition { get; internal set; }

    protected OperatingSystem(IEditableBuffer buffer)
    {
        _buffer = buffer;
    }

    protected OperatingSystem(SwiftInternalNode parent, IEditableBuffer buffer)
    {
        _buffer = buffer;
    }

    public bool IsMacOs => EquatesEquivalentString(MacOsString);

    public bool IsIOs => EquatesEquivalentString(IOsString);

    public bool IsWatchOs => EquatesEquivalentString(WatchOsString);

    public bool IsTvOs => EquatesEquivalentString(TvOsString);

    public bool IsVisionOs => EquatesEquivalentString(VisionOsString);

    public bool IsLinux => EquatesEquivalentString(LinuxString);

    public bool IsWindows => EquatesEquivalentString(WindowsString);

    public static OperatingSystem CreateMacOs()
    {
        return new OperatingSystem(new EditableBuffer(MacOsString));
    }
    
    public static OperatingSystem CreateMacOs(OsPlatformCondition osPlatformCondition)
    {
        return new OperatingSystem(osPlatformCondition, new EditableBuffer(MacOsString));
    }

    internal static OperatingSystem CreateMacOs(SwiftInternalNode parent)
    {
        return new OperatingSystem(parent, new EditableBuffer(MacOsString));
    }

    public static OperatingSystem CreateIOs()
    {
        return new OperatingSystem(new EditableBuffer(IOsString));
    }
    
    public static OperatingSystem CreateIOs(OsPlatformCondition osPlatformCondition)
    {
        return new OperatingSystem(osPlatformCondition, new EditableBuffer(IOsString));
    }

    internal static OperatingSystem CreateIOs(SwiftInternalNode parent)
    {
        return new OperatingSystem(parent, new EditableBuffer(IOsString));
    }

    public static OperatingSystem CreateWatchOs()
    {
        return new OperatingSystem(new EditableBuffer(WatchOsString));
    }
    
    public static OperatingSystem CreateWatchOs(OsPlatformCondition osPlatformCondition)
    {
        return new OperatingSystem(osPlatformCondition, new EditableBuffer(WatchOsString));
    }

    internal static OperatingSystem CreateWatchOs(SwiftInternalNode parent)
    {
        return new OperatingSystem(parent, new EditableBuffer(WatchOsString));
    }

    public static OperatingSystem CreateTvOs()
    {
        return new OperatingSystem(new EditableBuffer(TvOsString));
    }
    
    public static OperatingSystem CreateTvOs(OsPlatformCondition osPlatformCondition)
    {
        return new OperatingSystem(osPlatformCondition, new EditableBuffer(TvOsString));
    }

    internal static OperatingSystem CreateTvOs(SwiftInternalNode parent)
    {
        return new OperatingSystem(parent, new EditableBuffer(TvOsString));
    }

    public static OperatingSystem CreateVisionOs()
    {
        return new OperatingSystem(new EditableBuffer(VisionOsString));
    }
    
    public static OperatingSystem CreateVisionOs(OsPlatformCondition osPlatformCondition)
    {
        return new OperatingSystem(osPlatformCondition, new EditableBuffer(VisionOsString));
    }

    internal static OperatingSystem CreateVisionOs(SwiftInternalNode parent)
    {
        return new OperatingSystem(parent, new EditableBuffer(VisionOsString));
    }

    public static OperatingSystem CreateLinux()
    {
        return new OperatingSystem(new EditableBuffer(LinuxString));
    }
    
    public static OperatingSystem CreateLinux(OsPlatformCondition osPlatformCondition)
    {
        return new OperatingSystem(osPlatformCondition, new EditableBuffer(LinuxString));
    }

    internal static OperatingSystem CreateLinux(SwiftInternalNode parent)
    {
        return new OperatingSystem(parent, new EditableBuffer(LinuxString));
    }

    public static OperatingSystem CreateWindows()
    {
        return new OperatingSystem(new EditableBuffer(WindowsString));
    }
    
    public static OperatingSystem CreateWindows(OsPlatformCondition osPlatformCondition)
    {
        return new OperatingSystem(osPlatformCondition, new EditableBuffer(WindowsString));
    }

    internal static OperatingSystem CreateWindows(SwiftInternalNode parent)
    {
        return new OperatingSystem(parent, new EditableBuffer(WindowsString));
    }
    
    private bool EquatesEquivalentString(string @string)
    {
        if (_buffer.Length != @string.Length)
        {
            return false;
        }

        for (int i = 0; i < @string.Length; i++)
        {
            if (_buffer[i] != @string[i])
            {
                return false;
            }
        }

        return true;
    }
}
