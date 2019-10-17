﻿using System.Linq;
using NUnit.Framework;

namespace ReedMullerCode.UnitTests
{
    [TestFixture]
    public class DecoderUnitTests
    {
        [TestCase(6, "1111000011110000111100001111000011110000111100001111000011110000", "1001000")]
        [TestCase(10, "1111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000000001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100000000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100000000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111111110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000111100001111000011110000", "10010000101")]
        [TestCase(12, "1111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111100001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011110000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011110000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000011110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011110000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000011110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000011110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100001111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111100001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011110000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000011110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011110000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000011110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000011110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100001111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111000011111111000011110000000011111111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100001111000000001111000011111111000000001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111100001111111100001111000000001111111100000000111100001111111100000000111111110000111100000000111111110000000011110000111111110000", "1001111010101")]
        public void Encode_Vector_Succeeds(int m, string encodedVector, string expectedDecodedVector)
        {
            var decoder = new Decoder.Decoder(m);

            var decodedVector = decoder.Decode(encodedVector.ToList().Select(c => int.Parse(c.ToString())).ToList());

            var decodedVectorString = string.Join("", decodedVector.Select(bit => bit.ToString()).ToList());

            Assert.AreEqual(expectedDecodedVector, decodedVectorString);
        }
    }
}