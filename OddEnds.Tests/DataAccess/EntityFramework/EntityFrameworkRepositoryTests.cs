using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using OddEnds.DataAccess;


namespace OddEnds.Tests.DataAccess.EntityFramework
{
    [TestFixture]
    public class EntityFrameworkRepositoryTests
    {
        private class FakeEntity : EntityBase
        {
            
        }

        [Test]
        public void GetByID_GivenExistingID_ReturnsTaskWithCorrectEntity()
        {


        }
    }
}
