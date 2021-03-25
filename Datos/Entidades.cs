using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ResultadosExamen
    {
        Entidades.ModeloLaboratorio DB = new Entidades.ModeloLaboratorio();

        public void AgregarNuevoResultado(Entidades.ProtocolosResultados resultados)
        {
            DB.ProtocolosResultados.Add(resultados);
            DB.SaveChanges();
        }
        public object ConsultarUno(int id)
        {
            var protocolo = DB.ProtocolosResultados.Where(x => x.IDProtocolo==id);
            return protocolo;
        }

    }
}
