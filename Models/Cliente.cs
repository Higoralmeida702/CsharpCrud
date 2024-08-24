using System.ComponentModel.DataAnnotations;

namespace CsharpCrud.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Digite o nome do cliente")]
        public String Nome { get; set; }

        [Required (ErrorMessage = "Digite o email do cliente")]
        public String Email { get; set; }

        [Required (ErrorMessage = "Preencha corretamente o número de telefone!")]
        [Phone (ErrorMessage = "O celular informado não é valido!")]
        public String Telefone { get; set; }
    }
}
