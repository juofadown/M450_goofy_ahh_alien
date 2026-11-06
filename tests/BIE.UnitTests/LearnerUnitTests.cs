using BIE.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BIE.UnitTests;

[TestClass]
public class LearnerUnitTests
{
    [TestMethod]
    public void TouristAt30DaysIsApproved()
    {   
        //Arrange
        var entry = new Entry("Sam Test", "Orion", "Tourismus", 30, false, false, false, true);
        // TODO: Act und Assert gemäss R3 ergänzen.
        //Act
        var status = EntryPolicy.Evaluate(entry).Status;
        //Assert
        Assert.Equals(status, "approved");
        //Assert.Fail("TODO: Assertions gemäss Arbeitsauftrag ergänzen.");
    }
}
