using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using OddEnds.Extensions;

namespace OddEnds.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionsTests
    {
        private string sample = "sample";
        private string whitespace = "      ";
        private string empty = "";
        private string nothing = null;

        [Test]
        public void test_AsNullIfEmpty_GivenString_ReturnsString()
        {
            sample.AsNullIfEmpty().Should().NotBeNull();
        }

        [Test]
        public void test_AsNullIfEmpty_GivenWhitespace_ReturnsString()
        {
            whitespace.AsNullIfEmpty().Should().NotBeNull();
        }

        [Test]
        public void test_AsNullIfEmpty_GivenEmpty_ReturnsNull()
        {
            empty.AsNullIfEmpty().Should().BeNull();
        }

        [Test]
        public void test_AsNullIfEmpty_GivenNull_ReturnsNull()
        {
            nothing.AsNullIfEmpty().Should().BeNull();
        }

        [Test]
        public void test_AsNullIfWhitespace_GivenString_ReturnsString()
        {
            sample.AsNullIfWhitespace().Should().NotBeNull();
        }

        [Test]
        public void test_AsNullIfWhitespace_GivenWhitespace_ReturnsNull()
        {
            whitespace.AsNullIfWhitespace().Should().BeNull();
        }

        [Test]
        public void test_AsNullIfWhitespace_GivenEmpty_ReturnsNull()
        {
            empty.AsNullIfWhitespace().Should().BeNull();
        }

        [Test]
        public void test_AsNullIfWhitespace_GivenNull_ReturnsNull()
        {
            nothing.AsNullIfWhitespace().Should().BeNull();
        }
    }
}
