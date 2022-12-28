using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TRProjeto_RestFull.Model.Base;

namespace TRProjeto_RestFull.Model
{
    [Table("cliente")]
    public class Cliente : Users
    {
        [Column("id_func")]
        public Employee Employee { get; set; }

        public Cliente()
        {

        }

        public Cliente(long id, string firstNome, string lastName, DateTime dataNasc, string gender, int tel, string email, string address, Employee employee) 
            : base(id, firstNome, lastName, dataNasc, gender, tel, email, address)
        {
            Employee = employee;
        }
    }
}
