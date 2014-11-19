using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BikeStore.Tests
{
    
    
    /// <summary>
    ///This is a test class for OrderRepositoryTest and is intended
    ///to contain all OrderRepositoryTest Unit Tests
    ///</summary>
	[TestClass()]
	public class OrderRepositoryTest
	{
		//Hack. I should use a mock here
		private static IOrderRepository repository;

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
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		[ClassInitialize()]
		public static void MyClassInitialize(TestContext testContext)
		{
			repository = new OrderRepository();
		}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for UpdateItemQuantity
		///</summary>
		[TestMethod()]
		public void UpdateItemQuantityTest()
		{
			
			int productID = 1; 
			int orderID = 12; 
			uint quantity = 1;
			
			int? actual = repository.UpdateItemQuantity(productID, orderID, quantity);
			Assert.AreNotEqual(-1, actual);
		}
	}
}
