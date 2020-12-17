using System.ComponentModel.DataAnnotations;

namespace Tree.WEB.ViewModels
{
    public class NodePostFormViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? NodeParentId { get; set; }
    }
}
