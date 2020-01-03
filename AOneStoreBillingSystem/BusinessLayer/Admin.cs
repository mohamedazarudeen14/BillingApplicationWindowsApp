﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Admin
    {
        private CashierDataAccess cashierDataAccess = new CashierDataAccess();
        private AdminDataAccess accessDB = new AdminDataAccess();

        public void CheckDbConnection()
        {
            Task.Run(() => accessDB.CheckDbConnection());
        }

        public bool IsAdminAuthenticated(string userId, string password)
        {
            EncryptionDecryption passwordEncryptionDecryption = new EncryptionDecryption();
            string EncryptedPassword = passwordEncryptionDecryption.Encryptdata(password);
            List<AdminDetail> allAdmins = accessDB.GetAllAdmin();
            foreach (AdminDetail admin in allAdmins)
            {
                if (userId.Equals(admin.UserId) && EncryptedPassword.Equals(admin.Password))
                {
                    Task.Run(() => accessDB.AddLastoggedInTimeForLoggedAdmin(admin.UserId));
                    return true;
                }
            }
            return false;
        }

        public bool SaveCashierDetails(string name, int id, string password, string mobileNumber)
        {
            EncryptionDecryption passwordEncrypt = new EncryptionDecryption();
            string decryptedPassword = passwordEncrypt.Encryptdata(password);
            CashierDetail newCashier = new CashierDetail()
            {
                Id = id,
                CashierName = name,
                CashierID = id,
                Password = decryptedPassword,
                MobileNumber = mobileNumber,
                IsActive = false,
            };
            return accessDB.SaveCashier(newCashier);
        }

        public List<CashierDetail> GetAllCashierDetails()
        {
            return accessDB.GetAllCashier();
        }

        public CashierDetail GetSelectedCashierDetails(int selectedCashierId)
        {
            List<CashierDetail> allCashierdetails = accessDB.GetAllCashier();

            return allCashierdetails.SingleOrDefault(obj => obj.CashierID.Equals(selectedCashierId));
        }

        public bool UpdateCashierDetails(CashierDetail cashierDetails)
        {
            return accessDB.UpdateCashierDetails(cashierDetails);
        }

        public bool DeletedSelectedCashier(int selectedCashierId)
        {
            return accessDB.DeleteCashier(selectedCashierId);
        }
        public bool DeletedSelectedProduct(int selectedProductId)
        {
            return accessDB.DeleteProduct(selectedProductId);
        }

        public void AdminLogout(string adminId)
        {
            Task.Run(() => accessDB.AddLastLoggedOutTimeForLoggedAdmin(adminId));
        }

        public bool SaveProductDetails(int id, string name, decimal buyingPrice, decimal sellingPrice, decimal mrp, string description, int quantity)
        {
            StockDetail newStock = new StockDetail
            {
                ProductId = id,
                ProductName = name,
                QuantityAvailable = quantity,
                BuyingPrice = buyingPrice,
                SellingPrice = sellingPrice,
                MRP = mrp,
                ProductDescription = description
            };
            return accessDB.SaveProduct(newStock);
        }

        public List<StockDetail> GetAllStockDetails()
        {
            return accessDB.GetAllStock();
        }

        public StockDetail GetSelectedProductDetails(int selectedProductId)
        {
            List<StockDetail> allProuctdetails = accessDB.GetAllStock();

            return allProuctdetails.SingleOrDefault(obj => obj.ProductId.Equals(selectedProductId));
        }

        public bool UpdateProductDetails(int productId, decimal productBuyingPrice, decimal productSellingPrice, decimal productMRP, int quantityAvailable)
        {
            return accessDB.UpdateProductDetails(productId, productBuyingPrice, productSellingPrice, productMRP, quantityAvailable);
        }

        public bool IsProductIdAvailable(int productId)
        {
            List<StockDetail> allProuctdetails = accessDB.GetAllStock();

            return allProuctdetails.Any(obj => obj.ProductId.Equals(productId));
        }
        
        public List<SalesDetail> GetSalesDetailsForSelectedDate(DateTime fromDate, DateTime toDate)
        {
            List<SalesDetail> allSalesDetails = cashierDataAccess.RetrieveAllSalesDetails();
            if (allSalesDetails.Count > 0)
            {
                List<SalesDetail> selectedDateSalesDetails = allSalesDetails.Where(x => x.SalesDate >= fromDate && x.SalesDate <= toDate).OrderByDescending(x => x.SalesDate).ToList();
                return allSalesDetails;
            }
            return new List<SalesDetail>();
        }
    }
}
