using System.ComponentModel.DataAnnotations;

namespace Tree.WEB.ViewModels
{
    public class NodeAddFormViewModel
    {
        [Required]
        public string Name { get; set; }
        public int? NodeParentId { get; set; }
    }
}
