Imports NUnit.Framework

<TestFixture()>
Public Class TestClass1

    'Run when begin of All of Test
    <TestFixtureSetUp()>
    Public Sub SetUp()

    End Sub

    'Run when end of All of Test
    <TestFixtureTearDown()>
    Public Sub TearDown()

    End Sub

    'Run when begin of each Test
    <SetUp()>
    Public Sub EachSetUp()

    End Sub

    'Run when end of each Test
    <SetUp()>
    Public Sub EachTearDown()

    End Sub

    <Test()>
    Public Sub DoTest()

        Assert.AreEqual(1, 1)

    End Sub


End Class
