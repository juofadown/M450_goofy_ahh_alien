using System.Net;
using System.Net.Http.Json;
using BIE.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bie.IntegrationTests;

[TestClass]
public class LearnerIntegrationTests
{
    [TestMethod]
    public async Task TouristAt30DaysIsSavedAsApproved()
    {   
        //Arrange
        using var app = new BieFactory();
        using var client = app.CreateClient();
        var entry = new Entry("Sam Test", "Orion", "Tourismus", 30, false, false, false, true);


        //Act
        var response = await client.PostAsJsonAsync("/api/cases", entry);
        var records = await client.GetFromJsonAsync<List<Case>>("/api/cases");

        //Assert
        // TODO: HTTP-Status, gespeicherte Werte und Entscheidung prüfen.
        Assert.Equals(response, "201");

        Assert.IsNotNull(records);
        Assert.AreEqual(records.Count, 1);
        records.

        //Assert.Fail("TODO: Assertions gemäss Arbeitsauftrag ergänzen.");
    }
}
