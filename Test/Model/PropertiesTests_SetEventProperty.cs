﻿using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostHog.Model;

namespace Test.Model
{
    [TestClass]
    public class PropertiesTests_SetEventProperty_ShouldHaveValidValue
    {
        [TestMethod]
        public void PropertiesTests_SetEventProperty_ShouldAddEventProperty()
        {
            var properties = new Properties().SetEventProperty("key", "value");
            
            properties.Should().HaveCount(1);
            properties.First().Key.Should().Be("key");
            properties.First().Value.Should().Be("value");
        }

        [TestMethod]
        public void PropertiesTests_SetEventProperty_ShouldAllowOverridingValuesWithSameKey()
        {
            var properties = new Properties().SetEventProperty("key", "value").SetEventProperty("key", "different value");

            properties.Should().HaveCount(1);
            properties.Should().ContainKey("key");
            properties.Should().ContainValue("different value");
        }
    }
}
