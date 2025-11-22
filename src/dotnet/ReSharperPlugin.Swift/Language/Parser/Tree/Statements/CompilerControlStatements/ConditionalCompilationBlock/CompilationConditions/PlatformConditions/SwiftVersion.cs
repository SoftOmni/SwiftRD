using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions;

public class SwiftVersion : SwiftInternalNode, IComparable<SwiftVersion>, IReadOnlyCollection<BigInteger> // TODO: Review
{
    private List<BigInteger> _parts = [];

    private List<IntegerLiteral> _partChildren = [];

    private List<Period> _periods = [];

    internal SwiftVersion(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    internal SwiftVersion(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    internal SwiftVersion(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    internal SwiftVersion(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<BigInteger> Parts => _parts;

    public IReadOnlyList<IntegerLiteral> Literals => _partChildren;
    
    public int CompareTo(SwiftVersion other)
    {
        const int less = -1;
        const int equals = 0;
        const int greater = 1;

        int target;
        int maxLength;

        if (Parts.Count < other.Parts.Count)
        {
            target = Parts.Count;
            maxLength = other.Parts.Count;
        }
        else
        {
            target = other.Parts.Count;
            maxLength = Parts.Count;
        }

        int index = 0;
        while (index < target && Parts[index] == other.Parts[index])
        {
            index++;
        }

        if (index != target)
        {
            return Parts[index].CompareTo(other.Parts[index]);
        }

        if (maxLength > target)
        {
            return Parts.Count < other.Parts.Count ? less : greater;
        }

        return equals;
    }

    /*public int CompareTo(Version version)
    { }

    public int CompareTo(IEnumerable<BigInteger> version)
    { }

    public int CompareTo(IEnumerable<IntegerLiteral> version)
    { }*/

    public static bool operator <(SwiftVersion left, SwiftVersion right)
    {
        return Compare(left._parts, right._parts, (leftBigInt, rightBigInt) => leftBigInt < rightBigInt);
    }

    public static bool operator <(SwiftVersion left, Version right)
    {
        return Compare(left._parts, GetVersionEnumerator(right),
            (leftBigInt, rightBigInt) => leftBigInt < rightBigInt);
    }

    public static bool operator <(Version left, SwiftVersion right)
    {
        return Compare(GetVersionEnumerator(left), right._parts,
            (leftBigInt, rightBigInt) => leftBigInt < rightBigInt);
    }

    public static bool operator <(SwiftVersion left, IEnumerable<BigInteger> right)
    {
        return Compare(left._parts, right, (leftBigInt, rightBigInt) => leftBigInt < rightBigInt);
    }

    public static bool operator <(IEnumerable<BigInteger> left, SwiftVersion right)
    {
        return Compare(left, right._parts, (leftBigInt, rightBigInt) => leftBigInt < rightBigInt);
    }

    /*public static bool operator <(SwiftVersion left, IEnumerable<IntegerLiteral> right)
    {
        return Compare(left._parts, right, (leftBigInt, rightBigInt) => leftBigInt < rightBigInt);
    }

    public static bool operator <(IEnumerable<IntegerLiteral> left, SwiftVersion right)
    {
        return Compare(left, right._parts, (leftBigInt, rightBigInt) => leftBigInt < rightBigInt);
    }*/

    public static bool operator <=(SwiftVersion left, SwiftVersion right)
    {
        return Compare(left._parts, right._parts, (leftBigInt, rightBigInt) => leftBigInt < rightBigInt);
    }

    /*public static bool operator <=(SwiftVersion left, Version right)
    {
        return Compare(left._parts, right.GetVersionEnumerator(),
            (leftBigInt, rightBigInt) => leftBigInt <= rightBigInt);
    }

    public static bool operator <=(Version left, SwiftVersion right)
    {
        return Compare(left.GetVersionEnumerator(), right._parts,
            (leftBigInt, rightBigInt) => leftBigInt <= rightBigInt);
    }*/

    public static bool operator <=(SwiftVersion left, IEnumerable<BigInteger> right)
    {
        return Compare(left._parts, right, (leftBigInt, rightBigInt) => leftBigInt <= rightBigInt);
    }

    public static bool operator <=(IEnumerable<BigInteger> left, SwiftVersion right)
    {
        return Compare(left, right._parts, (leftBigInt, rightBigInt) => leftBigInt <= rightBigInt);
    }

    /*public static bool operator <=(SwiftVersion left, IEnumerable<IntegerLiteral> right)
    {
        return Compare(left._parts, right, (leftBigInt, rightBigInt) => leftBigInt <= rightBigInt);
    }

    public static bool operator <=(IEnumerable<IntegerLiteral> left, SwiftVersion right)
    {
        return Compare(left, right._parts, (leftBigInt, rightBigInt) => leftBigInt <= rightBigInt);
    }*/

    public static bool operator ==(SwiftVersion left, SwiftVersion right)
    {
        return Equals(left._parts, right._parts);
    }

    public static bool operator ==(Version left, SwiftVersion right)
    {
        return Equals(GetVersionEnumerator(left), right._parts);
    }

    public static bool operator ==(SwiftVersion left, Version right)
    {
        return Equals(left._parts, GetVersionEnumerator(right));
    }

    public static bool operator ==(SwiftVersion left, IEnumerable<BigInteger> right)
    {
        return Equals(left._parts, right);
    }

    public static bool operator ==(IEnumerable<BigInteger> left, SwiftVersion right)
    {
        return Equals(left, right._parts);
    }

    public static bool operator ==(SwiftVersion left, IEnumerable<IntegerLiteral> right)
    {
        return Equals(left._parts, right);
    }

    public static bool operator ==(IEnumerable<IntegerLiteral> left, SwiftVersion right)
    {
        return Equals(left, right._parts);
    }

    public static bool operator >(SwiftVersion left, SwiftVersion right)
    {
        return Compare(left._parts, right._parts, (leftBigInt, rightBigInt) => leftBigInt > rightBigInt);
    }

    public static bool operator >(SwiftVersion left, Version right)
    {
        return Compare(left._parts, GetVersionEnumerator(right),
            (leftBigInt, rightBigInt) => leftBigInt > rightBigInt);
    }

    public static bool operator >(Version left, SwiftVersion right)
    {
        return Compare(GetVersionEnumerator(left), right._parts,
            (leftBigInt, rightBigInt) => leftBigInt > rightBigInt);
    }

    public static bool operator >(SwiftVersion left, IEnumerable<BigInteger> right)
    {
        return Compare(left._parts, right, (leftBigInt, rightBigInt) => leftBigInt > rightBigInt);
    }

    public static bool operator >(IEnumerable<BigInteger> left, SwiftVersion right)
    {
        return Compare(left, right._parts, (leftBigInt, rightBigInt) => leftBigInt > rightBigInt);
    }

    /*public static bool operator >(SwiftVersion left, IEnumerable<IntegerLiteral> right)
    {
        return Compare(left._parts, right, (leftBigInt, rightBigInt) => leftBigInt > rightBigInt);
    }

    public static bool operator >(IEnumerable<IntegerLiteral> left, SwiftVersion right)
    {
        return Compare(left, right._parts, (leftBigInt, rightBigInt) => leftBigInt > rightBigInt);
    }*/

    public static bool operator >=(SwiftVersion left, SwiftVersion right)
    {
        return Compare(left._parts, right._parts, (leftBigInt, rightBigInt) => leftBigInt > rightBigInt);
    }

    /*public static bool operator >=(SwiftVersion left, Version right)
    {
        return Compare(left._parts, right.GetVersionEnumerator(),
            (leftBigInt, rightBigInt) => leftBigInt >= rightBigInt);
    }

    public static bool operator >=(Version left, SwiftVersion right)
    {
        return Compare(left.GetVersionEnumerator(), right._parts,
            (leftBigInt, rightBigInt) => leftBigInt >= rightBigInt);
    }*/

    public static bool operator >=(SwiftVersion left, IEnumerable<BigInteger> right)
    {
        return Compare(left._parts, right, (leftBigInt, rightBigInt) => leftBigInt >= rightBigInt);
    }

    public static bool operator >=(IEnumerable<BigInteger> left, SwiftVersion right)
    {
        return Compare(left, right._parts, (leftBigInt, rightBigInt) => leftBigInt >= rightBigInt);
    }

    /*public static bool operator >=(SwiftVersion left, IEnumerable<IntegerLiteral> right)
    {
        return Compare(left._parts, right, (leftBigInt, rightBigInt) => leftBigInt >= rightBigInt);
    }

    public static bool operator >=(IEnumerable<IntegerLiteral> left, SwiftVersion right)
    {
        return Compare(left, right._parts, (leftBigInt, rightBigInt) => leftBigInt >= rightBigInt);
    }*/

    public static bool operator !=(SwiftVersion left, SwiftVersion right)
    {
        return !Equals(left._parts, right._parts);
    }

    public static bool operator !=(Version left, SwiftVersion right)
    {
        return !Equals(GetVersionEnumerator(left), right._parts);
    }

    public static bool operator !=(SwiftVersion left, Version right)
    {
        return !Equals(left._parts, GetVersionEnumerator(right));
    }

    public static bool operator !=(SwiftVersion left, IEnumerable<BigInteger> right)
    {
        return !Equals(left._parts, right);
    }

    public static bool operator !=(IEnumerable<BigInteger> left, SwiftVersion right)
    {
        return !Equals(left, right._parts);
    }

    public static bool operator !=(SwiftVersion left, IEnumerable<IntegerLiteral> right)
    {
        return !Equals(left._parts, right);
    }

    public static bool operator !=(IEnumerable<IntegerLiteral> left, SwiftVersion right)
    {
        return !Equals(left, right._parts);
    }

    private static bool Compare(IEnumerable<BigInteger> left, IEnumerable<BigInteger> right,
        Func<BigInteger, BigInteger, bool> comparer)
    {
        IEnumerator<BigInteger> leftEnumerator = left.GetEnumerator();
        IEnumerator<BigInteger> rightEnumerator = right.GetEnumerator();

        bool isLeftDone = leftEnumerator.MoveNext();
        bool isRightDone = rightEnumerator.MoveNext();

        while (!isLeftDone && !isRightDone && leftEnumerator.Current == rightEnumerator.Current)
        {
            isLeftDone = leftEnumerator.MoveNext();
            isRightDone = rightEnumerator.MoveNext();
        }

        BigInteger leftValue = isLeftDone ? BigInteger.Zero : leftEnumerator.Current;
        BigInteger rightValue = isRightDone ? BigInteger.Zero : rightEnumerator.Current;

        bool value = comparer(leftValue, rightValue);

        leftEnumerator.Dispose();
        rightEnumerator.Dispose();

        return value;
    }

    private static bool Equals(IEnumerable<BigInteger> left, IEnumerable<BigInteger> right)
    {
        IEnumerator<BigInteger> leftEnumerator = left.GetEnumerator();
        IEnumerator<BigInteger> rightEnumerator = right.GetEnumerator();

        bool isLeftDone = leftEnumerator.MoveNext();
        bool isRightDone = rightEnumerator.MoveNext();

        while (!isLeftDone && !isRightDone && leftEnumerator.Current == rightEnumerator.Current)
        {
            isLeftDone = leftEnumerator.MoveNext();
            isRightDone = rightEnumerator.MoveNext();
        }

        bool value = isLeftDone && isRightDone;

        leftEnumerator.Dispose();
        rightEnumerator.Dispose();

        return value;
    }

    public IEnumerator<BigInteger> GetEnumerator()
    {
        return _parts.GetEnumerator();
    }

    public override bool Equals(object? obj)
    {
        return obj switch
        {
            SwiftVersion version => this == version,
            Version version => this == version,
            IEnumerable<IntegerLiteral> version => this == version,
            IEnumerable<BigInteger> version => this == version,
            _ => base.Equals(obj) // TODO: implement Swift Node equality members
        };
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), _parts.GetHashCode()); // TODO: implement Swift Node hashcode
    }

    public BigInteger GetValueAt(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return index < _parts.Count ? _parts[index] : BigInteger.Zero;
    }

    /*public IntegerLiteral GetIntegerAt()
    { }*/

    public void SetValue(BigInteger value)
    { }

    public void SetValue(IntegerLiteral value)
    { }

    public void SetValueAt(int index, BigInteger value)
    { }

    public void SetValueAt(int index, IntegerLiteral value)
    { }

    public void SetValuesAt(int index, IEnumerable<BigInteger> values)
    { }

    public void SetValuesAt(int index, IEnumerable<BigInteger> values, int start, int count)
    { }

    public void SetValuesAt(int index, IEnumerable<IntegerLiteral> values)
    { }

    public void SetValuesAt(int index, IEnumerable<IntegerLiteral> values, int start, int count)
    { }

    /*public BigInteger[] ReplaceValuesAt(int index, IEnumerable<BigInteger> values)
    { }

    public BigInteger[] ReplaceValuesAt(int index, IEnumerable<BigInteger> values, int start, int count)
    { }

    public IntegerLiteral[] ReplaceValuesAt(int index, IEnumerable<IntegerLiteral> values)
    { }

    public IntegerLiteral[] ReplaceValuesAt(int index, IEnumerable<IntegerLiteral> values, int start, int count)
    { }*/

    public void AppendValues(IEnumerable<BigInteger> values)
    { }

    public void AppendValues(IEnumerable<BigInteger> values, int start, int count)
    { }

    public void AppendValues(IEnumerable<IntegerLiteral> values)
    { }

    public void AppendValues(IEnumerable<IntegerLiteral> values, int start, int count)
    { }

    public void PrependValues(IEnumerable<BigInteger> values)
    { }

    public void PrependValues(IEnumerable<BigInteger> values, int start, int count)
    { }

    public void PrependValues(IEnumerable<IntegerLiteral> values)
    { }

    public void PrependValues(IEnumerable<IntegerLiteral> values, int start, int count)
    { }

    public void InsertValuesAt(int index, IEnumerable<BigInteger> values)
    { }

    public void InsertValuesAt(int index, IEnumerable<BigInteger> values, int start, int count)
    { }

    public void InsertValuesAt(int index, IEnumerable<IntegerLiteral> values)
    { }

    public void InsertValuesAt(int index, IEnumerable<IntegerLiteral> values, int start, int count)
    { }

    public void ClearValue()
    { }

    public Version ToVersion(VersionConversionMode versionConversionMode = VersionConversionMode.ConcatenateAndDowncast)
    {
        BigInteger maxInt = int.MaxValue;
        if (versionConversionMode.IsConcatenate())
        {
            if (versionConversionMode is VersionConversionMode.ConcatenateAndDowncast)
            {
                return NumberOfParts switch
                {
                    0 => new Version(),
                    1 => new Version(major: (int)_parts[0], minor: 0),
                    2 => new Version((int)_parts[0], (int)_parts[1]),
                    3 => new Version((int)_parts[0], (int)_parts[1], (int)_parts[2]),
                    _ => new Version((int)_parts[0], (int)_parts[1], (int)_parts[2], (int)_parts[3])
                };
            }
            
            return NumberOfParts switch
            {
                0 => new Version(),
                1 => new Version(major: CheckInt(_parts[0]), minor: 0),
                2 => new Version(CheckInt(_parts[0]), CheckInt(_parts[1])),
                3 => new Version(CheckInt(_parts[0]), CheckInt(_parts[1]), CheckInt(_parts[2])),
                _ => new Version(CheckInt(_parts[0]), CheckInt(_parts[1]), CheckInt(_parts[2]), CheckInt(_parts[3]))
            };
        }
        
        if (NumberOfParts > 4)
        {
            throw new VersionTooManyPartsInConversion(versionConversionMode);
        }
        
        if (versionConversionMode is VersionConversionMode.AllowOnlyFullAndDowncast)
        {
            return NumberOfParts switch
            {
                0 => new Version(),
                1 => new Version(major: (int)_parts[0], minor: 0),
                2 => new Version((int)_parts[0], (int)_parts[1]),
                3 => new Version((int)_parts[0], (int)_parts[1], (int)_parts[2]),
                _ => new Version((int)_parts[0], (int)_parts[1], (int)_parts[2], (int)_parts[3])
            };
        }
            
        return NumberOfParts switch
        {
            0 => new Version(),
            1 => new Version(major: CheckInt(_parts[0]), minor: 0),
            2 => new Version(CheckInt(_parts[0]), CheckInt(_parts[1])),
            3 => new Version(CheckInt(_parts[0]), CheckInt(_parts[1]), CheckInt(_parts[2])),
            _ => new Version(CheckInt(_parts[0]), CheckInt(_parts[1]), CheckInt(_parts[2]), CheckInt(_parts[3]))
        };

        int CheckInt(BigInteger value)
        {
            if (value > maxInt)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return (int)value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int NumberOfParts => _parts.Count;

    public int Count => _parts.Count;

    public enum VersionConversionMode
    {
        ConcatenateAndDowncast,
        ConcatenateAndIntWithinBounds,
        AllowOnlyFullAndDowncast,
        AllowOnlyFullAndIntWithBounds
    }
    
    public class VersionTooManyPartsInConversion(VersionConversionMode versionConversionMode) : Exception("The version cannot be converted into a Systems.Version " +
                                                               "object because there are more than 4 fields and the " +
                                                               $"parameters disallow concatenating to only the first 4 fields (value passed: {versionConversionMode.ToString()}");
    
    public static IEnumerable<BigInteger> GetVersionEnumerator(Version version)
    {
        if (version.Revision != 0)
        {
            BigInteger major = version.Major;
            BigInteger minor = version.Minor;

            BigInteger build = version.Build;
            BigInteger revision = version.Revision;

            return [major, minor, build, revision];
        }

        if (version.Build != 0)
        {
            BigInteger major = version.Major;
            BigInteger minor = version.Minor;

            BigInteger build = version.Build;

            return [major, minor, build];
        }

        if (version.Minor != 0)
        {
            BigInteger major = version.Major;
            BigInteger minor = version.Minor;

            return [major, minor];
        }

        if (version.Major != 0)
        {
            BigInteger major = version.Major;
            return [major];
        }

        return [];
    }
}

public static class VersionExtensions
{
    

    public static bool IsDowncast(this SwiftVersion.VersionConversionMode versionConversionMode)
    {
        return versionConversionMode is SwiftVersion.VersionConversionMode.AllowOnlyFullAndDowncast
            or SwiftVersion.VersionConversionMode.ConcatenateAndDowncast;
    }

    public static bool IsConcatenate(this SwiftVersion.VersionConversionMode versionConversionMode)
    {
        return versionConversionMode is SwiftVersion.VersionConversionMode.ConcatenateAndIntWithinBounds
            or SwiftVersion.VersionConversionMode.ConcatenateAndDowncast;
    }

    public static bool IsOnlyFullAllowed(this SwiftVersion.VersionConversionMode versionConversionMode)
    {
        return versionConversionMode is SwiftVersion.VersionConversionMode.AllowOnlyFullAndDowncast
            or SwiftVersion.VersionConversionMode.AllowOnlyFullAndIntWithBounds;
    }

    public static bool IsOnlyWithinIntBoundsAllowed(this SwiftVersion.VersionConversionMode versionConversionMode)
    {
        return versionConversionMode is SwiftVersion.VersionConversionMode.AllowOnlyFullAndIntWithBounds or
            SwiftVersion.VersionConversionMode.ConcatenateAndIntWithinBounds;
    }
}