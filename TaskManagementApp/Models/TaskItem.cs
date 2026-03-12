using System.ComponentModel.DataAnnotations;
namespace TaskManagementApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a title.")]
        [StringLength(100,ErrorMessage = "The title cannot exceed 100 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(500,ErrorMessage = "the description cannot exceed 500 characters.")]
        public string Description { get; set; }
        [Display(Name = "Completed")]
        public bool IsCompleted { get; set; }
    }
}
