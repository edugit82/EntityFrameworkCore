using System;
using System.Linq;
using System.Collections.Generic;
using EntityFrameworkCore.Models;
using EntityFrameworkCore.Publicos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFrameworkCore.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                LetraModel model = new LetraModel() { Letra = 'A' };
                new Insert(model);

                List<LetraModel> lista = new Select(c => c.Letra == 'A').retorno;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                model = lista.LastOrDefault();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                model.Letra = 'B';
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                new Update(model);
                
                new Remove(model);
            }
            catch (Exception ex) 
            {

            }
        }
    }
}