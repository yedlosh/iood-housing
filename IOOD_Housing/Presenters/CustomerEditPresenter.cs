using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;


namespace IOOD_Housing.Presenters
{
    class CustomerEditPresenter
    {

        OleDbConnection dbCon;
        private readonly CustomerEditView view;
        public CustomerEditPresenter(long customerId) 
        { 
        
        }

        public void saveButtonEvent()
        {
            
        }

        public void cancelButtonEvent()
        {
 
        }
    }
}
