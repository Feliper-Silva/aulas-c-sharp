using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfetuarPagamento.Classes
{
    internal class FormaDePagamento
    {
        public virtual void EfetuarPagamento ()
        {

            Console.WriteLine("Pagamento efetuado");
        }
    }

    class FormaDePagamentoBoleto : FormaDePagamento
    {
        public override void EfetuarPagamento ()
        {
            Console.WriteLine("Pagamento efetuado com Boleto!");
        }
    }

    class FormaDePagamentoPix : FormaDePagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Pix!");
        }
    }
    class FormaDePagamentoCartaoCredito: FormaDePagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Cartão de Crédito!");
        }
    }
    class FormaDePagamentoCartaoDebito: FormaDePagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Cartão de Débito!");
        }
    }
    class FormaDePagamentoTransferencia : FormaDePagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Transferência!");
        }
    }
}
