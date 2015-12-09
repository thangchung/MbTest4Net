using System;

namespace MbTest4Net.Tests.Helpers
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TestPriorityAttribute : System.Attribute
    {
        public TestPriorityAttribute(int priority)
        {
            Priority = priority;
        }

        public int Priority { get; private set; }
    }
}