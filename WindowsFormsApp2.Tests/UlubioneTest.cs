// <copyright file="UlubioneTest.cs">Copyright ©  2018</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Tests
{
    [TestClass]
    [PexClass(typeof(Ulubione))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UlubioneTest
    {

        [PexMethod(MaxBranches = 20000)]
        public Ulubione Constructor(string url)
        {
            Ulubione target = new Ulubione(url);
            return target;
            // TODO: dodaj asercje do metoda UlubioneTest.Constructor(String)
        }
    }
}
