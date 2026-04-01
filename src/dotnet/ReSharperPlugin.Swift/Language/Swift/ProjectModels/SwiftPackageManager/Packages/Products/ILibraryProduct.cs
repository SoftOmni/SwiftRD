using System;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Products;

public interface ILibraryProduct : IProduct, IEquatable<ILibraryProduct>
{
    Kind? LibraryKind { get; }
    
    public enum Kind
    {
        Automatic,
        Dynamic,
        Static
    }
}