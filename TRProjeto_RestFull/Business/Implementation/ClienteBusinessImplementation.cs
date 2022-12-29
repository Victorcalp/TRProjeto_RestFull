using System.Collections.Generic;
using TRProjeto_RestFull.Data.Converter.Implementation;
using TRProjeto_RestFull.Data.VO;
using TRProjeto_RestFull.Model;
using TRProjeto_RestFull.Repository;
using TRProjeto_RestFull.Repository.Generic;

namespace TRProjeto_RestFull.Business.Implementation
{
    public class ClienteBusinessImplementation : IClienteBusiness
    {
        private readonly IRepository<Cliente> _repository;
        private readonly ClienteConverter _cliente;

        public ClienteBusinessImplementation(IRepository<Cliente> repository)
        {
            _repository = repository;
            _cliente = new ClienteConverter();
        }

        public ClienteVO Create(ClienteVO item)
        {
            var obj = _cliente.Parse(item);
            obj = _repository.Create(obj);
            return _cliente.Parse(obj);
        }

        public ClienteVO Update(ClienteVO item)
        {
            var obj = _cliente.Parse(item);
            obj = _repository.Update(obj);
            return _cliente.Parse(obj);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<ClienteVO> FiendAll()
        {
            return _cliente.Parse(_repository.FiendAll());
        }

        public ClienteVO FiendById(long id)
        {
            return _cliente.Parse(_repository.FiendById(id));
        }
    }
}
