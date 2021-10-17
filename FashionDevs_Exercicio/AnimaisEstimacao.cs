using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionDevs_Exercicio
{
    public class AnimaisEstimacao
    {
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToLower(); }
        }

        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set
            {
                if (value.ToLower() == "cachorro" || value.ToLower() == "gato" || value.ToLower() == "peixe")
                {
                    tipo = value.ToLower();
                }
                else
                {
                    tipo = "peixe";
                }
            }
        }


    }
}
