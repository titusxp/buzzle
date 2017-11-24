using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using Bizzle.Common;
using Buzzle.DataModel;

namespace Buzzle.Data
{
    public class DataManager
    {
         readonly BuzzleEntities _dataBaseContext = new BuzzleEntities();
        

#region Jobs

        public void SaveChangesToDataBase()
        {
            _dataBaseContext.SaveChanges();
        }

        public List<Job> GetAllJobs()
        {
            return _dataBaseContext.Jobs.OrderByDescending(job => job.JobID).ToList();
        }

        public Job AddJob(Job newJob)
        {
            _dataBaseContext.Jobs.AddOrUpdate(newJob);
            SaveChangesToDataBase();
            return newJob;
        }

        public void UpdateJob(Job newJob)
        {
            _dataBaseContext.Jobs.AddOrUpdate(newJob);
            SaveChangesToDataBase();
        }

#endregion


    #region Items

        public List<JobItemType> GetAllItemTypes()
        {
            return _dataBaseContext.JobItemTypes.ToList();
        }

        public JobItemType AddItemType(JobItemType ItemType)
        {
            _dataBaseContext.JobItemTypes.AddOrUpdate(ItemType);
            SaveChangesToDataBase();
            return ItemType;
        }

        public void RemoveItemType(JobItemType thisItemType)
        {
            _dataBaseContext.JobItemTypes.Remove(thisItemType);
            SaveChangesToDataBase();
        }

    #endregion


    #region Faults

        public List<FaultType> GetAllFaultTypes()
        {
            return _dataBaseContext.FaultTypes.ToList();
        }

        public FaultType AddFaultType(FaultType faultType)
        {
            _dataBaseContext.FaultTypes.AddOrUpdate(faultType);
            SaveChangesToDataBase();
            return faultType;
        }
        public void RemoveFaultType(FaultType thisFaultType)
        {
            _dataBaseContext.FaultTypes.Remove(thisFaultType);
            SaveChangesToDataBase();
        }

    #endregion

    #region Lookup Data

        //public List<LookupData> GetAllLookupData(int tableID)
        //{
        //    return
        //        _dataBaseContext.LookupData.Where(td => td.TableNumber == tableID).ToList();
        //}

        #endregion


    #region Transactions

        public Transaction AddTransaction(Transaction newTransaction)
        {
            _dataBaseContext.Transactions.AddOrUpdate(newTransaction);
            SaveChangesToDataBase();
            return newTransaction;
        }

        public List<Transaction> GetAllTransactions()
        {
            return _dataBaseContext.Transactions.ToList();
        }

        public IEnumerable<TransactionType> GetAllTransactionTypes()
        {
            return _dataBaseContext.TransactionTypes;
        }

        public TransactionType GetTransactionType(int typeID)
        {
            return _dataBaseContext.TransactionTypes.FirstOrDefault(ttype => ttype.TransactionTypeID == typeID);
        }

        #endregion

    #region BuzzleDataSettings

        public BuzzleSetting GetBuzzleDataSetting(string settingName)
        {
            return
                _dataBaseContext.BuzzleSettings.FirstOrDefault(
                    setting => setting.SettingName.Equals(settingName, StringComparison.InvariantCultureIgnoreCase));
        }

        public int? GetJobsTransactionTypeID()
        {
            var jobTransactioTypeSetting = GetBuzzleDataSetting(BuzzleDataSettingNames.JobsTransactionTypeID.ToString());
            if (jobTransactioTypeSetting != null)
            {
                return int.Parse(jobTransactioTypeSetting.SettingValue);
            }
            return null;
        }
        

        public TransactionType GetJobsTransactionType()
        {
            var jobsTransactionID = GetJobsTransactionTypeID();
            if (jobsTransactionID != null)
            {
                return
                    _dataBaseContext.TransactionTypes.FirstOrDefault(
                        ttpe => ttpe.TransactionTypeID == jobsTransactionID);
            }
            return null;
        }

        public int? GetSalesTransactionTypeID()
        {
            var saleTransactioTypeSetting = GetBuzzleDataSetting(BuzzleDataSettingNames.SalesTransactionTypeID.ToString());
            if (saleTransactioTypeSetting != null)
            {
                return int.Parse(saleTransactioTypeSetting.SettingValue);
            }
            return null;
        }

        public TransactionType GetSalesTransactionType()
        {
            var salesTransactionID = GetSalesTransactionTypeID();
            if (salesTransactionID != null)
            {
                return
                    _dataBaseContext.TransactionTypes.FirstOrDefault(
                        ttpe => ttpe.TransactionTypeID == salesTransactionID);
            }
            return null;
        }

        public void CreateJobTransactionTypeSetting()
        {
            if (GetBuzzleDataSetting(BuzzleDataSettingNames.JobsTransactionTypeID.ToString()) == null)
            {
                var query = string.Format("INSERT INTO BuzzleSettings (SettingName, SettingValue) values ('{0}', '-1')",
                    BuzzleDataSettingNames.JobsTransactionTypeID);
                _dataBaseContext.Database.ExecuteSqlCommand(query);
            }
        }

        public void CreateSalesTransactionTypeSetting()
        {
            if (GetBuzzleDataSetting(BuzzleDataSettingNames.SalesTransactionTypeID.ToString()) == null)
            {
                var query = string.Format("INSERT INTO BuzzleSettings (SettingName, SettingValue) values ('{0}', '-1')",
                    BuzzleDataSettingNames.SalesTransactionTypeID);
                _dataBaseContext.Database.ExecuteSqlCommand(query);
            }
        }
    

        public void SetJobsTransactionType(int jobsTransactionTypeID)
        {
            var query =
                string.Format(
                    "UPDATE BuzzleSettings SET SettingValue = {0} WHERE SettingName = 'JobsTransactionTypeID'",
                    jobsTransactionTypeID);
            _dataBaseContext.Database.ExecuteSqlCommand(query);
        }

        public void SetSalesTransactionType(int salesTransactionTypeID)
        {
            var query =
                string.Format(
                    "UPDATE BuzzleSettings SET SettingValue = {0} WHERE SettingName = 'SalesTransactionTypeID'",
                    salesTransactionTypeID);
            _dataBaseContext.Database.ExecuteSqlCommand(query);
        }

        #endregion

    #region JobPayments

        public void AddJobPayment(JobPayment jobPayment)
        {
            //_dataBaseContext.JobPayments.AddOrUpdate(jobPayment);
            //SaveChangesToDataBase();
            //return jobPayment;
            var notes = jobPayment.Notes ?? "";
            var query = string.Format(
                "INSERT INTO dbo.JobPayments ( JobID, TransactionID, Notes ) VALUES( {0}, {1}, '{2}')", jobPayment.JobID, jobPayment.TransactionID, notes);
            _dataBaseContext.Database.ExecuteSqlCommand(query);
        }

    #endregion

        #region Users

        public bool NoUsers
        {
            get
            {
                return !_dataBaseContext.Users.Any(user => user.IsDeleted == false);
            }
        }

        public User GetUser(string username, string password)
        {
            return _dataBaseContext.Users.FirstOrDefault(user => user.UserName == username && user.PassWord == password && user.IsDeleted == false);
        }

        public User AddUser(User userToBeSaved)
        {
            _dataBaseContext.Users.AddOrUpdate(userToBeSaved);
            SaveChangesToDataBase();
            return userToBeSaved;
        }

        public User UpdateUser(User user)
        {
            _dataBaseContext.Users.AddOrUpdate(user);
            SaveChangesToDataBase();
            return user;
        }

        public List<User> GetAllUsers()
        {
            return _dataBaseContext.Users.Where(user => user.IsDeleted == false).OrderBy(user => user.FirstName).ToList();
        }

        public void DeleteUser(User user)
        {
            user.IsDeleted = true;
            UpdateUser(user);
        }

        #endregion

        #region
        public List<Account> GetAllAccounts()
        {
            return _dataBaseContext.Accounts.ToList();
        }
        #endregion

        public object GetAccountStats()
        {
            return _dataBaseContext.AccountStats;}

        #region

        public List<StockItemType> GetAllStockItemTypes()
        {
            return _dataBaseContext.StockItemTypes.ToList();
        }

        public StockItemType AddNewStockItemType(StockItemType stockItemTypeBeingSaved)
        {
            _dataBaseContext.StockItemTypes.AddOrUpdate(stockItemTypeBeingSaved);
            SaveChangesToDataBase();
            return stockItemTypeBeingSaved;
        }

        public StockItemType UpdateStockItemType(StockItemType stockItemTypeBeingSaved)
        {
            _dataBaseContext.StockItemTypes.AddOrUpdate(stockItemTypeBeingSaved);
            SaveChangesToDataBase();
            return stockItemTypeBeingSaved;
        }

        #endregion

        #region StockBalances

        public List<StockItemBalance> GetAllItemsInStock()
        {
            return _dataBaseContext.StockItemBalances.Where(item => item.QuantityInStock > 0).ToList();
        }

        #endregion

        #region Purchases
        public List<Purchase> GetAllPurchases()
        {
            return _dataBaseContext.Purchases.ToList();
        }


        public Purchase AddPurchase(Purchase purchase)
        {
            _dataBaseContext.Purchases.AddOrUpdate(purchase);
            SaveChangesToDataBase();
            return purchase;
        }

        public Purchase UpdatePurchase(Purchase purchase)
        {
            var orphanItems = _dataBaseContext.PurchaseItems.Where(item => item.PurchaseID < 1);
            DeleteAllDetachedPurchaseItems();
            _dataBaseContext.Purchases.AddOrUpdate(purchase);
            _dataBaseContext.SaveChanges();
            return purchase;
        }

        private void DeleteAllDetachedPurchaseItems()
        {
            foreach (
                PurchaseItem purchaseItem in
                    _dataBaseContext.PurchaseItems.Where(item => item.PurchaseID < 1))
            {
                _dataBaseContext.PurchaseItems.Remove(purchaseItem);
            }
        }

        public void DeletePurchase(Purchase purchase)
        {
            _dataBaseContext.Purchases.Remove(purchase);
            SaveChangesToDataBase();
        }

        #endregion

        #region StockItemMovements
        public StockItemMovement AddStockItemMovement(StockItemMovement stockMovement)
        {
            _dataBaseContext.StockItemMovements.AddOrUpdate(stockMovement);
            SaveChangesToDataBase();
            return stockMovement;
        }
        #endregion

        private string BuildStockMovementInsertQuery(StockItemMovement movement)
        {
            return string.Format(@"INSERT INTO StockItemMovements 
([StockItemTypeID],
[Quantity],
[MovementType], 
[Description],
[SerialNumber],
[UnitPurchasePrice],
[MovementReason],
[DateRecorded]) 
VALUES ({0},{1},{2},'{3}','{4}',{5},'{6}', CONVERT(DATETIME, '{7}'))",
movement.StockItemTypeID, movement.Quantity, movement.MovementType, movement.Description,
 movement.SerialNumber, movement.UnitPurchasePrice, movement.MovementReason, movement.DateRecorded);
        }

#region Sales 

        public List<Sale> GetAllSales()
        {
            return _dataBaseContext.Sales.ToList();
        }

        #endregion

#region Supplies
        public Supply AddSupply(Supply supply)
        {
            _dataBaseContext.Supplies.AddOrUpdate(supply);
            SaveChangesToDataBase();
            return supply;
        }

        public SupplyItem AddSupplyItem(SupplyItem item)
        {
            _dataBaseContext.SupplyItems.AddOrUpdate(item);
            SaveChangesToDataBase();
            return item;
        }

#endregion 
    
        public List<Supply> GetAllSupplies()
        {
            return _dataBaseContext.Supplies.ToList();
        }

        public Sale AddSale(Sale sale)
        {
            _dataBaseContext.Sales.AddOrUpdate(sale);
            SaveChangesToDataBase();
            return sale;
        }

        #region Company

        public Company GetCompanyData()
        {
            return _dataBaseContext.Companies.FirstOrDefault();
        }

        public Company UpdateCompanyInfo(Company CurrentCompany)
        {
            _dataBaseContext.Companies.AddOrUpdate(CurrentCompany);
            SaveChangesToDataBase();
            return CurrentCompany;
        }

        public Company AddCompanyInfo(Company CurrentCompany)
        {
            _dataBaseContext.Companies.AddOrUpdate(CurrentCompany);
            SaveChangesToDataBase();
            return CurrentCompany;
        }

        #endregion

        public List<Sale> GetSalesByQuery(string query)
        {
            return _dataBaseContext.Database.SqlQuery<Sale>(query).ToList();
        }
    }
}
