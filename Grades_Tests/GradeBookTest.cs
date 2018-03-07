using Grade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades_Tests
{
    [TestClass]
    class GradeBookTest
    {

        [TestMethod]
        public void ComputesHighestGradet()
        {
            GradeBook gradebook = new GradeBook();
            gradebook.AddGrade(10);
            gradebook.AddGrade(90);

            GradeStatistics rs = gradebook.ComputeStatistics();
            Assert.AreEqual(90, rs.highestGrade);
        }
    }
}
