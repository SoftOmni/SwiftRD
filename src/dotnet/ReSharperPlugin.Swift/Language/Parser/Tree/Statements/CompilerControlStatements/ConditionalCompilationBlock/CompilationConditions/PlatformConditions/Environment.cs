using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions;

public class Environment
{
    private IBuffer _buffer;
    
    public const string SimulatorString = "simulator";

    public const string MacCatalystString = "macCatalyst";

    public OsPlatformCondition? OsPlatformCondition { get; internal set; }

    protected Environment(IEditableBuffer buffer)
    {
        _buffer = buffer;
    }

    protected Environment(ISwiftNode parent, IEditableBuffer buffer)
    {
        _buffer = buffer;
    }

    public bool IsSimulator => EquatesEquivalentString(SimulatorString);

    public bool IsMacCatalyst => EquatesEquivalentString(MacCatalystString);

    public static Environment CreateSimulator()
    {
        return new Environment(new EditableBuffer(SimulatorString));
    }

    public static Environment CreateSimulator(OsPlatformCondition osPlatformCondition)
    {
        return new Environment(osPlatformCondition, new EditableBuffer(SimulatorString));
    }

    internal static Environment CreateSimulator(ISwiftNode parent)
    {
        return new Environment(parent, new EditableBuffer(SimulatorString));
    }

    public static Environment CreateMacCatalyst()
    {
        return new Environment(new EditableBuffer(MacCatalystString));
    }

    public static Environment CreateMacCatalyst(OsPlatformCondition osPlatformCondition)
    {
        return new Environment(osPlatformCondition, new EditableBuffer(MacCatalystString));
    }

    internal static Environment CreateMacCatalyst(ISwiftNode parent)
    {
        return new Environment(parent, new EditableBuffer(MacCatalystString));
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