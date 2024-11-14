using Speckle.Core.Models;

namespace TestAutomateFunction;

public class ObjectToCheck
{
  public string Id { get; }
  public double UValue { get; }
  public double ExpectedUValue { get; }
  public SpeckleType SpeckleType { get; }

  public ObjectToCheck(Base obj, double expectedUValue, SpeckleType speckleType)
  {
    Id = obj.id;
    ExpectedUValue = expectedUValue;
    SpeckleType = speckleType;
    var properties = obj["properties"] as Dictionary<string, object>;
    if (properties is null)
    {
      UValue = 0;
      return;
    }
    var typeParameters = properties!["Type Parameters"] as Dictionary<string, object>;
    var analyticalProperties =
      typeParameters!["Analytical Properties"] as Dictionary<string, object>;
    var u =
      analyticalProperties!["Heat Transfer Coefficient (U)"]
      as Dictionary<string, object>;
    var value = u!["value"] is double ? (double)u!["value"] : 0;
    UValue = value;
  }
}
