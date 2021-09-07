using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Login_Project.Models
{
    public class ErrorsModel
    {
        public IEnumerable<string> Erros { get; private set; }
        public ErrorsModel(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
