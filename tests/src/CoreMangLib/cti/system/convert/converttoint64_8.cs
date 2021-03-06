using System;

/// <summary>
/// ToInt64(System.Int64)
/// </summary>

public class ConvertToInt64_8
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        
        //
        // TODO: Add your negative test cases here
        //
        // TestLibrary.TestFramework.LogInformation("[Negative]");
        // retVal = NegTest1() && retVal;

        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        // Add your scenario description here
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify method ToInt64 .");

        try
        {
            retVal = VerificationHelper(0L, 0L, "001.1") && retVal;
            retVal = VerificationHelper((long)int.MaxValue, (long)int.MaxValue, "001.2") && retVal;
            retVal = VerificationHelper((long)int.MinValue, (long)int.MinValue, "001.3") && retVal;

            long l = TestLibrary.Generator.GetInt64(-55);
            retVal = VerificationHelper(l, l, "001.4") && retVal;
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }
    #endregion

    #region Nagetive Test Cases
    //public bool NegTest1()
    //{
    //    bool retVal = true;

    //    TestLibrary.TestFramework.BeginScenario("NegTest1: ");

    //    try
    //    {
    //          //
    //          // Add your test logic here
    //          //
    //    }
    //    catch (Exception e)
    //    {
    //        TestLibrary.TestFramework.LogError("101", "Unexpected exception: " + e);
    //        TestLibrary.TestFramework.LogInformation(e.StackTrace);
    //        retVal = false;
    //    }

    //    return retVal;
    //}
    #endregion
    #endregion

    public static int Main()
    {
        ConvertToInt64_8 test = new ConvertToInt64_8();

        TestLibrary.TestFramework.BeginTestCase("ConvertToInt64_8");

        if (test.RunTests())
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

    #region Private Methods
    private bool VerificationHelper(long value, long desired, string errorno)
    {
        bool retVal = true;

        long actual = Convert.ToInt64(value);
        if (actual != desired)
        {
            TestLibrary.TestFramework.LogError(errorno, "Convert.ToInt32 returns unexpected values");
            TestLibrary.TestFramework.LogInformation("WARNING [LOCAL VARIABLE] actual = " + actual + ", desired = " + desired + ", value = " + value);
            retVal = false;
        }

        return retVal;
    }
    #endregion
}
