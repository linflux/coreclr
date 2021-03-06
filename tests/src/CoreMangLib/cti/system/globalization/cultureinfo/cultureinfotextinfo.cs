using System;
using System.Globalization;
/// <summary>
///TextInfo
/// </summary>
public class CultureInfoTextInfo
{
    public static int Main()
    {
        CultureInfoTextInfo CultureInfoTextInfo = new CultureInfoTextInfo();

        TestLibrary.TestFramework.BeginTestCase("CultureInfoTextInfo");
        if (CultureInfoTextInfo.RunTests())
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
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1:CultureTypes.SpecificCultures");
        try
        {
          
            string myLcid = new CultureInfo("en-us").Name;
            if (!myLcid.Equals( new CultureInfo("en-us").TextInfo.CultureName ) )
            {
                TestLibrary.TestFramework.LogError("001", "the licd  of 'zh-CHT' culture should equal to textInfo.LCID.");
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

        TestLibrary.TestFramework.BeginScenario("PosTest2: CultureInfo.InvariantCulture");
        try
        {

            CultureInfo ci = CultureInfo.InvariantCulture;
            {
                string myLcid = ci.Name;
                if (!ci.TextInfo.CultureName.Equals(myLcid))
                {
                    TestLibrary.TestFramework.LogError("003", "the LCID of Neutral culture textinfo should equal to the LCID of the curlture");
                    retVal = false;
                }
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

        TestLibrary.TestFramework.BeginScenario("PosTest3: invariant culture");
        try
        {

            CultureInfo myTestCulture = CultureInfo.InvariantCulture;
            if (!myTestCulture.TextInfo.CultureName.Equals(myTestCulture.Name))
            {
                TestLibrary.TestFramework.LogError("005", "the LCID of invariant culture textinfo should equal to the LCID of the curlture");
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
}

