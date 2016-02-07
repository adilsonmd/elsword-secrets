using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsword_Secrets
{
    class Itens
    {
        public ItensSecret TipoItem { get; set; }   
        

        public static void AddItem()
        {

        }
    }

    enum ItensSecret
    {
        ElderMoeda,
        BesmaMoeda,
        AlteraMoeda,
        VelderMoeda,
        HamelMoeda
    }
}
