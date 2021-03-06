using System;
using System.Globalization;
using TestLibrary;

/// <summary>
///CompareInfo
/// </summary>
public class CultureInfoCompareInfo
{
    public static int Main()
    {
        CultureInfoCompareInfo CultureInfoCompareInfo = new CultureInfoCompareInfo();

        TestLibrary.TestFramework.BeginTestCase("CultureInfoCompareInfo");
        if (CultureInfoCompareInfo.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        retVal = PosTest5() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Compare two strings using the CultureInfo  myCIintl which uses the international sort.");
        try
        {
            CultureInfo myCIintl = new CultureInfo("es-ES");;
            string compareString1 = "llegar";
            string compareString2 = "lugar";
            if (myCIintl.CompareInfo.Compare(compareString1, compareString2) != GlobLocHelper.OSCompare(compareString1, compareString2, myCIintl))
            {
                TestLibrary.TestFramework.LogError("001", "return  error");
                retVal = false;
            }
    
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest2: Compare two strings using the CultureInfo myCItrad which uses the traditional sort.");
        try
        {
            CultureInfo myCItrad = new CultureInfo("es-ES_tradnl");
            string compareString1 = "llegar";
            string compareString2 = "lugar";
            if (myCItrad.CompareInfo.Compare(compareString1, compareString2) != GlobLocHelper.OSCompare(compareString1, compareString2, myCItrad))
            {
                TestLibrary.TestFramework.LogError("003", "return  error");
                retVal = false;
            }


        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest3()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest3: CultureTypes.SpecificCultures,CompareInfo is gotten through CompareInfo property. ");
        try
        {
            
            string expectName = "en-US";
            CultureInfo myCultureInfo = new CultureInfo(expectName);
            CompareInfo myCompareInfo = myCultureInfo.CompareInfo;
            if (myCompareInfo.Name!=expectName)
            {
                TestLibrary.TestFramework.LogError("005", "return error " );
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest5()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest5: CultureInfo.InvariantCulture,CompareInfo is gotten through CompareInfo property. ");
        try
        {

            string expectName = "";
            CultureInfo myCultureInfo = new CultureInfo(expectName);
            CompareInfo myCompareInfo = myCultureInfo.CompareInfo;
            if (myCompareInfo.Name != expectName)
            {
                TestLibrary.TestFramework.LogError("009", "return error ");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("010", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
  
}

