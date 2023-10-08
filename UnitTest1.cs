using BusinessLayer;
using DataLayer;
using Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private DecaBusiness decaBusiness = new DecaBusiness();
        [TestMethod]
        public void IsDecaInserted()
        {
            Deca d = new Deca();
            d.id_deteta = 100;
            d.ime = "Nikolina";
            d.prezime = "Micic";
            d.ime_majke = "Jelena";
            d.ime_oca = "Jovan";
            d.datum_rodjenja = "25/8/2018";
            d.mesto_rodjenja = "Cacak";
        }

        [TestMethod]
        public void IsDecaUpdated()
        {
            int id = 0;
            foreach (var item in decaBusiness.GetAllChildren())
            {
                if (item.ime == "Nikolina")
                {
                    id = item.id_deteta;
                    break;
                }
            }

            Deca d = new Deca();
            d.id_deteta = id;
            d.ime = "Nikolina";
            d.prezime = "Gardic";
            d.ime_majke = "Jelena";
            d.ime_oca = "Jovan";
            d.datum_rodjenja = "25/8/2018";
            d.mesto_rodjenja = "Cacak";

            //Act
            var rez = decaBusiness.UpdateChildren(d);

            //Asert
            Assert.IsTrue(rez);
        }

        [TestMethod]
        public void IsDecaRemoved()
        {
            int id = 0;
            foreach (var item in decaBusiness.GetAllChildren())
            {
                if (item.ime == "Nikolina")
                {
                    id = item.id_deteta;
                    break;
                }
            }
            Deca d = new Deca();
            d.id_deteta = id;
            var rez = decaBusiness.DeleteChildren(d);
            Assert.IsTrue(rez);
        }
    }
}
