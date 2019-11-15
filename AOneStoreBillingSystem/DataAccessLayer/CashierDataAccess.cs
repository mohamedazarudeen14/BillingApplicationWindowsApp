using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;

namespace DataAccessLayer
{
    public class CashierDataAccess
    {
        public List<CashierDetail> GetAllCashiers()
        {
            using (Store_BillingEntities1 getAllCashier = new Store_BillingEntities1())
            {
                return getAllCashier.CashierDetails.ToList();
            }
        }

        public void AddLastLoggedInTimedForLoggedCashier(int cashierId)
        {
            using (Store_BillingEntities1 addLastLoggedInTime = new Store_BillingEntities1())
            {
                addLastLoggedInTime.CashierDetails.Where(obj => obj.CashierID == cashierId).ToList().ForEach(obj => obj.Last_LoggedIn_Time = DateTime.Now);
                addLastLoggedInTime.SaveChanges();
            }
        }

        public List<StockDetail> GetAllProducts()
        {
            using (Store_BillingEntities1 getAllProducts = new Store_BillingEntities1())
            {
                return getAllProducts.StockDetails.ToList();
            }
        }

        public void QuantityReduction(List<SalesDetail> purchasedProductDetails)
        {
            using (Store_BillingEntities1 reduceQuantityForPurchasedProduct = new Store_BillingEntities1())
            {
                foreach(StockDetail stockUpdate in reduceQuantityForPurchasedProduct.StockDetails)
                {
                    foreach(SalesDetail billedProducts in purchasedProductDetails)
                    {
                        if(billedProducts.ProductId == stockUpdate.ProductId)
                        {
                            stockUpdate.QuantityAvailable -= billedProducts.Quantity;
                            break;
                        }
                    }
                }
                reduceQuantityForPurchasedProduct.SaveChanges();
            }
        }

        public List<SalesDetail> RetrieveAllSalesDetails()
        {
            using (Store_BillingEntities1 allSalesDetails = new Store_BillingEntities1())
            {
                return allSalesDetails.SalesDetails.ToList();
            }
        }

        public void AddSalesDetails(List<SalesDetail> billedProducts)
        {
            using (Store_BillingEntities1 billedProductDetails = new Store_BillingEntities1())
            {
                billedProductDetails.SalesDetails.AddRange(billedProducts);
                billedProductDetails.SaveChanges();
            }
        }

        public void AddCashierLastLogoutTime(int cashierId)
        {
            using (Store_BillingEntities1 addLastLogoutTime = new Store_BillingEntities1())
            {
                addLastLogoutTime.CashierDetails.Where(obj => obj.CashierID == cashierId).ToList().ForEach(obj => obj.Last_LoggedOut_Time = DateTime.Now);
                addLastLogoutTime.SaveChanges();
            }
        }
    }
}
