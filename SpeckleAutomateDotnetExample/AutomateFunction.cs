using Objects;
using Speckle.Automate.Sdk;
using Speckle.Automate.Sdk.Schema;
using Speckle.Core.Models;
using Speckle.Core.Models.Extensions;
using Speckle.Core.Models.GraphTraversal;

namespace TestAutomateFunction;

public enum SpeckleType
{
  Wall,
  Window,
  Roof,
}

public static class AutomateFunction
{
  public static async Task Run(
    AutomationContext automationContext,
    FunctionInputs functionInputs
  )
  {
    Console.WriteLine("Starting execution");
    _ = typeof(ObjectsKit).Assembly; // INFO: Force objects kit to initialize

    // 0- Get climate zone from function inputs

    // 1- Receive version from automation context

    // 2- Flatten the objects in received root object

    // 3- Get the objects we need

    // 4- Check the compliance for given object types

    // 5- Attach report to failed objects to be able to highlight them in viewer or Revit connector

    // 6- Report the automation result as SUCCESS/FAIL
    automationContext.MarkRunSuccess(
      "We are going to fail successfully in a bit, don't worry!"
    );
  }

  private static void AttachReportToFailedObjects(
    AutomationContext automationContext,
    IEnumerable<ObjectToCheck> failedObjects
  )
  {
    foreach (var failedObject in failedObjects)
    {
      var speckleTypeString = failedObject.SpeckleType.ToString();
      string message = "";
      if (failedObject.UValue == 0)
      {
        message =
          $"{speckleTypeString} has no any material that have thermal properties.";
      }
      else
      {
        message =
          $"{speckleTypeString} expected to have maximum {failedObject.ExpectedUValue} U-value but it is {failedObject.UValue}.";
      }

      automationContext.AttachResultToObjects(
        ObjectResultLevel.Error,
        speckleTypeString,
        new[] { failedObject.Id },
        message
      );
    }
  }

  private static void ReportStatus(
    AutomationContext automationContext,
    FunctionInputs functionInputs,
    int numberOfWalls,
    int numberOfFailedWalls,
    int numberOfWindows,
    int numberOfFailedWindows,
    int numberOfRoofs,
    int numberOfFailedRoofs
  )
  {
    if (numberOfFailedWalls + numberOfFailedWindows + numberOfFailedRoofs > 0)
    {
      var message = "";
      if (true) // TODO: Check the whether walls included or not from function inputs
      {
        message += "WALLS:\n";
        if (numberOfWalls > 0)
        {
          message += $"{numberOfFailedWalls}/{numberOfWalls} wall(s) failed.\n";
        }
        else
        {
          message += "There are no walls\n\n";
        }
      }
      if (true) // TODO: Check the whether windows included or not from function inputs
      {
        message += "WINDOWS:\n";
        if (numberOfWindows > 0)
        {
          message += $"{numberOfFailedWindows}/{numberOfWindows} window(s) failed.\n";
        }
        else
        {
          message += "There are no windows\n\n";
        }
      }

      if (true) // TODO: Check the whether roofs included or not from function inputs
      {
        message += "ROOFS:\n";
        if (numberOfRoofs > 0)
        {
          message += $"{numberOfFailedRoofs}/{numberOfRoofs} roof(s) failed.\n";
        }
        else
        {
          message += "There are no roofs\n\n";
        }
      }
      automationContext.MarkRunFailed(message);
    }
    else
    {
      automationContext.MarkRunSuccess(
        $"Your building is compliant with selected climate zone!"
      );
    }
  }

  private static double GetExpectedValue(
    ClimateZone climateZone,
    SpeckleType speckleType
  )
  {
    switch (speckleType)
    {
      case SpeckleType.Wall:
        return UValues.Wall[climateZone];
      case SpeckleType.Window:
        return UValues.Window[climateZone];
      case SpeckleType.Roof:
        return UValues.Roof[climateZone];
      default:
        return 0;
    }
  }

  private static IEnumerable<ObjectToCheck> CheckCompliance(
    IEnumerable<Base> objects,
    ClimateZone climateZone,
    SpeckleType speckleType
  )
  {
    var expectedValue = GetExpectedValue(climateZone, speckleType);
    var objectsToCheck = objects.Select(o => new ObjectToCheck(
      o,
      expectedValue,
      speckleType
    ));
    return objectsToCheck.Where(obj => obj.UValue > expectedValue || obj.UValue == 0);
  }

  private static ClimateZone GetClimateZone(string climateZoneString)
  {
    if (Enum.TryParse(climateZoneString, out ClimateZone climateZoneEnum))
    {
      return climateZoneEnum;
    }

    // Handle the case where the ClimateZone string is not a valid ClimateZones value
    throw new ArgumentException($"Invalid ClimateZone: {climateZoneString}");
  }
}
