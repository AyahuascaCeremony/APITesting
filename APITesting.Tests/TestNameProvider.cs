using APITesting.API;

namespace Tests
{
  public class TestNameProvider : IProvideTheName
  {
    private string _configuredName = "Test Name";
    public string GimmeTheName()
    {
      return _configuredName;
    }

    public void SetTestName(string name)
    {
      _configuredName = name;
    }
  }
}