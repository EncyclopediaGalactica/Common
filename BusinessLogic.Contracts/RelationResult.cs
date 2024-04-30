namespace EncyclopediaGalactica.BusinessLogic.Contracts;

/// <summary>
///
/// </summary>
public class RelationResult
{
    public long Id { get; set; }
    public DocumentResult LeftDocument { get; set; }
    public long LeftDocumentId { get; set; }
    public DocumentResult RightDocument { get; set; }
    public long RightDocumentId { get; set; }
    public RelationTypeResult RelationType { get; set; }
    public long RelationTypeId { get; set; }
}
