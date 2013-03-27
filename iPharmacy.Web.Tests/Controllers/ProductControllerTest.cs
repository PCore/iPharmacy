using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using iPharmacy.Domain;
using iPharmacy.Model;

namespace iPharmacy.Web.Tests.Controllers
{
    /// <summary>
    /// Summary description for ProductControllerTest
    /// </summary>
    [TestClass]
    public class ProductControllerTest
    {
        public ProductControllerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void AddProductsWithValidData()
        {
            IProductRepository db = new ProductRepository();
            Product product = new Product
                              {
                                  Name = "Lipitor",
                                  Description = "Test Medicine",
                                  Price = 100,
                                  AvailableQuantity = "60",
                                  OTC = "Test",
                                  Regulated = "Test1"
                              };

            db.InsertProduct(product);
            db.Save();
        }

        [TestMethod]
        public void EditProductsWithValidData()
        {
            IProductRepository db = new ProductRepository();
            Product product = new Product
            {
                Name = "Lipitor New",
                Description = "Test Medicine Edited",
                Price = 100,
                AvailableQuantity = "60",
                OTC = "Test Edited",
                Regulated = "Test1 Edited"
            };

            db.UpdateProduct(product);
            db.Save();
        }
    }
}
