using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBookTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ValueTypePassByValue( )
        {
            int x = 23;
            IncrementNumber(x);
            Assert.AreEqual(23, x);
        }

        public void TestUsingArrays()
        {
            float[] grades;
            grades = new float[3];
            AddGrade(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrade(float[] grades)
        {
            grades[1] = 89.1f;
        }

        public void IncrementNumber(int number)
        {
            number += 1;
        }
    }
}
