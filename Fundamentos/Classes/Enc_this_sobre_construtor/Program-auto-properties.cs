/**
    Ordem sugerida para criação de uma classe
    - Atributos privados
    - Propriedades autoimplementadas
    - Construtores
    - Propriedades customizadas
    - Outros métodos da classe
*/

using System.Globalization;

namespace Course {
    class Produto {
        private string _nome;
        public double Preco { get; private set;}
        public double Quantidade { get; set }

        public Produto {

        }

        public Produto(string nome, double preco, int quantidade){
            _nome = nome;

            Preco = preco;

            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set { 
                if(value != null && value.Length > 1){
                    _nome = value;
                }
            }
        }


    }
}