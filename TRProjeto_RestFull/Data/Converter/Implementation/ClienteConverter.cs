using System.Collections.Generic;
using System.Linq;
using TRProjeto_RestFull.Data.Converter.Contract;
using TRProjeto_RestFull.Data.VO;
using TRProjeto_RestFull.Model;

namespace TRProjeto_RestFull.Data.Converter.Implementation
{
    public class ClienteConverter : IParser<Cliente, ClienteVO>, IParser<ClienteVO, Cliente>
    {
        public Cliente Parse(ClienteVO item)
        {
            if(item == null) return null;
            return new Cliente
            {
                Id = item.Id,
                FirstNome= item.FirstNome,
                LastName= item.LastName,
                DataNasc = item.DataNasc,
                Gender= item.Gender,
                Tel = item.Tel,
                Email= item.Email,
                Address= item.Address,
                Employee= item.Employee
            };
        }

        public ClienteVO Parse(Cliente item)
        {
            if (item == null) return null;
            return new ClienteVO
            {
                Id = item.Id,
                FirstNome = item.FirstNome,
                LastName = item.LastName,
                DataNasc = item.DataNasc,
                Gender = item.Gender,
                Tel = item.Tel,
                Email = item.Email,
                Address = item.Address,
                Employee = item.Employee
            };
        }

        public List<Cliente> Parse(List<ClienteVO> items)
        {
            var obj = items.Select(item => Parse(item)).ToList();
            return obj;
        }

        public List<ClienteVO> Parse(List<Cliente> items)
        {
            var obj = items.Select(item => Parse(item)).ToList();
            return obj;
        }
    }
}
