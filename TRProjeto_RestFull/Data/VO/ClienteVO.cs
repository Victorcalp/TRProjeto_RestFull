using System;
using TRProjeto_RestFull.Model;

namespace TRProjeto_RestFull.Data.VO
{
    public class ClienteVO
    {
        public long Id { get; set; }
        public string FirstNome { get; set; }
        public string LastName { get; set; }
        public DateTime DataNasc { get; set; }
        public string Gender { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Employee Employee { get; set; }
    }
}
