using ModelProject;
using PersistenceProject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class PedidoController
    {
        DAO_Pedido daoPedido = new DAO_Pedido();
        DAO_ItensDePedido daoItensPed = new DAO_ItensDePedido();

        // GETALL Pedidos
        public IList<Pedido> GetAll()
        {
            return daoPedido.GetAll();
        }

        // GET: ALL Itens de Pedido
        public IList<ItemPedido> GetAllItensPedido(int pedidoId)
        {
            return daoItensPed.GetByPed(pedidoId);
        }

        // GET: by id
        public Pedido GetById(int id)
        {
            return daoPedido.GetById(id);
        }

        
        // SAVE
        public Pedido Save(Pedido pedido)
        {
            if (pedido.Id != null)
            {
                /*
                    int idPed = (int)pedido.Id;
                    daoItensPed.DeleteByIdPed(idPed);
                */
                return daoPedido.Update(pedido);
            }
            // else
            return daoPedido.Insert(pedido);
        }

        // DELETE: ById
        public void DeleteById(int idPed)
        {
            daoPedido.DeleteById(idPed);
        }
    }
}
