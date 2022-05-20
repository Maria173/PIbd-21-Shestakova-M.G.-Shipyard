using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipyardContracts.BindingModels;

namespace ShipyardContracts.BusinessLogicsContracts
{
    public interface IBackUpLogic
    {
        void CreateBackUp(BackUpSaveBinidngModel model);
    }

}
