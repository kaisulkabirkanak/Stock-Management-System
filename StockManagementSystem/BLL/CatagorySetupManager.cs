using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.BLL
{
    class CategorySetupManager
    {
        CategorySetupRepository RepositoryFolder = new CategorySetupRepository(); // Create a new Instance or Object store data in DalFolder variable for passing value
        public bool Insert(CategorySetup category)    // Calling Insert Method from DAL with passing parameters
        {
            bool chk = RepositoryFolder.Insert(category);
            return chk;
        }
    }
}
