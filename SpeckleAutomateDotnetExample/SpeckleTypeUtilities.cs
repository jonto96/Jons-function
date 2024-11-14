using Speckle.Core.Models;
using Speckle.Core.Models.GraphTraversal;

namespace TestAutomateFunction;

public class SpeckleTypeUtilities
{
  public static IEnumerable<Base> GetByType(
    IEnumerable<Base> objects,
    SpeckleType speckleType
  )
  {
    return objects.Where(b =>
      b.speckle_type == SpeckleTypes[speckleType]
      && (string)b["category"]! == SpeckleCategories[speckleType]
    );
  }

  public static IEnumerable<Base> GetByType<T>(Base root)
    where T : Base
  {
    var traversal = new GraphTraversal();
    return traversal
      .Traverse(root)
      .Where(obj => obj.Current is T)
      .Select(obj => obj.Current);
  }

  private static readonly Dictionary<SpeckleType, string> SpeckleTypes =
    new()
    {
      {
        SpeckleType.Wall,
        "Objects.BuiltElements.Wall:Objects.BuiltElements.Revit.RevitWall"
      },
      { SpeckleType.Window, "Objects.BuiltElements.Revit.RevitElement" },
      {
        SpeckleType.Roof,
        "Objects.BuiltElements.Roof:Objects.BuiltElements.Revit.RevitRoof.RevitRoof:Objects.BuiltElements.Revit.RevitRoof.RevitExtrusionRoof"
      },
    };

  private static readonly Dictionary<SpeckleType, string> SpeckleCategories =
    new()
    {
      { SpeckleType.Wall, "Walls" },
      { SpeckleType.Window, "Windows" },
      { SpeckleType.Roof, "Roofs" },
    };
}
