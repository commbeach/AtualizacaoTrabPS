using Controle_Manutencao.Repository;
using Gerenciador_Manutencao.Data;
using Gerenciador_Manutencao.Model;

namespace Gerenciador_Manutencao.Repository.Implementacao;

public class EquipamentoRep : IEquipamentoRep
{
    private readonly AppDbContext _context;

    public EquipamentoRep(AppDbContext context)
    {
        _context = context;
    }
}