namespace WebApplicationahmad1.Models.Node
{
    public class Node
    {
        //Comment
        public int NodeId { get; set; }
        public string NodeName { get; set; }
        public int? ParentNodeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
    }
}
