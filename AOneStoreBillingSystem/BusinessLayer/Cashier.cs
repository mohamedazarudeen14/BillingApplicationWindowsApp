using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;
using DataAccessLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class Cashier
    {
        private CashierDataAccess cashierDataAccess;
        public Cashier()
        {
            cashierDataAccess = new CashierDataAccess();
        }

        public bool IsCashierAuthenticated(int cashierID, string cashierPassword)
        {
            EncryptionDecryption passwordEncryptionDecryption = new EncryptionDecryption();
            string EncryptedPassword = passwordEncryptionDecryption.Encryptdata(cashierPassword);
            List<CashierDetail> allCashierList = cashierDataAccess.GetAllCashiers();

            var cashierDetail = allCashierList.SingleOrDefault(obj => obj.CashierID.Equals(cashierID) && obj.Password.Equals(EncryptedPassword));

            if (cashierDetail != null)
                Task.Run(() => cashierDataAccess.AddLastLoggedInTimedForLoggedCashier(cashierID));

            return cashierDetail != null;
        }
        
        public List<StockDetail> GetAllProducts()
        {
            return cashierDataAccess.GetAllProducts();
        }

        public void QuantityReductionForSelectedProduct(string currentBillNumber, decimal totalBillAmount, decimal totalCostPrice, decimal totalProfit, DataGridView purchasedProductsFromGridView)
        {
            List<SalesDetail> purchasedProducts = new List<SalesDetail>();
            Dictionary<long, long> purchased = new Dictionary<long, long>();
            if (purchasedProductsFromGridView.Rows.Count > 0)
            {
                for (int i = 0; i < purchasedProductsFromGridView.Rows.Count; i++)
                {
                    SalesDetail salesDetail = new SalesDetail();
                    salesDetail.BillNos = Convert.ToInt64(currentBillNumber);
                    purchased.Add(Convert.ToInt64(purchasedProductsFromGridView.Rows[i].Cells[1].Value), Convert.ToInt64(purchasedProductsFromGridView.Rows[i].Cells[3].Value));
                    salesDetail.TotalBillAmount = totalBillAmount;
                    salesDetail.TotalCostPrice = totalCostPrice;
                    salesDetail.ProfitAmount = totalProfit;
                    salesDetail.SalesDate = DateTime.Today;
                    purchasedProducts.Add(salesDetail);
                }
            }
            Task.Run(() => cashierDataAccess.AddSalesDetails(purchasedProducts));
            Task.Run(() => cashierDataAccess.QuantityReduction(purchased));
        }
        
        public string GetCurrentBillNumber()
        {
            List<SalesDetail> allSalesDetails = cashierDataAccess.RetrieveAllSalesDetails();
            if(allSalesDetails.Count > 0)
            {
                if(allSalesDetails[allSalesDetails.Count - 1].SalesDate != DateTime.Today)
                {
                    return "1";
                }
                else
                {
                    return (allSalesDetails.Where(obj => obj.SalesDate == DateTime.Today).Max(obj => obj.BillNos) + 1).ToString();
                }
            }
            else
            {
                return "1";
            }
        }

        public void AddCashierLastLogoutTime(int cashierId)
        {
            Task.Run(() => cashierDataAccess.AddCashierLastLogoutTime(cashierId));
        }
    }
}
