using Microsoft.EntityFrameworkCore;
using RalfyGenao_Ap1_P1.DAL;
using RalfyGenao_Ap1_P1.Models;
using System.Linq.Expressions;

namespace RalfyGenao_Ap1_P1.Service
{
    public class DeudorService
    {
        private readonly Contexto _contexto;
        public DeudorService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Existe(int DeudorId)
        {
            return await _contexto.Deudor.AnyAsync(p => p.DeudorId == DeudorId);
        }
        private async Task<bool> Insertar(Deudor deudor)
        {
            _contexto.Deudor.Add(deudor);
            return await _contexto.SaveChangesAsync() > 0;
        }
        private async Task<bool> Modificar(Deudor deudor)
        {
            _contexto.Deudor.Update(deudor);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Guardar(Deudor deudor)
        {
            if (!await Existe(deudor.DeudorId))
                return await Insertar(deudor);
            else
                return await Modificar(deudor);
        }
        public async Task<bool> Eliminar(int id)
        {
            var eliminado = await _contexto.Deudor.Where(D => D.DeudorId == id).ExecuteDeleteAsync();
            return eliminado > 0;
        }
        public async Task<Deudor?> Buscar(int id)
        {
            return await _contexto.Deudor.AsNoTracking().
                  FirstOrDefaultAsync(D => D.DeudorId == id);
        }
        public async Task<List<Deudor>> Listar(Expression<Func<Deudor, bool>> criterio)
        {
            return await _contexto.Deudor
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

    }
}
