using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{

    public interface IOperacoesBD
    {


        public void InserirClientes()
        {

        }
        public void AlterarClientes()
        {

        }
        public void DeletarClientes(int id)
        {
            Console.WriteLine("Você Excluiu: " + id);

        }
        public void DeletarClientes(string nome, int id)
        {
            Console.WriteLine("Você Excluiu: " + nome, id);

        }


        public void PesquisarClientes()
        {

        }

        public virtual void InserirPedido(int idPedido)
        {

        }
        public void InserirPedido(int idPedido, string infoProduto)
        {
            //base.InserirPedido();
        }

        public void AlterarPedido()
        {

        }
        public void DeletarPedido(int idPedido)
        {
            Console.WriteLine("Você Excluiu o Pedido: " + idPedido);

        }
        public void DeletarPedido(string infoPedido, int idPedido)
        {
            Console.WriteLine("Você Excluiu o Pedido: " + idPedido, infoPedido);

        }

        public void PesquisarPedido()
        {

        }

    }
}
