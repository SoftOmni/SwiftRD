using System;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Products;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Targets;

public class TargetDependency : IEquatable<TargetDependency>
{
    public IProduct? Product { get; }
    
    public ITarget? Target { get; }

    private TargetDependency(IProduct? product, ITarget? target)
    {
        Product = product;
        Target = target;
    }
    
    public bool IsProductDependency => Product is not null;
    
    public bool IsTargetDependency => Target is not null;

    public static TargetDependency Create(IProduct product)
    {
        return new TargetDependency(product: product, target: null);
    }

    public static TargetDependency Create(ITarget target)
    {
        return new TargetDependency(product: null, target: target);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is TargetDependency targetDependency && Equals(targetDependency);
    }

    public bool Equals(TargetDependency other)
    {
        if (IsProductDependency)
        {
            return Product?.Equals(other.Product) ?? false;
        }
        
        return Target?.Equals(other.Target) ?? false;
    }

    public override int GetHashCode()
    {
        if (IsProductDependency)
        {
            return Product!.GetHashCode();
        }
        
        return Target!.GetHashCode();
    }
}