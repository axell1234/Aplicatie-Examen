using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicatie_Examen.Models;
using System;

namespace Aplicatie_Examen.Data
{
    public class CarListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public CarListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<CarList>().Wait();
        }
        public Task<List<CarList>> GetShopListsAsync()
        {
            return _database.Table<CarList>().ToListAsync();
        }
        public Task<CarList> GetCarlistAsync(int id)
        {
            return _database.Table<CarList>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }

        internal Task DeleteProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        internal Task GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveShopListAsync(CarList slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }

        internal Task SaveListProductAsync(Product.ListProduct lp)
        {
            throw new NotImplementedException();
        }

        internal Task SaveShopListAsync(LisrCarPage lisrCarPage)
        {
            throw new NotImplementedException();
        }

        internal Task DeleteCarListAsync(CarList slist)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteShopListAsync(CarList slist)
        {
            return _database.DeleteAsync(slist);
        }
    }


}
public Task<int> SaveListProductAsync(ListProduct listp)
{
    if (listp.ID != 0)
    {
        object _database = null;
        return _database.UpdateAsync(listp);
    }
    else
    {
        return _database.InsertAsync(listp);
    }
}
public Task<List<Product>> GetListProductsAsync(int carlistid)
{
    return _database.QueryAsync<Product>(
    "select P.ID, P.Description from Product P"
    + " inner join ListProduct LP"
    + " on P.ID = LP.ProductID where LP.ShopListID = ?",
    shoplistid);
}
