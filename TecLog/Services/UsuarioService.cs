using TecLog.Models;
using TecLog.Services.Base;
using System.Text.RegularExpressions;

namespace TecLog.Services;

public class UsuarioService : BaseService<Usuario>
{
    public UsuarioService(TecLogDbContext contexto) : base(contexto)
    {
        
    }

    public async Task<Usuario> BuscaPorCpf(string cpf)
    {
        var cpfFormatado = Regex.Replace(cpf, @"\D", "");
        return _dbSet.FirstOrDefault(x => Regex.Replace(x.Cpf, @"\D", "") == cpfFormatado);
    }
}