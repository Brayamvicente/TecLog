using TecLog.Models;

namespace TecLog.Services.Base;

public class BaseService
{
    private readonly TecLogDbContext _dbContext;
    
    public BaseService(TecLogDbContext contexto)
    {
        _dbContext = contexto;
    }
}