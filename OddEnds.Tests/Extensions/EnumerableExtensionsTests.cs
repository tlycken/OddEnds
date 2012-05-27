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
    public class EnumerableExtensionsTests
    {
        private IEnumerable<int> nonempty = new List<int> { 1, 2, 3 }.AsEnumerable();
        private IEnumerable<int> empty = new List<int>().AsEnumerable();
        private IEnumerable<int> nothing = null;
        
        [Test]
        public void test_AsNullIfEmpty_GivenNonEmpty_ReturnsEnumerable()
        {
            nonempty.AsNullIfEmpty().Should().NotBeNull().And.ContainInOrder(new List<int>() {1, 2, 3});
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
    }
}
