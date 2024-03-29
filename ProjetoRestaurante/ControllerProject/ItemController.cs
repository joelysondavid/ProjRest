﻿using ModelProject;
using PersistenceProject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class ItemController
    {
        private DAO_Item daoItem = new DAO_Item(); // instancia da nossa DAO_Item

        // método que chama dao que tras todos os itens cadastrados
        public IList<Item> GetAll()
        {
            return daoItem.GetAll();
        }

        // método getbyid
        public Item GetById(int id)
        {
            return daoItem.GetById(id);
        }

        // método save
        public Item Save(Item item)
        {
            return daoItem.Save(item);
        }

        // método delete
        public bool Delete(int id)
        {
            return daoItem.Delete(id);
        }

        // método get Items by descri
        public IList<Item> GetItemsByDescr(string descri)
        {
            return daoItem.GetByDescricao(descri);
        }
        public IList<Item> GetItemByDisponibilidade(string descr, bool disponibilidade)
        {
            return daoItem.GetByDisponibilidade(descr,disponibilidade);
        }
        public Item UpdateDisponibilidade(int id, bool disponibilidade)
        {
            return daoItem.UpdateDisponibilidade(id, disponibilidade);
        }
    }
}
