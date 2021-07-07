using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC.Models
{
    public class UsuarioEnderecoModel:EnderecoModel
    {
        [ForeignKey("Usuario")]
        public Guid Enredeco_Id { get; set; }
        [ScaffoldColumn(false)]
        public UsuarioModel Usuario { get; set; }
    }
}
