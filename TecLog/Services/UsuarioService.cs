using TecLog.Models;
using TecLog.Services.Base;
using System.Text.RegularExpressions;

namespace TecLog.Services;

public class UsuarioService : BaseService<Usuario>
{
    public UsuarioService(TecLogDbContext contexto) : base(contexto)
    {
        
    }

    public async Task<Usuario> BuscaPorUserName(string userName)
    {
        return _dbSet.FirstOrDefault(x => x.UserName == userName);
    }

    public async Task<Usuario> BuscaPorCpf(int cpf)
    {
        return _dbSet.FirstOrDefault(x => x.Cpf == cpf);
    }
}