using TecLog.Models.Base;

namespace TecLog.Models
{
    public class Usuario : BaseModel
    {
        public int Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

    }
}
