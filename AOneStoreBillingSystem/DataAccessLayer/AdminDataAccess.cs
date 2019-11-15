using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class AdminDataAccess
    {
        public void CheckDbConnection()
        {
            using (Store_BillingEntities1 billingEntities = new Store_BillingEntities1())
            {
                billingEntities.AdminDetails.ToList();
            }
        }

        public void SaveAdmin(AdminDetail newAdmin)
        {
            using (Store_BillingEntities1 addAdmin = new Store_BillingEntities1())
            {
                addAdmin.AdminDetails.Add(newAdmin);
                addAdmin.SaveChanges();
            }
        }

        public List<AdminDetail> GetAllAdmin()
        {
            using (Store_BillingEntities1 allAdmin = new Store_BillingEntities1())
            {
                return allAdmin.AdminDetails.ToList();
            }

        }
        public bool SaveCashier(CashierDetail newCashier)
        {
            using (Store_BillingEntities1 saveCashierDetails = new Store_BillingEntities1())
            {
                saveCashierDetails.CashierDetails.Add(newCashier);
                saveCashierDetails.SaveChanges();
                return true;
            }
        }
        public bool SaveProduct(StockDetail newStock)
        {
            using (Store_BillingEntities1 saveProductDetails = new Store_BillingEntities1())
            {
                saveProductDetails.StockDetails.Add(newStock);
                saveProductDetails.SaveChanges();
                return true;
            }
        }
        public List<CashierDetail> GetAllCashier()
        {
            using (Store_BillingEntities1 getAllCashier = new Store_BillingEntities1())
            {
                return getAllCashier.CashierDetails.ToList();
            }               
        }
        public List<StockDetail> GetAllStock()
        {
            using (Store_BillingEntities1 getAllStock = new Store_BillingEntities1())
            {
                return getAllStock.StockDetails.ToList();
            }
        }
        public void AddLastoggedInTimeForLoggedAdmin(string loggedAdminUserId)
        {
            using (Store_BillingEntities1 allAdmin = new Store_BillingEntities1())
            {
                allAdmin.AdminDetails.Where(obj => obj.UserId.Equals(loggedAdminUserId)).ToList().ForEach(obj => obj.Last_LoggedIn_Time = DateTime.Now);
                allAdmin.SaveChanges();
            }
        }

        public void AddLastLoggedOutTimeForLoggedAdmin(string loggedInAdminUserId)
        {
            using (Store_BillingEntities1 allAdmin = new Store_BillingEntities1())
            {
                allAdmin.AdminDetails.Where(obj => obj.UserId.Equals(loggedInAdminUserId)).ToList().ForEach(obj => obj.Last_LoggedOut_Time = DateTime.Now);
                allAdmin.SaveChanges();
            }
        }

        public bool UpdateCashierDetails(CashierDetail cashier)
        {
            bool isCashierDetailsUpdated = false;
            using (Store_BillingEntities1 updateCashierDetails = new Store_BillingEntities1())
            {
                foreach(CashierDetail cashierDetails in updateCashierDetails.CashierDetails)
                {
                    if(cashierDetails.CashierID == cashier.CashierID)
                    {
                        cashierDetails.CashierName = cashier.CashierName;
                        cashierDetails.MobileNumber = cashier.MobileNumber;
                        cashierDetails.Password = cashier.Password;
                        isCashierDetailsUpdated = true;
                        break;
                    }
                }
                updateCashierDetails.SaveChanges();
                return isCashierDetailsUpdated;
            }
        }

        public bool DeleteCashier(int cashierId)
        {
            bool isCashierdeleted = false;
            CashierDetail selecetdCashierForDeletion = null;
            using (Store_BillingEntities1 deleteCashier = new Store_BillingEntities1())
            {
                foreach(CashierDetail cashierDetails in deleteCashier.CashierDetails)
                {
                    if(cashierDetails.CashierID == cashierId)
                    {
                        selecetdCashierForDeletion = cashierDetails;
                        break;
                    }
                }
                if (selecetdCashierForDeletion != null)
                {
                    deleteCashier.CashierDetails.Remove(selecetdCashierForDeletion);
                    isCashierdeleted = true;

                }
                deleteCashier.SaveChanges();
                return isCashierdeleted;
            }
        }
        public bool DeleteProduct(int productId)
        {
            bool isProductdeleted = false;
            StockDetail selecetdProductForDeletion = null;
            using (Store_BillingEntities1 deleteProduct = new Store_BillingEntities1())
            {
                foreach (StockDetail productDetails in deleteProduct.StockDetails)
                {
                    if (productDetails.ProductId == productId)
                    {
                        selecetdProductForDeletion = productDetails;
                        break;
                    }
                }
                if (selecetdProductForDeletion != null)
                {
                    deleteProduct.StockDetails.Remove(selecetdProductForDeletion);
                    isProductdeleted = true;

                }
                deleteProduct.SaveChanges();
                return isProductdeleted;
            }
        }
        public bool UpdateProductDetails(int productId, decimal productPrice, int availableQty)
        {
            bool isProductDetailsUpdated = false;
            using (Store_BillingEntities1 updateProductDetails = new Store_BillingEntities1())
            {
                foreach (StockDetail productDetails in updateProductDetails.StockDetails)
                {
                    if (productDetails.ProductId == productId)
                    {
                        productDetails.Price = productPrice;
                        productDetails.QuantityAvailable = availableQty;
                        isProductDetailsUpdated = true;
                        break;
                    }
                }
                updateProductDetails.SaveChanges();
                return isProductDetailsUpdated;
            }
        }
    }
}
