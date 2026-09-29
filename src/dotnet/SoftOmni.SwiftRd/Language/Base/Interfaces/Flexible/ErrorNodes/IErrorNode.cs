using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.ErrorNodes;

public interface IErrorNode : INode
{
    // TODO: Add localization
    
    public string GetErrorMessage();
}