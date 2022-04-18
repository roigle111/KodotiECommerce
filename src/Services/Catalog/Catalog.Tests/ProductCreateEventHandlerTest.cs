using Catalog.Domain;
using Catalog.Service.EventHandlers;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Tests.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading;

namespace Catalog.Tests
{
    [TestClass]
    public class ProductCreateEventHandlerTest
    {

        [TestMethod]
        public void TestCreateProduct()
        {
            var context = ApplicationDbContextInMemory.Get();

            var nameProduct = "Pantalon--55";

            var handler = new ProductCreateEventHandler(context);
            handler.Handle(new ProductCreateCommand {
                Name = nameProduct, 
                Description = "Descripcion del pantalon",
                Price = 3600
            }, new CancellationToken()).Wait();

            var result = context.Products.Single(x => x.Name == nameProduct).Name;

            Assert.AreEqual(nameProduct, result);
        }

    }
}
