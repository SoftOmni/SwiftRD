namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

public class Architecture
{
    private IBuffer _buffer;
    
    public const string ArmString = "arm";
    
    public const string Arm64String = "arm64";
    
    public const string I386String = "i386";
    
    public const string Wasm32String = "wasm32";
    
    public const string X8664String = "x8664";
    
    public OsPlatformCondition? OsPlatformCondition { get; internal set; }

    protected Architecture(IEditableBuffer buffer)
    {
        _buffer = buffer;
    }

    protected Architecture(SwiftInternalNode parent, IEditableBuffer buffer)
    {
        _buffer = buffer;
    }

    public bool IsArm => EquatesEquivalentString(ArmString);

    public bool IsArm64 => EquatesEquivalentString(Arm64String);

    public bool IsI386 => EquatesEquivalentString(I386String);

    public bool IsWasm32 => EquatesEquivalentString(Wasm32String);

    public bool IsX8664 => EquatesEquivalentString(X8664String);

    public static Architecture CreateArm()
    {
        return new Architecture(new EditableBuffer(ArmString));
    }
    
    public static Architecture CreateArm(OsPlatformCondition osPlatformCondition)
    {
        return new Architecture(osPlatformCondition, new EditableBuffer(ArmString));
    }

    internal static Architecture CreateArm(SwiftInternalNode parent)
    {
        return new Architecture(parent, new EditableBuffer(ArmString));
    }

    public static Architecture CreateArm64()
    {
        return new Architecture(new EditableBuffer(Arm64String));
    }
    
    public static Architecture CreateArm64(OsPlatformCondition osPlatformCondition)
    {
        return new Architecture(osPlatformCondition, new EditableBuffer(Arm64String));
    }

    internal static Architecture CreateArm64(SwiftInternalNode parent)
    {
        return new Architecture(parent, new EditableBuffer(Arm64String));
    }

    public static Architecture CreateI386()
    {
        return new Architecture(new EditableBuffer(I386String));
    }
    
    public static Architecture CreateI386(OsPlatformCondition osPlatformCondition)
    {
        return new Architecture(osPlatformCondition, new EditableBuffer(I386String));
    }

    internal static Architecture CreateI386(SwiftInternalNode parent)
    {
        return new Architecture(parent, new EditableBuffer(I386String));
    }

    public static Architecture CreateWasm32()
    {
        return new Architecture(new EditableBuffer(Wasm32String));
    }
    
    public static Architecture CreateWasm32(OsPlatformCondition osPlatformCondition)
    {
        return new Architecture(osPlatformCondition, new EditableBuffer(Wasm32String));
    }

    internal static Architecture CreateWasm32(SwiftInternalNode parent)
    {
        return new Architecture(parent, new EditableBuffer(Wasm32String));
    }

    public static Architecture CreateX8664()
    {
        return new Architecture(new EditableBuffer(X8664String));
    }
    
    public static Architecture CreateX8664(OsPlatformCondition osPlatformCondition)
    {
        return new Architecture(osPlatformCondition, new EditableBuffer(X8664String));
    }

    internal static Architecture CreateX8664(SwiftInternalNode parent)
    {
        return new Architecture(parent, new EditableBuffer(X8664String));
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
