﻿using NeinMath.Xunit;
using Xunit;

namespace NeinMath.Tests
{
    public class IntegerConverterTest
    {
        [Theory]
        [IntegerData]
        public void ToByteArray(Integer value, byte[] expected)
        {
            using (Immutability.Guard(value))
            {
                var actual = value.ToByteArray();

                Assert.Equal(expected, actual);
            }
        }

        [Theory]
        [IntegerData]
        public void FromByteArray(byte[] value, Integer expected)
        {
            var actual = IntegerConverter.FromByteArray(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [IntegerData]
        public void ToDecimalString(Integer value, string expected)
        {
            using (Immutability.Guard(value))
            {
                var actual = value.ToDecimalString();

                Assert.Equal(expected, actual);
            }
        }

        [Theory]
        [IntegerData]
        public void FromDecimalString(string value, Integer expected)
        {
            var actual = IntegerConverter.FromDecimalString(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [IntegerData]
        public void ToHexString(Integer value, string expected)
        {
            using (Immutability.Guard(value))
            {
                var actual = value.ToHexString();

                Assert.Equal(expected, actual);
            }
        }

        [Theory]
        [IntegerData]
        public void FromHexString(string value, Integer expected)
        {
            var actual = IntegerConverter.FromHexString(value);

            Assert.Equal(expected, actual);
        }
    }
}
