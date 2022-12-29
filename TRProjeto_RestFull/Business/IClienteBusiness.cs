using System.Collections.Generic;
using TRProjeto_RestFull.Data.VO;

namespace TRProjeto_RestFull.Business
{
    public interface IClienteBusiness
    {
        ClienteVO Create(ClienteVO item);
        ClienteVO Update(ClienteVO item);
        void Delete(long id);
        ClienteVO FiendById(long id);
        List<ClienteVO> FiendAll();
    }
}
