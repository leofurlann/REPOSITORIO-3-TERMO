using sistema_bancario.Services;
using Sistema_Bancario.Models;


Banco banco = new();

banco.Adicionar(new ContaCorrente("Samuel", saldoinicial: 540000));
banco.Adicionar(new ContaCorrente("Laura", saldoinicial: 125000));

banco.ProcessarMovimentacoes();

