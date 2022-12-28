using System;
using System.ComponentModel.DataAnnotations.Schema;
using TRProjeto_RestFull.Model.Base;

namespace TRProjeto_RestFull.Model
{
    [Table("employee")]
    public class Employee : Users
    {
        public Employee() { }
        public Employee(long id, string firstNome, string lastName, DateTime dataNasc, string gender, int tel, string email, string address) : base(id, firstNome, lastName, dataNasc, gender, tel, email, address)
        {
        }
    }
}
