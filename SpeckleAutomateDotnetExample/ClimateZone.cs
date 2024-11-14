namespace TestAutomateFunction;

public enum ClimateZone
{
  // Tropical Climates
  Af_TropicalRainforest,
  Am_TropicalMonsoon,
  Aw_TropicalSavanna,
  As_TropicalSavanna,

  // Dry Climates
  BWh_HotDesert,
  BWk_ColdDesert,
  BSh_HotSemiArid,
  BSk_ColdSemiArid,

  // Temperate Climates
  Cfa_HumidSubtropical,
  Cfb_Oceanic,
  Cfc_SubpolarOceanic,
  Csa_MediterraneanHotSummer,
  Csb_MediterraneanWarmSummer,
  Csc_MediterraneanCoolSummer,

  // Continental Climates
  Dfa_HumidContinentalHotSummer,
  Dfb_HumidContinentalMildSummer,
  Dfc_Subarctic,
  Dfd_SubarcticExtremeWinter,
  Dsa_MediterraneanInfluenceSnowyWinter,
  Dsb_MediterraneanInfluenceSnowyWinter,
  Dsc_MediterraneanInfluenceSnowyWinter,
  Dsd_MediterraneanInfluenceSnowyWinter,

  // Polar Climates
  ET_Tundra,
  EF_IceCap,
}

public static class UValues
{
  public static Dictionary<ClimateZone, double> Window =>
    new()
    {
      // Tropical Climates
      { ClimateZone.Af_TropicalRainforest, 0.9 },
      { ClimateZone.Am_TropicalMonsoon, 1.0 },
      { ClimateZone.Aw_TropicalSavanna, 1.1 },
      { ClimateZone.As_TropicalSavanna, 1.1 },
      // Dry Climates
      { ClimateZone.BWh_HotDesert, 1.0 },
      { ClimateZone.BWk_ColdDesert, 1.2 },
      { ClimateZone.BSh_HotSemiArid, 1.2 },
      { ClimateZone.BSk_ColdSemiArid, 1.5 },
      // Temperate Climates
      { ClimateZone.Cfa_HumidSubtropical, 1.4 },
      { ClimateZone.Cfb_Oceanic, 1.3 },
      { ClimateZone.Cfc_SubpolarOceanic, 1.2 },
      { ClimateZone.Csa_MediterraneanHotSummer, 1.51 },
      { ClimateZone.Csb_MediterraneanWarmSummer, 1.4 },
      { ClimateZone.Csc_MediterraneanCoolSummer, 1.3 },
      // Continental Climates
      { ClimateZone.Dfa_HumidContinentalHotSummer, 1.3 },
      { ClimateZone.Dfb_HumidContinentalMildSummer, 1.2 },
      { ClimateZone.Dfc_Subarctic, 0.7 },
      { ClimateZone.Dfd_SubarcticExtremeWinter, 0.6 },
      { ClimateZone.Dsa_MediterraneanInfluenceSnowyWinter, 1.2 },
      { ClimateZone.Dsb_MediterraneanInfluenceSnowyWinter, 1.1 },
      { ClimateZone.Dsc_MediterraneanInfluenceSnowyWinter, 0.9 },
      { ClimateZone.Dsd_MediterraneanInfluenceSnowyWinter, 0.8 },
      // Polar Climates
      { ClimateZone.ET_Tundra, 0.5 },
      { ClimateZone.EF_IceCap, 0.4 },
    };

  public static Dictionary<ClimateZone, double> Wall =>
    new()
    {
      // Tropical Climates
      { ClimateZone.Af_TropicalRainforest, 0.8 },
      { ClimateZone.Am_TropicalMonsoon, 0.8 },
      { ClimateZone.Aw_TropicalSavanna, 0.9 },
      { ClimateZone.As_TropicalSavanna, 0.9 },
      // Dry Climates
      { ClimateZone.BWh_HotDesert, 0.7 },
      { ClimateZone.BWk_ColdDesert, 0.9 },
      { ClimateZone.BSh_HotSemiArid, 0.8 },
      { ClimateZone.BSk_ColdSemiArid, 0.85 },
      // Temperate Climates
      { ClimateZone.Cfa_HumidSubtropical, 0.6 },
      { ClimateZone.Cfb_Oceanic, 0.7 },
      { ClimateZone.Cfc_SubpolarOceanic, 0.75 },
      { ClimateZone.Csa_MediterraneanHotSummer, 0.55 },
      { ClimateZone.Csb_MediterraneanWarmSummer, 0.65 },
      { ClimateZone.Csc_MediterraneanCoolSummer, 0.7 },
      // Continental Climates
      { ClimateZone.Dfa_HumidContinentalHotSummer, 0.75 },
      { ClimateZone.Dfb_HumidContinentalMildSummer, 0.8 },
      { ClimateZone.Dfc_Subarctic, 0.5 },
      { ClimateZone.Dfd_SubarcticExtremeWinter, 0.45 },
      { ClimateZone.Dsa_MediterraneanInfluenceSnowyWinter, 0.7 },
      { ClimateZone.Dsb_MediterraneanInfluenceSnowyWinter, 0.65 },
      { ClimateZone.Dsc_MediterraneanInfluenceSnowyWinter, 0.55 },
      { ClimateZone.Dsd_MediterraneanInfluenceSnowyWinter, 0.5 },
      // Polar Climates
      { ClimateZone.ET_Tundra, 0.3 },
      { ClimateZone.EF_IceCap, 0.25 },
    };

  public static Dictionary<ClimateZone, double> Roof =>
    new()
    {
      // Tropical Climates
      { ClimateZone.Af_TropicalRainforest, 1.2 },
      { ClimateZone.Am_TropicalMonsoon, 1.3 },
      { ClimateZone.Aw_TropicalSavanna, 1.4 },
      { ClimateZone.As_TropicalSavanna, 1.4 },
      // Dry Climates
      { ClimateZone.BWh_HotDesert, 1.1 },
      { ClimateZone.BWk_ColdDesert, 1.3 },
      { ClimateZone.BSh_HotSemiArid, 1.2 },
      { ClimateZone.BSk_ColdSemiArid, 1.3 },
      // Temperate Climates
      { ClimateZone.Cfa_HumidSubtropical, 1.1 },
      { ClimateZone.Cfb_Oceanic, 1.0 },
      { ClimateZone.Cfc_SubpolarOceanic, 0.9 },
      { ClimateZone.Csa_MediterraneanHotSummer, 1.2 },
      { ClimateZone.Csb_MediterraneanWarmSummer, 1.1 },
      { ClimateZone.Csc_MediterraneanCoolSummer, 1.0 },
      // Continental Climates
      { ClimateZone.Dfa_HumidContinentalHotSummer, 1.0 },
      { ClimateZone.Dfb_HumidContinentalMildSummer, 0.9 },
      { ClimateZone.Dfc_Subarctic, 0.6 },
      { ClimateZone.Dfd_SubarcticExtremeWinter, 0.5 },
      { ClimateZone.Dsa_MediterraneanInfluenceSnowyWinter, 0.9 },
      { ClimateZone.Dsb_MediterraneanInfluenceSnowyWinter, 0.8 },
      { ClimateZone.Dsc_MediterraneanInfluenceSnowyWinter, 0.7 },
      { ClimateZone.Dsd_MediterraneanInfluenceSnowyWinter, 0.6 },
      // Polar Climates
      { ClimateZone.ET_Tundra, 0.4 },
      { ClimateZone.EF_IceCap, 0.35 },
    };
}
