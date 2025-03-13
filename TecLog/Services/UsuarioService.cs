using TecLog.Models;
using TecLog.Services.Base;
using System.Text.RegularExpressions;

namespace TecLog.Services;

public class UsuarioService : BaseService<Usuario>
{
    public UsuarioService(TecLogDbContext contexto) : base(contexto)
    {
        
    }

    public async Task<Usuario> BuscaUsuario(string identificacao)
    {
        return _dbSet.FirstOrDefault(x => x.UserName == identificacao || x.Cpf.ToString() == identificacao);
    }


}