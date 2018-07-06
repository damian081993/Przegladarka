using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Microsoft.Pex.Framework.Generated;
// <copyright file="PrzegladarkaTest.favicon.g.cs">Copyright ©  2018</copyright>
// <auto-generated>
// Ten plik zawiera testy generowane automatycznie.
// Nie należy ręcznie modyfikować tego pliku.
// 
// Jeśli zawartość tego pliku stanie się nieaktualna, można go usunąć.
// Stanie się tak na przykład wtedy, gdy plik przestanie się kompilować.
// </auto-generated>
using System;

namespace WindowsFormsApp2.Tests
{
    public partial class PrzegladarkaTest
    {

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void faviconThrowsArgumentNullException427()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon((string)null, (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException605()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[Ignore]
[PexDescription("test mia\u0142 stan: path bounds exceeded")]
public void favicon383()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("Ā", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException683()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon(":", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException778()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("%", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException16()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("x", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException457()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon(":\0", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException455()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("k|\0", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException915()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("\\\0\0", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException27()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("]|\0", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException570()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("\0\0:", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException304()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("a-: ", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException628()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("b-:\r", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException471()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("i-:\r", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException77801()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("f-:\r", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException295()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("x-: ", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException626()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("a+: ", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException130()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("a+:x", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException185()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("a+:耠", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException474()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("a+:�", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException346()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("a+:‮", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException977()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("a+:", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(PrzegladarkaTest))]
[ExpectedException(typeof(UriFormatException))]
public void faviconThrowsUriFormatException181()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Image image;
      image = this.favicon("a+:�", (string)null);
      disposables.Add((IDisposable)image);
      disposables.Dispose();
    }
}
    }
}
