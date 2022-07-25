using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="{0} é obrigatorio" )]
        [StringLength(250)]
        public string? NomeTarefa { get; set;}
    }
}
