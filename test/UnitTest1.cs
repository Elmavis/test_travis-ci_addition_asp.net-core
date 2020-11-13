using System;
using Xunit;


namespace test
{
    public class IdProvider
    {
        public Guid NewId()
        {
            return Guid.NewGuid();
        }
    }

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var idProvider = new IdProvider();
            var id1 = idProvider.NewId();
            var id2 = idProvider.NewId();

            Assert.NotEqual(id1, id2);
        }
    }
}
