# Automação de Processamento de Contratos em C#

Este projeto tem como objetivo automatizar o processamento de contratos, dividindo o valor total em parcelas e aplicando juros simples de 1% ao mês e uma taxa de 2% por parcela. A implementação também simula a integração com um serviço de pagamento, como o PayPal, que aplica essas regras.

## Requisitos do Exercício

O sistema deve:
1. Receber os dados de um contrato:
   - Número do contrato.
   - Data do contrato.
   - Valor total do contrato.
   - Número de meses para parcelamento.
2. Processar as parcelas:
   - Dividir o valor total pelo número de parcelas.
   - Aplicar 1% de juros simples ao mês sobre o valor de cada parcela.
   - Aplicar uma taxa fixa de 2% sobre o valor de cada parcela.
3. Exibir as parcelas geradas com suas datas de vencimento e valores.

## Estrutura do Projeto

O projeto é dividido em várias partes para facilitar a implementação e o entendimento:

- **Contract**: Representa o contrato, com seu número, data, valor total e as parcelas.
- **Installment**: Representa cada parcela, com sua data de vencimento e valor.
- **IOnlinePaymentService**: Interface que define os métodos para calcular juros e taxas.
- **PaypalService**: Implementa a lógica de cálculo de juros e taxas de pagamento para o serviço de pagamento.
- **ContractService**: Processa o contrato, gerando as parcelas e adicionando-as ao contrato.