using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp;

namespace PrtgSharp.Tests1
{
    /// <summary>This class contains parameterized unit tests for Value</summary>
    [TestClass]
    [PexClass(typeof(Value))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ValueTest
    {

        /// <summary>Test stub for FromFloat(Single)</summary>
        [PexMethod]
        public Value FromFloatTest(float value)
        {
            Value result = Value.FromFloat(value);
            return result;
            // TODO: add assertions to method ValueTest.FromFloatTest(Single)
        }
    }
}
