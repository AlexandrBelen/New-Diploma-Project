using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGruppaService
    {
        Task<OperationDetails> CreateGruppa(GruppaDTO gruppaDTO);
        GruppaDTO FindGruppa(string gruppaName);
        Task<OperationDetails> RemoveGruppa(int gruppaId);
        Task ChangeInformation(GruppaDTO gruppaDTO);
        IEnumerable<GruppaDTO> GetGruppas();
    }
}
