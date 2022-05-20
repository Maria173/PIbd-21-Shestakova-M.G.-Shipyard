﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipyardContracts.BindingModels;
using ShipyardContracts.BusinessLogicsContracts;
using ShipyardContracts.StoragesContracts;
using ShipyardContracts.ViewModels;

namespace ShipyardBusinessLogic.BusinessLogics
{
    public class MessageInfoLogic : IMessageInfoLogic
    {
        private readonly IMessageInfoStorage _messageInfoStorage;
        public MessageInfoLogic(IMessageInfoStorage messageInfoStorage)
        {
            _messageInfoStorage = messageInfoStorage;
        }
        public List<MessageInfoViewModel> Read(MessageInfoBindingModel model)
        {
            if (model == null)
            {
                return _messageInfoStorage.GetFullList();
            }
            return _messageInfoStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(MessageInfoBindingModel model)
        {
            _messageInfoStorage.Insert(model);
        }
    }

}
