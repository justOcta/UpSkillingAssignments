using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory;
internal class Product
{
    public string Name { get; set; }

    private int _stockQuantity;
    public int StockQuantity
    {
        get { return _stockQuantity; }
    }

    public bool IsAvailable
    {
        get { return _stockQuantity > 0; }
    }

    private double _price;
    public double Price
    {
        get {  return _price; }
        set
        {
            if (value >= 0)
                _price = value;
            else
                throw new Exception("Price cannot be negative");
        }
    }

    public void UpdateStock(int productCount)
    {
        if (_stockQuantity >= 0)
            _stockQuantity += productCount;
        else
            throw new Exception("Invalid productCount !!");
    }
}
