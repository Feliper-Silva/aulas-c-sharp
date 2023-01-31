using EfetuarPagamento.Classes;
using EfetuarPagamento.Enums;
using System.Runtime.CompilerServices;

namespace EfetuarPagamento
{
    internal class Program
    {
        static void Main(string[] produtos)
        {
            if (produtos.Length == 0)
            {
                Console.WriteLine("Nenhum produto foi listado para compra!");
                return;
            }

            Console.WriteLine("Favor informar a forma de pagamento ( Boleto, Pix, CartaoCredito, CartaoDebito, Transferencia)");

            var formaPagamentoDesejada = Console.ReadLine();

            if (string.IsNullOrEmpty(formaPagamentoDesejada)|| string.IsNullOrWhiteSpace(formaPagamentoDesejada) || TipoPagamentoEnum.Boleto.ToString() != formaPagamentoDesejada && TipoPagamentoEnum.Pix.ToString() != formaPagamentoDesejada && TipoPagamentoEnum.CartaoCredito.ToString() != formaPagamentoDesejada && TipoPagamentoEnum.CartaoDebito.ToString() != formaPagamentoDesejada && TipoPagamentoEnum.Transferencia.ToString() != formaPagamentoDesejada )
            {
                Console.WriteLine($"A forma de pagamento: {formaPagamentoDesejada} não é válida");
                return;
            }

            FormaDePagamento formaDePagamento;

            if ( TipoPagamentoEnum.Boleto.ToString() == formaPagamentoDesejada)
            {
                formaDePagamento = new FormaDePagamentoBoleto();
            }else if (TipoPagamentoEnum.Pix.ToString() == formaPagamentoDesejada)
            {
                formaDePagamento = new FormaDePagamentoPix();
            }
            else if ( TipoPagamentoEnum.CartaoCredito.ToString() == formaPagamentoDesejada)
            {
                formaDePagamento = new FormaDePagamentoCartaoCredito();
            }
            else if (TipoPagamentoEnum.CartaoDebito.ToString() == formaPagamentoDesejada)
            {
                formaDePagamento = new FormaDePagamentoCartaoDebito();
            }
            else if (TipoPagamentoEnum.Transferencia.ToString() == formaPagamentoDesejada)
            {
                formaDePagamento = new FormaDePagamentoTransferencia();
            }
            else
            {
                Console.WriteLine($"A forma de pagamaento: {formaPagamentoDesejada} não é valida!");
                return;
            }

            if ( formaDePagamento != null)
            {
                formaDePagamento.EfetuarPagamento();
            }
        }
    }
}