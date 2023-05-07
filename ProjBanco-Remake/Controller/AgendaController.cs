using ProjBanco_Remake.Model;
using ProjBanco_Remake.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBanco_Remake.Controller
{
    internal class AgendaController
    {
        public bool Inserir(Agenda agenda)
        {
            return new AgendaService().Inserir(agenda);
        }

        public List<Agenda> TodosOsRegistros()
        {
            return new AgendaService().TodosOsRegistros();
        }
    }
}
