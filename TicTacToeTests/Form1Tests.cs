using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace TicTacToe.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        Form1 testForm = new Form1();

        [TestMethod()]
        public void checkForWinner_horizontalTest()
        {
            //Checks horizontal win
            
            testForm.A1.Text = "O";
            testForm.A2.Text = "O";
            testForm.A3.Text = "O";

            testForm.A1.Enabled = false;
            testForm.checkForWinner();

            Assert.IsTrue(testForm.winner);

        }

        [TestMethod()]
        public void checkForWinner_verticalTest()
        {
            //Checks horizontal win
            
            testForm.A1.Text = "O";
            testForm.B1.Text = "O";
            testForm.C1.Text = "O";

            testForm.A1.Enabled = false;
            testForm.checkForWinner();

            Assert.IsTrue(testForm.winner);

        }
    }
}