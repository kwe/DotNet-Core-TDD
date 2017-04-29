using System;
using Xunit;
using Kwe;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var _stack = new Harry();
            Assert.IsType<Kwe.Harry>(_stack);

        }
        [Fact]
        public void TestGetStringLength()
        {
            var _p = new Harry();
            int i = _p.GetStringLength("Hello world");
            Assert.Equal(11,i);
        }
        [Fact]
        public void TestAddTwoStrings(){
            var _p = new Harry();
            var _newString = _p.AddTwoStrings("Hello", "World");
            Assert.Equal(_newString,"HelloWorld");
        }
    }
}
