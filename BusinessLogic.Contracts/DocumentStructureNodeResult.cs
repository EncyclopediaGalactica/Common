namespace EncyclopediaGalactica.BusinessLogic.Contracts;

public class DocumentStructureNodeResult
{
    public long Id { get; set; }
    public long DocumentId { get; set; }
    public long ParentId { get; set; }
    public ICollection<DocumentStructureNodeResult> StructureNodeResults { get; set; } = new List<DocumentStructureNodeResult>();
}