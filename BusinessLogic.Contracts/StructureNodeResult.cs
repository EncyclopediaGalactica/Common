namespace EncyclopediaGalactica.BusinessLogic.Contracts;

public class StructureNodeResult
{
    public long Id { get; set; }
    public long DocumentId { get; set; }
    public long ParentId { get; set; }
    public ICollection<StructureNodeResult> StructureNodeResults { get; set; } = new List<StructureNodeResult>();
}