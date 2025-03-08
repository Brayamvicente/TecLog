using System.Text.Json.Serialization;
using TecLog.Models.Base;

namespace TecLog.Models
{
    public class Usuario : BaseModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public string Endereco { get; set; }
        public long Telefone { get; set; }

    }
}
