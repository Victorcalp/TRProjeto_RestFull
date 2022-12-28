using Projeto_RestFull.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRProjeto_RestFull.Model.Base
{
    public abstract class Produto : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("decimal")]
        public decimal Price { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("code")]
        public long Code { get; set; }

        public Produto() { }

        public Produto(long id, string name, decimal price, string description, long code)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Code = code;
        }
    }
}
