using System.Drawing;
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

        [PexMethod(MaxConditions = 1000)]
        [PexAllowedException(typeof(ArgumentNullException))]
        [PexAllowedException(typeof(UriFormatException))]
        public Image favicon(string u, string file)
        {
            Image result = Przegladarka.favicon(u, file);
            return result;
            // TODO: dodaj asercje do metoda PrzegladarkaTest.favicon(String, String)
        }
    }
}
