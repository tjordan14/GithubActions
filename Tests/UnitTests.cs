﻿using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above

        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(2, Program.Subtract("5", "3"));
            Assert.AreEqual(12, Program.Subtract("55", "43"));
            Assert.AreEqual(100, Program.Subtract("200", "100"));
        }

        [Test]
        public void Subtract_Invlaid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("5", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "5"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("5", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "5"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(4, Program.Multiply("4", "1"));
            Assert.AreEqual(15, Program.Multiply("5", "3"));
            Assert.AreEqual(49, Program.Multiply("7", "7"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("5", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "5"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(4,Program.Divide("4", "1"));
            Assert.AreEqual(5, Program.Divide("15", "3"));
            Assert.AreEqual(25, Program.Divide("100", "4"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("5", "a"));
            Assert.Throws<FormatException> (() => Program.Divide("a", "1"));
            Assert.Throws<FormatException> (() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException> (() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException> (() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException> (() => Program.Divide(null, null));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(8,Program.Power("2", "3"));
            Assert.AreEqual (1,Program.Power("3", "0"));
            Assert.AreEqual(16,Program.Power("4", "2"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException> (() => Program.Power("1", "a"));
            Assert.Throws<FormatException> (() => Program.Power ("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));

        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException> (() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException> (() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
