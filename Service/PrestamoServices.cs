using Microsoft.EntityFrameworkCore;
using RalfyGenao_Ap1_P1.DAL;
using RalfyGenao_Ap1_P1.Models;
using System.Linq.Expressions;

namespace RalfyGenao_Ap1_P1.Service
{
    public class PrestamoServices
    {
        private readonly Contexto _contexto;
        public PrestamoServices(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Existe(int PrestamoId)
        {
            return await _contexto.Prestamos.AnyAsync(p => p.PrestamoId == PrestamoId);
        }
        private async Task<bool> Insertar(Prestamo prestamo)
        {
            _contexto.Prestamos.Add(prestamo);
            return await _contexto.SaveChangesAsync() > 0;
        }
        private async Task<bool> Modificar(Prestamo prestamo)
        {
            _contexto.Prestamos.Update(prestamo);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Guardar(Prestamo prestamo)
        {
            if (!await Existe(prestamo.PrestamoId))
                return await Insertar(prestamo);
            else
                return await Modificar(prestamo);
        }
        public async Task<bool> Eliminar(int id)
        {
            var eliminado = await _contexto.Prestamos.Where(P => P.PrestamoId == id).ExecuteDeleteAsync();
            return eliminado > 0;
        }
        public async Task<Prestamo?> Buscar(int id)
        {
            return await _contexto.Prestamos.AsNoTracking().
                  FirstOrDefaultAsync(P => P.PrestamoId == id);
        }
        public async Task<List<Prestamo>> Listar(Expression<Func<Prestamo, bool>> criterio)
        {
            return await _contexto.Prestamos
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();

        }
    }
}

