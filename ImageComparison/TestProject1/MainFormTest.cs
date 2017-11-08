using ImageComparison;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for MainFormTest and is intended
    ///to contain all MainFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MainFormTest
    {


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
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
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
        ///A test for compareImagesToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ImageComparison.exe")]
        public void compareImagesToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.compareToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for freeHandToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ImageComparison.exe")]
        public void freeHandToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.freeHandToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for grayScaleToolStripMenuItem_Click_1
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ImageComparison.exe")]
        public void grayScaleToolStripMenuItem_Click_1Test()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.grayScaleToolStripMenuItem_Click_1(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for helpToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ImageComparison.exe")]
        public void helpToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.helpToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for quitToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ImageComparison.exe")]
        public void quitToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.quitToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for cropToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ImageComparison.exe")]
        public void cropToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.cropToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for compareToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ImageComparison.exe")]
        public void compareToolStripMenuItem_ClickTest()
        {
            MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.compareToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
