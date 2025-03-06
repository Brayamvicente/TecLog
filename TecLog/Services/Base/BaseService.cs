using System.Globalization;
using Microsoft.EntityFrameworkCore;
using TecLog.Models;
using TecLog.Models.Base;

namespace TecLog.Services.Base;

public class BaseService<T> where T : BaseModel
{
    protected readonly TecLogDbContext _dbContext;
    protected readonly DbSet<T> _dbSet;
    public BaseService(TecLogDbContext contexto)
    {
        _dbContext = contexto;
        _dbSet = contexto.Set<T>();
    }

    public async Task<T> BuscaPorId(int Id )
    {
        return await _dbSet.FindAsync(Id);
    }
    
    public async Task<bool> Criar( T entity )
    { 
        try
        {
            _dbSet.Add(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
    
    public async Task<bool> Atualiza( T entity )
    {
        try
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
        
    }

    public async Task<bool> Deleta(int Id)
    {
        try
        {
            var entity = await BuscaPorId(Id);
            if (entity == null) return true;

            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}