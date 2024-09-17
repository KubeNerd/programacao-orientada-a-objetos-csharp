# Classe

- É um tipo estruturado que pode conter(membros):
    - Atributos(dados/campos)
    - Métodos(funções/operações)

- Classe também pode prover muitos outros recursos, tais como:
  - Construtores
  - Sobrecarga
  - Encapsulamento
  - Herança
  - Polimorfismo


- Exemplos:
    - Entidades: Produto, Cliente, Triangulo
    - Serviços: ProdutoService, ClienteService, EmailService, StorageService
    - Controladores: ProdutoController, ClienteController
    - Utilitários: Calculadora, Compactador
    - Outros(Views, repositórios, gerenciadores, etc)


# Membros estáticos

- Também chamados de memebros de classe
  - Em oposição a mebros e instância

- São mebros que fazem sentido independentemente do que objetos.Não precisam de objeto para serem chamados. São chamados a partir do próprio nome da classe.

- Aplicações comuns:
  - Classes utilitárias -> Math.Sqrt(double)
  - Declaração de constantes


- Uma classe que possui somente membros estáticos, pode ser uma classe estática também. Esta classe não poderá ser instanciada.
