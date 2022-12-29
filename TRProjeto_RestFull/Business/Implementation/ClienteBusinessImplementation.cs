using System.Collections.Generic;
using TRProjeto_RestFull.Data.Converter.Implementation;
using TRProjeto_RestFull.Data.VO;
using TRProjeto_RestFull.Model;
using TRProjeto_RestFull.Repository.Generic;

namespace TRProjeto_RestFull.Business.Implementation
{
    public class ClienteBusinessImplementation : IClienteBusiness
    {
        private readonly GenericRepository<Cliente> _repository;
        private readonly ClienteConverter cliente;

        public ClienteBusinessImplementation(GenericRepository<Cliente> repository, ClienteConverter cliente)
        {
            _repository = repository;
            this.cliente = cliente;
        }

        public ClienteVO Create(ClienteVO item)
        {
            var obj = cliente.Parse(item);
            obj = _repository.Create(obj);
            return cliente.Parse(obj);
        }

        public ClienteVO Update(ClienteVO item)
        {
            var obj = cliente.Parse(item);
            obj = _repository.Update(obj);
            return cliente.Parse(obj);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<ClienteVO> FiendAll()
        {
            return cliente.Parse(_repository.FiendAll());
        }

        public ClienteVO FiendById(long id)
        {
            return cliente.Parse(_repository.FiendById(id));
        }
    }
}
