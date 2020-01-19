using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagment
{
    public class Product
    { 
        private string _pName;
        public string Name
        {
            get{ return _pName; }
            set { _pName = value; }
        }

        private int _pCode;
        public int Pcode
        {
            get { return _pCode; }
            set { _pCode = value; }
        }

        private int _status;
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _status; }
            set { _quantity = value; }
        }

    }
}
