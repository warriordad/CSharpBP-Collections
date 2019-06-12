﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="defaultvalue"></param>
        /// <returns></returns>
        public T RetrieveValue<T>(string sql,T defaultvalue)
        {
            // call the daterbase to retrieve the value
            // if no value is returned, return the default.
            T value = defaultvalue;

            return value;

        }


        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }

        public List<Vendor> Retrieve()
        {
            vendors = new List<Vendor>();
            vendors.Add(new Vendor() { VendorId = 1, CompanyName = "ABC",Email="abc@abc.com" });
            vendors.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ", Email = "xyz@xyz.com" });

            Console.WriteLine(vendors);

            return vendors;

        }
    }
}
