using System;
using System.Numerics;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Targets;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules.Swift.Binary;

public interface IBinaryArtifactTarget : ITarget
{
    Kind BinaryArtifactKind { get; }
    
    Origin BinaryArtifactOrigin { get; }
    
    string? ArtifactUrlRaw { get; }

    Uri? ArtifactUrl { get; }

    public sealed class Kind : IEquatable<Kind>
    {
        public const int UnknownValue = 0;
        
        public const int ArtifactsArchiveValue = 1;

        public const int XcFrameworkValue = 2;
        
        private int Value { get; }

        private Kind(int value)
        {
            Value = value;
        }

        internal static readonly Kind Unknown = new(UnknownValue);
        
        public static readonly Kind ArtifactsArchive = new(ArtifactsArchiveValue);

        public static readonly Kind XcFramework = new(XcFrameworkValue);

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return Value == UnknownValue;
            }
            
            return obj switch
            {
                Kind kind => Equals(kind),
                sbyte value => Value == value,
                byte value => Value == value,
                short value => Value == value,
                ushort value => Value == value,
                int value => Value == value,
                uint value => Value == value,
                long value => Value == value,
                ulong value => (ulong)Value == value,
                BigInteger value => Value == value,
                _ => false
            };
        }

        public bool Equals(Kind other)
        {
            return Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }

    public sealed class Origin : IEquatable<Origin>
    {
        public const int UnknownValue = 0;
        
        public const int LocalValue = 1;

        public const int RemoteValue = 2;
        
        public Uri? Uri { get; }
        
        private int Value { get; }

        private Origin(int value, Uri? uri = null)
        {
            Value = value;
            Uri = uri;
        }

        internal static readonly Origin Unknown = new(UnknownValue);

        public static readonly Origin Local = new(LocalValue);

        public static Origin Remote(Uri uri)
        {
            return new Origin(RemoteValue, uri);
        }
        
        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return Value == UnknownValue;
            }
            
            return obj switch
            {
                Kind kind => Equals(kind),
                sbyte value => Value == value,
                byte value => Value == value,
                short value => Value == value,
                ushort value => Value == value,
                int value => Value == value,
                uint value => Value == value,
                long value => Value == value,
                ulong value => (ulong)Value == value,
                BigInteger value => Value == value,
                _ => false
            };
        }

        public bool Equals(Origin other)
        {
            return Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}