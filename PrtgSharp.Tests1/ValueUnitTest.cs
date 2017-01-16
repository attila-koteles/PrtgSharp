// <copyright file="ValueUnitTest.cs">Copyright ©  2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp;

namespace PrtgSharp.Tests
{
    /// <summary>This class contains parameterized unit tests for ValueUnit</summary>
    [PexClass(typeof(ValueUnit))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ValueUnitTest
    {
    }
}
