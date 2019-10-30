using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pessoa_crud.Domain {
    public class Pessoa {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id {get;set;}
        public string nome {get; set;}
        public string senha {get; set;}
        public string telefone {get; set;}
        public string email {get; set;}
        public DateTime nascimento {get; set;}
    }
}