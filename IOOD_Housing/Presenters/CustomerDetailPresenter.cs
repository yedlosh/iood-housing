using IOOD_Housing.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOOD_Housing.Presenters
{
    class CustomerDetailPresenter
    {
        private ICustomerDetailView customerDetailView;

        public CustomerDetailPresenter(ICustomerDetailView view, Customer customer)
        {
            customerDetailView = view;

            customerDetailView.NameLabel = customer.Name;
            customerDetailView.EmailLabel = customer.Email;
            customerDetailView.PhoneLabel = customer.Phone;

            customerDetailView.AddressLabel = customer.Address;
        }
    }
}
