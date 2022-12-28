using Projeto_RestFull.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRProjeto_RestFull.Model.Base
{
    public abstract class Users : BaseEntity
    {
        [Column("first_name")]
        public string FirstNome { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("data_nasc")]
        public DateTime DataNasc { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("tel")]
        public int Tel { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("address")]
        public string Address { get; set; }

        public Users() { }
        public Users(long id, string firstNome, string lastName, DateTime dataNasc, string gender, int tel, string email, string address)
        {
            Id = id;
            FirstNome = firstNome;
            LastName = lastName;
            DataNasc = dataNasc;
            Gender = gender;
            Tel = tel;
            Email = email;
            Address = address;
        }

    }
}
