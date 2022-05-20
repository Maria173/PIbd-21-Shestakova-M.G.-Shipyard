﻿using ShipyardListImplement.Models;
using System.Collections.Generic;

namespace ShipyardListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;

        public List<Component> Components { get; set; }

        public List<Order> Orders { get; set; }

        public List<Ship> Ships { get; set; }

        public List<Client> Clients { get; set; }

        public List<Implementer> Implementers { get; set; }
        public List<MessageInfo> Messages { get; set; }

        private DataListSingleton()
        {
            Components = new List<Component>();
            Orders = new List<Order>();
            Ships = new List<Ship>();
            Clients = new List<Client>();
            Implementers = new List<Implementer>();
            Messages = new List<MessageInfo>();
        }

        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}
