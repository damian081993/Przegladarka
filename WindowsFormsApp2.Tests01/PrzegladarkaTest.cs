using System.Threading;
// <copyright file="PrzegladarkaTest.cs">Copyright ©  2018</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Tests
{
    [TestClass]
    [PexClass(typeof(Przegladarka))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PrzegladarkaTest
    {

        [PexMethod]
        [PexAllowedException(typeof(ThreadStateException))]
        public Przegladarka Constructor()
        {
            Przegladarka target = new Przegladarka();
            return target;
            // TODO: dodaj asercje do metoda PrzegladarkaTest.Constructor()
        }
    }
}
