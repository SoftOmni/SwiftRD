using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

public interface IImportDeclaration : IReadOnlyImportDeclaration,
    IList<IIdentifier>
{
    new IAttributeGroup? Attributes { get; }
    
    new IImportKind? ImportKind { get; }
    
    new IImportPath ImportPath { get; }
    
    new IReadOnlyList<IIdentifier> PathComponents { get; }
    
    new int Count { get; }

    new IEnumerator<IIdentifier> GetEnumerator();
    
    new IIdentifier this[int index] { get; set; }

    void SetAttributesTo(IAttributeGroup? attributeGroupToSet);

    void RemoveAttributes();

    void SetImportKindTo(IImportKind? importKindToSet);

    void RemoveImportKind();

    void ChangeImportPath(IImportPath newImportPath);
}
