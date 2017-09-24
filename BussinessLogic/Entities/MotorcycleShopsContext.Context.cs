﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BussinessLogic.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MotorcycleShopsEntities : DbContext
    {
        public MotorcycleShopsEntities()
            : base("name=MotorcycleShopsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bike> Bikes { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<BillEmployee> BillEmployees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<MaintenanceBill> MaintenanceBills { get; set; }
        public virtual DbSet<QuotationTable> QuotationTables { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SaleReceipt> SaleReceipts { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int INSERT_BIKE(string engineNumber, string chassisNumber, string brand, string modelCode, Nullable<int> capacity, string color, string plateNumber, Nullable<long> storeID, Nullable<double> price, Nullable<long> customerID, string warrantyPeriod, ObjectParameter success, ObjectParameter error)
        {
            var engineNumberParameter = engineNumber != null ?
                new ObjectParameter("EngineNumber", engineNumber) :
                new ObjectParameter("EngineNumber", typeof(string));
    
            var chassisNumberParameter = chassisNumber != null ?
                new ObjectParameter("ChassisNumber", chassisNumber) :
                new ObjectParameter("ChassisNumber", typeof(string));
    
            var brandParameter = brand != null ?
                new ObjectParameter("Brand", brand) :
                new ObjectParameter("Brand", typeof(string));
    
            var modelCodeParameter = modelCode != null ?
                new ObjectParameter("ModelCode", modelCode) :
                new ObjectParameter("ModelCode", typeof(string));
    
            var capacityParameter = capacity.HasValue ?
                new ObjectParameter("Capacity", capacity) :
                new ObjectParameter("Capacity", typeof(int));
    
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var plateNumberParameter = plateNumber != null ?
                new ObjectParameter("PlateNumber", plateNumber) :
                new ObjectParameter("PlateNumber", typeof(string));
    
            var storeIDParameter = storeID.HasValue ?
                new ObjectParameter("StoreID", storeID) :
                new ObjectParameter("StoreID", typeof(long));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(double));
    
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(long));
    
            var warrantyPeriodParameter = warrantyPeriod != null ?
                new ObjectParameter("WarrantyPeriod", warrantyPeriod) :
                new ObjectParameter("WarrantyPeriod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_BIKE", engineNumberParameter, chassisNumberParameter, brandParameter, modelCodeParameter, capacityParameter, colorParameter, plateNumberParameter, storeIDParameter, priceParameter, customerIDParameter, warrantyPeriodParameter, success, error);
        }
    
        public virtual int INSERT_CUSTOMER(string name, Nullable<System.DateTime> dOB, string address, string phoneNumber, string email, ObjectParameter currentIdentity, ObjectParameter success)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_CUSTOMER", nameParameter, dOBParameter, addressParameter, phoneNumberParameter, emailParameter, currentIdentity, success);
        }
    
        public virtual int INSERT_SALE_RECEIPT(Nullable<long> cashierID, Nullable<System.DateTime> soldDate, Nullable<long> storeID, Nullable<long> bikeID, ObjectParameter success, ObjectParameter error)
        {
            var cashierIDParameter = cashierID.HasValue ?
                new ObjectParameter("CashierID", cashierID) :
                new ObjectParameter("CashierID", typeof(long));
    
            var soldDateParameter = soldDate.HasValue ?
                new ObjectParameter("SoldDate", soldDate) :
                new ObjectParameter("SoldDate", typeof(System.DateTime));
    
            var storeIDParameter = storeID.HasValue ?
                new ObjectParameter("StoreID", storeID) :
                new ObjectParameter("StoreID", typeof(long));
    
            var bikeIDParameter = bikeID.HasValue ?
                new ObjectParameter("BikeID", bikeID) :
                new ObjectParameter("BikeID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_SALE_RECEIPT", cashierIDParameter, soldDateParameter, storeIDParameter, bikeIDParameter, success, error);
        }
    
        public virtual int NEW_SALE_TRANSACTION(string phoneNumber, string engineNumber, string chassisNumber, Nullable<long> cashierID, Nullable<System.DateTime> soldDate, Nullable<long> storeID, ObjectParameter success, ObjectParameter error)
        {
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var engineNumberParameter = engineNumber != null ?
                new ObjectParameter("EngineNumber", engineNumber) :
                new ObjectParameter("EngineNumber", typeof(string));
    
            var chassisNumberParameter = chassisNumber != null ?
                new ObjectParameter("ChassisNumber", chassisNumber) :
                new ObjectParameter("ChassisNumber", typeof(string));
    
            var cashierIDParameter = cashierID.HasValue ?
                new ObjectParameter("CashierID", cashierID) :
                new ObjectParameter("CashierID", typeof(long));
    
            var soldDateParameter = soldDate.HasValue ?
                new ObjectParameter("SoldDate", soldDate) :
                new ObjectParameter("SoldDate", typeof(System.DateTime));
    
            var storeIDParameter = storeID.HasValue ?
                new ObjectParameter("StoreID", storeID) :
                new ObjectParameter("StoreID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("NEW_SALE_TRANSACTION", phoneNumberParameter, engineNumberParameter, chassisNumberParameter, cashierIDParameter, soldDateParameter, storeIDParameter, success, error);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UPDATE_BIKE(string engineNumber, string chassisNumber, string brand, string modelCode, Nullable<int> capacity, string color, string plateNumber, Nullable<long> storeID, Nullable<double> price, Nullable<long> customerID, string warrantyPeriod, ObjectParameter success)
        {
            var engineNumberParameter = engineNumber != null ?
                new ObjectParameter("EngineNumber", engineNumber) :
                new ObjectParameter("EngineNumber", typeof(string));
    
            var chassisNumberParameter = chassisNumber != null ?
                new ObjectParameter("ChassisNumber", chassisNumber) :
                new ObjectParameter("ChassisNumber", typeof(string));
    
            var brandParameter = brand != null ?
                new ObjectParameter("Brand", brand) :
                new ObjectParameter("Brand", typeof(string));
    
            var modelCodeParameter = modelCode != null ?
                new ObjectParameter("ModelCode", modelCode) :
                new ObjectParameter("ModelCode", typeof(string));
    
            var capacityParameter = capacity.HasValue ?
                new ObjectParameter("Capacity", capacity) :
                new ObjectParameter("Capacity", typeof(int));
    
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var plateNumberParameter = plateNumber != null ?
                new ObjectParameter("PlateNumber", plateNumber) :
                new ObjectParameter("PlateNumber", typeof(string));
    
            var storeIDParameter = storeID.HasValue ?
                new ObjectParameter("StoreID", storeID) :
                new ObjectParameter("StoreID", typeof(long));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(double));
    
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(long));
    
            var warrantyPeriodParameter = warrantyPeriod != null ?
                new ObjectParameter("WarrantyPeriod", warrantyPeriod) :
                new ObjectParameter("WarrantyPeriod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_BIKE", engineNumberParameter, chassisNumberParameter, brandParameter, modelCodeParameter, capacityParameter, colorParameter, plateNumberParameter, storeIDParameter, priceParameter, customerIDParameter, warrantyPeriodParameter, success);
        }
    
        public virtual int UPDATE_CUSTOMER_INFORMATION(string phoneNumber, string name, Nullable<System.DateTime> dOB, string address, string email, ObjectParameter success)
        {
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_CUSTOMER_INFORMATION", phoneNumberParameter, nameParameter, dOBParameter, addressParameter, emailParameter, success);
        }
    }
}