

using System.Runtime.InteropServices;

#if !USING_NET11
using System.Runtime.InteropServices.ComTypes;
using System;
#endif

namespace Telerik.WinControls.UI.Multimedia
{
    #region Declarations

    [ComImport, Guid("5FFDC5E6-B83A-4b55-B6E8-C69E765FE9DB")]
    internal class TuningSpace
    {
    }

    [ComImport, Guid("8A674B4C-1F63-11d3-B64C-00C04F79498E")]
    internal class AnalogRadioTuningSpace
    {
    }

    [ComImport, Guid("F9769A06-7ACA-4e39-9CFB-97BB35F0E77E")]
    internal class AuxInTuningSpace
    {
    }

    [ComImport, Guid("8A674B4D-1F63-11d3-B64C-00C04F79498E")]
    internal class AnalogTVTuningSpace
    {
    }

    [ComImport, Guid("1BE49F30-0E1B-11d3-9D8E-00C04F72D980")]
    internal class LanguageComponentType
    {
    }

    [ComImport, Guid("418008F3-CF67-4668-9628-10DC52BE1D08")]
    internal class MPEG2ComponentType
    {
    }

    [ComImport, Guid("A8DCF3D5-0780-4ef4-8A83-2CFFAACB8ACE")]
    internal class ATSCComponentType
    {
    }

    [ComImport, Guid("809B6661-94C4-49e6-B6EC-3F0F862215AA")]
    internal class Components
    {
    }

    [ComImport, Guid("59DC47A8-116C-11d3-9D8E-00C04F72D980")]
    internal class Component
    {
    }

    [ComImport, Guid("055CB2D7-2969-45cd-914B-76890722F112")]
    internal class MPEG2Component
    {
    }

    [ComImport, Guid("B46E0D38-AB35-4a06-A137-70576B01B39F")]
    internal class TuneRequest
    {
    }

    [ComImport, Guid("0369B4E5-45B6-11d3-B650-00C04F79498E")]
    internal class ChannelTuneRequest
    {
    }

    [ComImport, Guid("0369B4E6-45B6-11d3-B650-00C04F79498E")]
    internal class ATSCChannelTuneRequest
    {
    }

    [ComImport, Guid("0955AC62-BF2E-4cba-A2B9-A63F772D46CF")]
    internal class MPEG2TuneRequest
    {
    }

    [ComImport, Guid("0888C883-AC4F-4943-B516-2C38D9B34562")]
    internal class Locator
    {
    }

    [ComImport, Guid("8872FF1B-98FA-4d7a-8D93-C9F1055F85BB")]
    internal class ATSCLocator
    {
    }

    [ComImport, Guid("C531D9FD-9685-4028-8B68-6E1232079F1E")]
    internal class DVBCLocator
    {
    }

    [ComImport, Guid("15D6504A-5494-499c-886C-973C9E53B9F1")]
    internal class DVBTuneRequest
    {
    }

    [ComImport, Guid("A1A2B1C4-0E3A-11d3-9D8E-00C04F72D980")]
    internal class ComponentTypes
    {
    }

    [ComImport, Guid("823535A0-0318-11d3-9D8E-00C04F72D980")]
    internal class ComponentType
    {
    }

    [ComImport, Guid("A2E30750-6C3D-11d3-B653-00C04F79498E")]
    internal class ATSCTuningSpace
    {
    }

    [ComImport, Guid("C6B14B32-76AA-4a86-A7AC-5C79AAF58DA7")]
    internal class DVBTuningSpace
    {
    }

    [ComImport, Guid("B64016F3-C9A2-4066-96F0-BD9563314726")]
    internal class DVBSTuningSpace
    {
    }

    [ComImport, Guid("9CD64701-BDF3-4d14-8E03-F12983D86664")]
    internal class DVBTLocator
    {
    }

    [ComImport, Guid("1DF7D126-4050-47f0-A7CF-4C4CA9241333")]
    internal class DVBSLocator
    {
    }

    [ComImport, Guid("8A674B49-1F63-11d3-B64C-00C04F79498E")]
    internal class CreatePropBagOnRegKey
    {
    }

    [ComImport, Guid("D02AAC50-027E-11d3-9D8E-00C04F72D980")]
    internal class SystemTuningSpaces
    {
    }

    [ComImport, Guid("2C63E4EB-4CEA-41b8-919C-E947EA19A77C")]
    internal class MPEG2TuneRequestFactory
    {
    }
    #endregion

    #region Interfaces

#if ALLOW_UNTESTED_INTERFACES

    [ComImport,
    Guid("359B3901-572C-4854-BB49-CDEF66606A25"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IRegisterTuner
    {
        int Register(
            ITuner pTuner,
            IGraphBuilder pGraph
            );

        int Unregister();
    }

    [ComImport,
    Guid("39DD45DA-2DA8-46BA-8A8A-87E2B73D983A"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IAnalogRadioTuningSpace2 : IAnalogRadioTuningSpace
    {
        #region ITuningSpace Methods

        [PreserveSig]
        new int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        new int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        new int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        new int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        new int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        new int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        new int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        new int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        new int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        new int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        new int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        new int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        new int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        new int Clone([Out] out ITuningSpace NewTS);

        #endregion

        #region IAnalogRadioTuningSpace Methods

        [PreserveSig]
        new int get_MinFrequency([Out] out int MinFrequencyVal);

        [PreserveSig]
        new int put_MinFrequency([In] int NewMinFrequencyVal);

        [PreserveSig]
        new int get_MaxFrequency([Out] out int MaxFrequencyVal);

        [PreserveSig]
        new int put_MaxFrequency([In] int NewMaxFrequencyVal);

        [PreserveSig]
        new int get_Step([Out] out int StepVal);

        [PreserveSig]
        new int put_Step([In] int StepVal);

        #endregion

        int get_CountryCode(
            out int CountryCodeVal
            );

        int put_CountryCode(
            int NewCountryCodeVal
            );
    }

    [ComImport,
    Guid("B10931ED-8BFE-4AB0-9DCE-E469C29A9729"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IAuxInTuningSpace2 : IAuxInTuningSpace
    {
        #region ITuningSpace Methods

        [PreserveSig]
        new int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        new int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        new int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        new int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        new int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        new int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        new int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        new int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        new int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        new int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        new int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        new int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        new int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        new int Clone([Out] out ITuningSpace NewTS);

        #endregion

        int get_CountryCode(
            out int CountryCodeVal);

        int put_CountryCode(
            int NewCountryCodeVal
            );
    }

    [ComImport,
    Guid("2A6E293B-2595-11d3-B64C-00C04F79498E"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IAnalogRadioTuningSpace : ITuningSpace
    {
        #region ITuningSpace Methods

        [PreserveSig]
        new int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        new int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        new int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        new int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        new int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        new int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        new int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        new int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        new int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        new int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        new int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        new int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        new int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        new int Clone([Out] out ITuningSpace NewTS);

        #endregion

        [PreserveSig]
        int get_MinFrequency([Out] out int MinFrequencyVal);

        [PreserveSig]
        int put_MinFrequency([In] int NewMinFrequencyVal);

        [PreserveSig]
        int get_MaxFrequency([Out] out int MaxFrequencyVal);

        [PreserveSig]
        int put_MaxFrequency([In] int NewMaxFrequencyVal);

        [PreserveSig]
        int get_Step([Out] out int StepVal);

        [PreserveSig]
        int put_Step([In] int StepVal);
    }

    [ComImport,
    Guid("1DFD0A5C-0284-11d3-9D8E-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IScanningTuner : ITuner
    {
        #region ITuner Methods

        [PreserveSig]
        new int get_TuningSpace([Out] out ITuningSpace TuningSpace);

        [PreserveSig]
        new int put_TuningSpace([In] ITuningSpace TuningSpace);

        [PreserveSig]
        new int EnumTuningSpaces([Out] out IEnumTuningSpaces ppEnum);

        [PreserveSig]
        new int get_TuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int put_TuneRequest([In] ITuneRequest TuneRequest);

        [PreserveSig]
        new int Validate([In] ITuneRequest TuneRequest);

        [PreserveSig]
        new int get_PreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_PreferredComponentTypes([In] IComponentTypes ComponentTypes);

        [PreserveSig]
        new int get_SignalStrength([Out] out int Strength);

        [PreserveSig]
        new int TriggerSignalEvents([In] int Interval);

        #endregion

        [PreserveSig]
        int SeekUp();

        [PreserveSig]
        int SeekDown();

        [PreserveSig]
        int ScanUp([In] int MillisecondsPause);

        [PreserveSig]
        int ScanDown([Out] out int MillisecondsPause);

        [PreserveSig]
        int AutoProgram();
    }

  [ComImport,
   Guid("E60DFA45-8D56-4e65-A8AB-D6BE9412C249"),
  InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  internal interface ITunerCap
  {
    [PreserveSig]
    int SupportedNetworkTypes(
      [In] int ulcNetworkTypesMax,
      [Out] out int pulcNetworkTypes,
      [In, Out] Guid[] pguidNetworkTypes
      );

    [PreserveSig]
    int SupportedVideoFormats(
      [Out] out int pulAMTunerModeType,
      [Out] out int pulAnalogVideoStandard
      );

    [PreserveSig]
    int AuxInputCount(
      [Out] out int pulCompositeCount,
      [Out] out int pulSvideoCount
      );
  }

#endif

    [ComImport,
    Guid("061C6E30-E622-11d2-9493-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface ITuningSpace
    {
        [PreserveSig]
        int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        int Clone([Out] out ITuningSpace NewTS);
    }

    [ComImport,
    Guid("28C52640-018A-11d3-9D8E-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ITuner
    {
        [PreserveSig]
        int get_TuningSpace([Out] out ITuningSpace TuningSpace);

        [PreserveSig]
        int put_TuningSpace([In] ITuningSpace TuningSpace);

        [PreserveSig]
        int EnumTuningSpaces([Out] out IEnumTuningSpaces ppEnum);

        [PreserveSig]
        int get_TuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        int put_TuneRequest([In] ITuneRequest TuneRequest);

        [PreserveSig]
        int Validate([In] ITuneRequest TuneRequest);

        [PreserveSig]
        int get_PreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        int put_PreferredComponentTypes([In] IComponentTypes ComponentTypes);

        [PreserveSig]
        int get_SignalStrength([Out] out int Strength);

        [PreserveSig]
        int TriggerSignalEvents([In] int Interval);
    }

    [ComImport,
    Guid("07DDC146-FC3D-11d2-9D8C-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface ITuneRequest
    {
        [PreserveSig]
        int get_TuningSpace([Out] out ITuningSpace TuningSpace);

        [PreserveSig]
        int get_Components([Out] out IComponents Components);

        [PreserveSig]
        int Clone([Out] out ITuneRequest NewTuneRequest);

        [PreserveSig]
        int get_Locator([Out] out ILocator Locator);

        [PreserveSig]
        int put_Locator([In] ILocator Locator);
    }

    [ComImport,
    Guid("3D7C353C-0D04-45f1-A742-F97CC1188DC8"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IDVBSLocator : ILocator
    {
        #region ILocator Methods

        [PreserveSig]
        new int get_CarrierFrequency([Out] out int Frequency);

        [PreserveSig]
        new int put_CarrierFrequency([In] int Frequency);

        [PreserveSig]
        new int get_InnerFEC([Out] out FECMethod FEC);

        [PreserveSig]
        new int put_InnerFEC([In] FECMethod FEC);

        [PreserveSig]
        new int get_InnerFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int put_InnerFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int get_OuterFEC([Out] out FECMethod FEC);

        [PreserveSig]
        new int put_OuterFEC([In] FECMethod FEC);

        [PreserveSig]
        new int get_OuterFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int put_OuterFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int get_Modulation([Out] out ModulationType Modulation);

        [PreserveSig]
        new int put_Modulation([In] ModulationType Modulation);

        [PreserveSig]
        new int get_SymbolRate([Out] out int Rate);

        [PreserveSig]
        new int put_SymbolRate([In] int Rate);

        [PreserveSig]
        new int Clone([Out] out ILocator NewLocator);

        #endregion

        [PreserveSig]
        int get_SignalPolarisation([Out] out Polarisation PolarisationVal);

        [PreserveSig]
        int put_SignalPolarisation([In] Polarisation PolarisationVal);

        [PreserveSig]
        int get_WestPosition([Out, MarshalAs(UnmanagedType.VariantBool)] out bool WestLongitude);

        [PreserveSig]
        int put_WestPosition([In, MarshalAs(UnmanagedType.VariantBool)] bool WestLongitude);

        [PreserveSig]
        int get_OrbitalPosition([Out] out int longitude);

        [PreserveSig]
        int put_OrbitalPosition([In] int longitude);

        [PreserveSig]
        int get_Azimuth([Out] out int Azimuth);

        [PreserveSig]
        int put_Azimuth([In] int Azimuth);

        [PreserveSig]
        int get_Elevation([Out] out int Elevation);

        [PreserveSig]
        int put_Elevation([In] int Elevation);
    }

    [ComImport,
    Guid("CDF7BE60-D954-42fd-A972-78971958E470"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IDVBSTuningSpace : IDVBTuningSpace2
    {
        #region ITuningSpace Methods

        [PreserveSig]
        new int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        new int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        new int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        new int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        new int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        new int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        new int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        new int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        new int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        new int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        new int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        new int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        new int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        new int Clone([Out] out ITuningSpace NewTS);

        #endregion

        #region IDVBTuningSpace Methods

        [PreserveSig]
        new int get_SystemType([Out] out DVBSystemType SysType);

        [PreserveSig]
        new int put_SystemType([In] DVBSystemType SysType);

        #endregion

        #region IDVBTuningSpace2 Methods

        [PreserveSig]
        new int get_NetworkID([Out] out int NetworkID);

        [PreserveSig]
        new int put_NetworkID([In] int NetworkID);

        #endregion

        [PreserveSig]
        int get_LowOscillator([Out] out int LowOscillator);

        [PreserveSig]
        int put_LowOscillator([In] int LowOscillator);

        [PreserveSig]
        int get_HighOscillator([Out] out int HighOscillator);

        [PreserveSig]
        int put_HighOscillator([In] int HighOscillator);

        [PreserveSig]
        int get_LNBSwitch([Out] out int LNBSwitch);

        [PreserveSig]
        int put_LNBSwitch([In] int LNBSwitch);

        [PreserveSig]
        int get_InputRange([Out, MarshalAs(UnmanagedType.BStr)] out string InputRange);

        [PreserveSig]
        int put_InputRange([Out, MarshalAs(UnmanagedType.BStr)] string InputRange);

        [PreserveSig]
        int get_SpectralInversion([Out] out SpectralInversion SpectralInversionVal);

        [PreserveSig]
        int put_SpectralInversion([In] SpectralInversion SpectralInversionVal);
    }

    [ComImport,
    Guid("286D7F89-760C-4F89-80C4-66841D2507AA"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface ILocator
    {
        [PreserveSig]
        int get_CarrierFrequency([Out] out int Frequency);

        [PreserveSig]
        int put_CarrierFrequency([In] int Frequency);

        [PreserveSig]
        int get_InnerFEC([Out] out FECMethod FEC);

        [PreserveSig]
        int put_InnerFEC([In] FECMethod FEC);

        [PreserveSig]
        int get_InnerFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        int put_InnerFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        int get_OuterFEC([Out] out FECMethod FEC);

        [PreserveSig]
        int put_OuterFEC([In] FECMethod FEC);

        [PreserveSig]
        int get_OuterFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        int put_OuterFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        int get_Modulation([Out] out ModulationType Modulation);

        [PreserveSig]
        int put_Modulation([In] ModulationType Modulation);

        [PreserveSig]
        int get_SymbolRate([Out] out int Rate);

        [PreserveSig]
        int put_SymbolRate([In] int Rate);

        [PreserveSig]
        int Clone([Out] out ILocator NewLocator);
    }

    [ComImport,
    Guid("ADA0B268-3B19-4e5b-ACC4-49F852BE13BA"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IDVBTuningSpace : ITuningSpace
    {
        #region ITuningSpace Methods

        [PreserveSig]
        new int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        new int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        new int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        new int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        new int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        new int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        new int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        new int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        new int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        new int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        new int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        new int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        new int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        new int Clone([Out] out ITuningSpace NewTS);

        #endregion

        [PreserveSig]
        int get_SystemType([Out] out DVBSystemType SysType);

        [PreserveSig]
        int put_SystemType([In] DVBSystemType SysType);
    }

    [ComImport,
    Guid("843188B4-CE62-43db-966B-8145A094E040"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IDVBTuningSpace2 : IDVBTuningSpace
    {
        #region ITuningSpace Methods

        [PreserveSig]
        new int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        new int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        new int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        new int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        new int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        new int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        new int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        new int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        new int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        new int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        new int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        new int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        new int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        new int Clone([Out] out ITuningSpace NewTS);

        #endregion

        #region IDVBTuningSpace Methods

        [PreserveSig]
        new int get_SystemType([Out] out DVBSystemType SysType);

        [PreserveSig]
        new int put_SystemType([In] DVBSystemType SysType);

        #endregion

        [PreserveSig]
        int get_NetworkID([Out] out int NetworkID);

        [PreserveSig]
        int put_NetworkID([In] int NetworkID);
    }

    [ComImport,
    Guid("8B8EB248-FC2B-11d2-9D8C-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IEnumTuningSpaces
    {
        int Next(
            [In] int celt,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ITuningSpace[] rgelt,
            [Out] out int pceltFetched
            );

        int Skip([In] int celt);

        int Reset();

        int Clone([Out] out IEnumTuningSpaces ppEnum);
    }

    [ComImport,
    Guid("901284E4-33FE-4b69-8D63-634A596F3756"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface ITuningSpaces
    {
        [PreserveSig]
        int get_Count([Out] out int Count);

        [PreserveSig]
#if USING_NET11
        int get__NewEnum([Out] out UCOMIEnumVARIANT ppNewEnum);
#else
        int get__NewEnum([Out] out IEnumVARIANT ppNewEnum);
#endif

        [PreserveSig]
        int get_Item(
            [In] object varIndex,
            [Out] out ITuningSpace TuningSpace
            );

        [PreserveSig]
        int get_EnumTuningSpaces([Out] out IEnumTuningSpaces NewEnum);
    }

    [ComImport,
    Guid("0D6F567E-A636-42bb-83BA-CE4C1704AFA2"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IDVBTuneRequest : ITuneRequest
    {
        #region ITuneRequest Methods

        [PreserveSig]
        new int get_TuningSpace([Out] out ITuningSpace TuningSpace);

        [PreserveSig]
        new int get_Components([Out] out IComponents Components);

        [PreserveSig]
        new int Clone([Out] out ITuneRequest NewTuneRequest);

        [PreserveSig]
        new int get_Locator([Out] out ILocator Locator);

        [PreserveSig]
        new int put_Locator([In] ILocator Locator);

        #endregion

        [PreserveSig]
        int get_ONID([Out] out int ONID);

        [PreserveSig]
        int put_ONID([In] int ONID);

        [PreserveSig]
        int get_TSID([Out] out int TSID);

        [PreserveSig]
        int put_TSID([In] int TSID);

        [PreserveSig]
        int get_SID([Out] out int SID);

        [PreserveSig]
        int put_SID([In] int SID);
    }

    [ComImport,
    Guid("8664DA16-DDA2-42ac-926A-C18F9127C302"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IDVBTLocator : ILocator
    {
        #region ILocator Methods

        [PreserveSig]
        new int get_CarrierFrequency([Out] out int Frequency);

        [PreserveSig]
        new int put_CarrierFrequency([In] int Frequency);

        [PreserveSig]
        new int get_InnerFEC([Out] out FECMethod FEC);

        [PreserveSig]
        new int put_InnerFEC([In] FECMethod FEC);

        [PreserveSig]
        new int get_InnerFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int put_InnerFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int get_OuterFEC([Out] out FECMethod FEC);

        [PreserveSig]
        new int put_OuterFEC([In] FECMethod FEC);

        [PreserveSig]
        new int get_OuterFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int put_OuterFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int get_Modulation([Out] out ModulationType Modulation);

        [PreserveSig]
        new int put_Modulation([In] ModulationType Modulation);

        [PreserveSig]
        new int get_SymbolRate([Out] out int Rate);

        [PreserveSig]
        new int put_SymbolRate([In] int Rate);

        [PreserveSig]
        new int Clone([Out] out ILocator NewLocator);

        #endregion

        [PreserveSig]
        int get_Bandwidth([Out] out int BandwidthVal);

        [PreserveSig]
        int put_Bandwidth([In] int BandwidthVal);

        [PreserveSig]
        int get_LPInnerFEC([Out] out FECMethod FEC);

        [PreserveSig]
        int put_LPInnerFEC([In] FECMethod FEC);

        [PreserveSig]
        int get_LPInnerFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        int put_LPInnerFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        int get_HAlpha([Out] out HierarchyAlpha Alpha);

        [PreserveSig]
        int put_HAlpha([In] HierarchyAlpha Alpha);

        [PreserveSig]
        int get_Guard([Out] out GuardInterval GI);

        [PreserveSig]
        int put_Guard([In] GuardInterval GI);

        [PreserveSig]
        int get_Mode([Out] out TransmissionMode mode);

        [PreserveSig]
        int put_Mode([In] TransmissionMode mode);

        [PreserveSig]
        int get_OtherFrequencyInUse([Out, MarshalAs(UnmanagedType.VariantBool)] out bool OtherFrequencyInUseVal);

        [PreserveSig]
        int put_OtherFrequencyInUse([In, MarshalAs(UnmanagedType.VariantBool)] bool OtherFrequencyInUseVal);
    }

    [ComImport,
    Guid("8A674B4A-1F63-11d3-B64C-00C04F79498E"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IEnumComponentTypes
    {
        int Next(
            [In] int celt,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] IComponentType [] rgelt,
            [Out] out int pceltFetched
            );

        int Skip([In] int celt);

        int Reset();

        int Clone([Out] out IEnumComponentTypes ppEnum);
    }

    [ComImport,
    Guid("6A340DC0-0311-11d3-9D8E-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IComponentType
    {
        [PreserveSig]
        int get_Category(
            [Out] out ComponentCategory Category
            );

        [PreserveSig]
        int put_Category(
            [In] ComponentCategory Category
            );

        [PreserveSig]
        int get_MediaMajorType(
            [Out, MarshalAs(UnmanagedType.BStr)] out string MediaMajorType
            );

        [PreserveSig]
        int put_MediaMajorType(
            [In, MarshalAs(UnmanagedType.BStr)] string MediaMajorType
            );

        [PreserveSig]
        int get__MediaMajorType(
            [Out] out Guid MediaMajorType
            );

        [PreserveSig]
        int put__MediaMajorType(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaMajorType
            );

        [PreserveSig]
        int get_MediaSubType(
            [Out, MarshalAs(UnmanagedType.BStr)] out string MediaSubType
            );

        [PreserveSig]
        int put_MediaSubType(
            [In, MarshalAs(UnmanagedType.BStr)] string MediaSubType
            );

        [PreserveSig]
        int get__MediaSubType(
            [Out] out Guid MediaSubType
            );

        [PreserveSig]
        int put__MediaSubType(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaSubType
            );

        [PreserveSig]
        int get_MediaFormatType(
            [Out, MarshalAs(UnmanagedType.BStr)] out string MediaFormatType
            );

        [PreserveSig]
        int put_MediaFormatType(
            [In, MarshalAs(UnmanagedType.BStr)] string MediaFormatType
            );

        [PreserveSig]
        int get__MediaFormatType(
            [Out] out Guid MediaFormatType
            );

        [PreserveSig]
        int put__MediaFormatType(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaFormatType
            );

        [PreserveSig]
        int get_MediaType(
            [Out] AMMediaType MediaType
            );

        [PreserveSig]
        int put_MediaType(
            [In] AMMediaType MediaType
            );

        [PreserveSig]
        int Clone(
            [Out] out IComponentType NewCT
            );
    }

    [ComImport,
    Guid("0DC13D4A-0313-11d3-9D8E-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IComponentTypes
    {
        [PreserveSig]
        int get_Count(
            [Out] out int Count
            );

        [PreserveSig]
        int get__NewEnum(
#if USING_NET11
            [Out] out UCOMIEnumVARIANT ppNewEnum
#else
            [Out] out IEnumVARIANT ppNewEnum
#endif
            );

        [PreserveSig]
        int EnumComponentTypes(
            [Out] out IEnumComponentTypes ppNewEnum
            );

        [PreserveSig]
        int get_Item(
            [In] object varIndex,
            [Out] out IComponentType TuningSpace
            );

        [PreserveSig]
        int put_Item(
            [In] object NewIndex,
            [In] IComponentType ComponentType
            );

        [PreserveSig]
        int Add(
            [In] IComponentType ComponentType,
            [Out] out object NewIndex
            );

        [PreserveSig]
        int Remove(
            [In] object Index
            );

        [PreserveSig]
        int Clone(
            [Out] out IComponentTypes NewList
            );
    }

    [ComImport,
    Guid("39A48091-FFFE-4182-A161-3FF802640E26"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IComponentsNew
    {
        [PreserveSig]
        int get_Count([Out] out int Count);

        [PreserveSig]
#if USING_NET11
        int get__NewEnum([Out] out UCOMIEnumVARIANT ppNewEnum);
#else
        int get__NewEnum([Out] out IEnumVARIANT ppNewEnum);
#endif

        [PreserveSig]
        int EnumComponents([Out] out IEnumComponents ppNewEnum);

        [PreserveSig]
        int get_Item(
            [In] object varIndex,
            [Out] out IComponent TuningSpace
            );

        [PreserveSig]
        int Add(
            [In] IComponent Component,
            [Out] out object NewIndex
            );

        [PreserveSig]
        int Remove([In] object Index);

        [PreserveSig]
        int Clone([Out] out IComponentsNew NewList);

        [PreserveSig]
        int put_Item(
            object Index,
            IComponent ppComponent
            );
    }

    [ComImport,
    Guid("2A6E2939-2595-11d3-B64C-00C04F79498E"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IEnumComponents
    {
        int Next(
            [In] int celt,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] IComponent [] rgelt,
            [Out] out int pceltFetched
            );

        int Skip([In] int celt);

        int Reset();

        int Clone([Out] out IEnumComponents ppEnum);
    }

    [ComImport,
    Guid("1A5576FC-0E19-11d3-9D8E-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IComponent
    {
        [PreserveSig]
        int get_Type([Out] out IComponentType CT);

        [PreserveSig]
        int put_Type([In] IComponentType CT);

        [PreserveSig]
        int get_DescLangID([Out] out int LangID);

        [PreserveSig]
        int put_DescLangID([In] int LangID);

        [PreserveSig]
        int get_Status([Out] out ComponentStatus Status);

        [PreserveSig]
        int put_Status([In] ComponentStatus Status);

        [PreserveSig]
        int get_Description([Out, MarshalAs(UnmanagedType.BStr)] out string Description);

        [PreserveSig]
        int put_Description([In, MarshalAs(UnmanagedType.BStr)] string Description);

        [PreserveSig]
        int Clone([Out] out IComponent NewComponent);
    }

    [ComImport,
    Guid("EB7D987F-8A01-42ad-B8AE-574DEEE44D1A"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IMPEG2TuneRequest : ITuneRequest
    {
        #region ITuneRequest Methods

        [PreserveSig]
        new int get_TuningSpace([Out] out ITuningSpace TuningSpace);

        [PreserveSig]
        new int get_Components([Out] out IComponents Components);

        [PreserveSig]
        new int Clone([Out] out ITuneRequest NewTuneRequest);

        [PreserveSig]
        new int get_Locator([Out] out ILocator Locator);

        [PreserveSig]
        new int put_Locator([In] ILocator Locator);

        #endregion

        [PreserveSig]
        int get_TSID([Out] out int TSID);

        [PreserveSig]
        int put_TSID([In] int TSID);

        [PreserveSig]
        int get_ProgNo([Out] out int ProgNo);

        [PreserveSig]
        int put_ProgNo([In] int ProgNo);
    }

    [ComImport,
    Guid("14E11ABD-EE37-4893-9EA1-6964DE933E39"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IMPEG2TuneRequestFactory
    {
        [PreserveSig]
        int CreateTuneRequest(
            [In] ITuningSpace TuningSpace,
            [Out] out IMPEG2TuneRequest TuneRequest
            );
    }

    [ComImport,
    Guid("FCD01846-0E19-11d3-9D8E-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IComponents
    {
        [PreserveSig]
        int get_Count(
            [Out] out int Count
            );

        [PreserveSig]
        int get__NewEnum(
#if USING_NET11
            [Out] out UCOMIEnumVARIANT ppNewEnum
#else
            [Out] out IEnumVARIANT ppNewEnum
#endif
            );

        [PreserveSig]
        int EnumComponents(
            [Out] out IEnumComponents ppNewEnum
            );

        [PreserveSig]
        int get_Item(
            [In] object varIndex,
            [Out] out IComponent TuningSpace
            );

        [PreserveSig]
        int Add(
            [In] IComponent Component,
            [Out] out object NewIndex
            );

        [PreserveSig]
        int Remove(
            [In] object Index
            );

        [PreserveSig]
        int Clone(
            [Out] out IComponents NewList
            );
    }

    [ComImport,
    Guid("2A6E293C-2595-11d3-B64C-00C04F79498E"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IAnalogTVTuningSpace : ITuningSpace
    {
        #region ITuningSpace Methods

        [PreserveSig]
        new int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        new int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        new int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        new int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        new int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        new int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        new int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        new int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        new int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        new int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        new int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        new int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        new int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        new int Clone([Out] out ITuningSpace NewTS);

        #endregion

        [PreserveSig]
        int get_MinChannel([Out] out int MinChannelVal);

        [PreserveSig]
        int put_MinChannel([In] int NewMinChannelVal);

        [PreserveSig]
        int get_MaxChannel([Out] out int MaxChannelVal);

        [PreserveSig]
        int put_MaxChannel([In] int NewMaxChannelVal);

        [PreserveSig]
        int get_InputType([Out] out TunerInputType InputTypeVal);

        [PreserveSig]
        int put_InputType([In] TunerInputType NewInputTypeVal);

        [PreserveSig]
        int get_CountryCode([Out] out int CountryCodeVal);

        [PreserveSig]
        int put_CountryCode([In] int NewCountryCodeVal);
    }

    [ComImport,
    Guid("0369B4E1-45B6-11d3-B650-00C04F79498E"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IATSCChannelTuneRequest : IChannelTuneRequest
    {
        #region ITuneRequest Methods

        [PreserveSig]
        new int get_TuningSpace([Out] out ITuningSpace TuningSpace);

        [PreserveSig]
        new int get_Components([Out] out IComponents Components);

        [PreserveSig]
        new int Clone([Out] out ITuneRequest NewTuneRequest);

        [PreserveSig]
        new int get_Locator([Out] out ILocator Locator);

        [PreserveSig]
        new int put_Locator([In] ILocator Locator);

        #endregion

        #region IChannelTuneRequest Methods

        [PreserveSig]
        new int get_Channel([Out] out int Channel);

        [PreserveSig]
        new int put_Channel([In] int Channel);

        #endregion

        [PreserveSig]
        int get_MinorChannel([Out] out int MinorChannel);

        [PreserveSig]
        int put_MinorChannel([In] int MinorChannel);
    }

    [ComImport,
    Guid("FC189E4D-7BD4-4125-B3B3-3A76A332CC96"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IATSCComponentType : IMPEG2ComponentType
    {
        #region IComponentType Methods

        [PreserveSig]
        new int get_Category([Out] out ComponentCategory Category);

        [PreserveSig]
        new int put_Category([In] ComponentCategory Category);

        [PreserveSig]
        new int get_MediaMajorType([Out, MarshalAs(UnmanagedType.BStr)] out string MediaMajorType);

        [PreserveSig]
        new int put_MediaMajorType([In, MarshalAs(UnmanagedType.BStr)] string MediaMajorType);

        [PreserveSig]
        new int get__MediaMajorType([Out] out Guid MediaMajorType);

        [PreserveSig]
        new int put__MediaMajorType([In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaMajorType);

        [PreserveSig]
        new int get_MediaSubType([Out, MarshalAs(UnmanagedType.BStr)] out string MediaSubType);

        [PreserveSig]
        new int put_MediaSubType([In, MarshalAs(UnmanagedType.BStr)] string MediaSubType);

        [PreserveSig]
        new int get__MediaSubType([Out] out Guid MediaSubType);

        [PreserveSig]
        new int put__MediaSubType([In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaSubType);

        [PreserveSig]
        new int get_MediaFormatType([Out, MarshalAs(UnmanagedType.BStr)] out string MediaFormatType);

        [PreserveSig]
        new int put_MediaFormatType([In, MarshalAs(UnmanagedType.BStr)] string MediaFormatType);

        [PreserveSig]
        new int get__MediaFormatType([Out] out Guid MediaFormatType);

        [PreserveSig]
        new int put__MediaFormatType([In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaFormatType);

        [PreserveSig]
        new int get_MediaType([Out] AMMediaType MediaType);

        [PreserveSig]
        new int put_MediaType([In] AMMediaType MediaType);

        [PreserveSig]
        new int Clone([Out] out IComponentType NewCT);

        #endregion

        #region ILanguageComponentType Methods

        [PreserveSig]
        new int get_LangID([Out] out int LangID);

        [PreserveSig]
        new int put_LangID([In] int LangID);

        #endregion

        #region IMPEG2ComponentType Methods

        [PreserveSig]
        new int get_StreamType([Out] out MPEG2StreamType MP2StreamType);

        [PreserveSig]
        new int put_StreamType([In] MPEG2StreamType MP2StreamType);

        #endregion

        [PreserveSig]
        int get_Flags([Out] out ATSCComponentTypeFlags Flags);

        [PreserveSig]
        int put_Flags([In] ATSCComponentTypeFlags Flags);
    }

    [ComImport,
    Guid("BF8D986F-8C2B-4131-94D7-4D3D9FCC21EF"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IATSCLocator : ILocator
    {
        #region ILocator Methods
        [PreserveSig]
        new int get_CarrierFrequency([Out] out int Frequency);

        [PreserveSig]
        new int put_CarrierFrequency([In] int Frequency);

        [PreserveSig]
        new int get_InnerFEC([Out] out FECMethod FEC);

        [PreserveSig]
        new int put_InnerFEC([In] FECMethod FEC);

        [PreserveSig]
        new int get_InnerFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int put_InnerFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int get_OuterFEC([Out] out FECMethod FEC);

        [PreserveSig]
        new int put_OuterFEC([In] FECMethod FEC);

        [PreserveSig]
        new int get_OuterFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int put_OuterFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int get_Modulation([Out] out ModulationType Modulation);

        [PreserveSig]
        new int put_Modulation([In] ModulationType Modulation);

        [PreserveSig]
        new int get_SymbolRate([Out] out int Rate);

        [PreserveSig]
        new int put_SymbolRate([In] int Rate);

        [PreserveSig]
        new int Clone([Out] out ILocator NewLocator);

        #endregion

        [PreserveSig]
        int get_PhysicalChannel([Out] out int PhysicalChannel);

        [PreserveSig]
        int put_PhysicalChannel([In] int PhysicalChannel);

        [PreserveSig]
        int get_TSID([Out] out int TSID);

        [PreserveSig]
        int put_TSID([In] int TSID);
    }

    [ComImport,
    Guid("0369B4E2-45B6-11d3-B650-00C04F79498E"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IATSCTuningSpace : IAnalogTVTuningSpace
    {
        #region ITuningSpace Methods

        [PreserveSig]
        new int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        new int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        new int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        new int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        new int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        new int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        new int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        new int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        new int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        new int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        new int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        new int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        new int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        new int Clone([Out] out ITuningSpace NewTS);

        #endregion

        #region IAnalogTVTuningSpace Methods

        [PreserveSig]
        new int get_MinChannel([Out] out int MinChannelVal);

        [PreserveSig]
        new int put_MinChannel([In] int NewMinChannelVal);

        [PreserveSig]
        new int get_MaxChannel([Out] out int MaxChannelVal);

        [PreserveSig]
        new int put_MaxChannel([In] int NewMaxChannelVal);

        [PreserveSig]
        new int get_InputType([Out] out TunerInputType InputTypeVal);

        [PreserveSig]
        new int put_InputType([In] TunerInputType NewInputTypeVal);

        [PreserveSig]
        new int get_CountryCode([Out] out int CountryCodeVal);

        [PreserveSig]
        new int put_CountryCode([In] int NewCountryCodeVal);

        #endregion

        [PreserveSig]
        int get_MinMinorChannel([Out] out int MinMinorChannelVal);

        [PreserveSig]
        int put_MinMinorChannel([In] int NewMinMinorChannelVal);

        [PreserveSig]
        int get_MaxMinorChannel([Out] out int MaxMinorChannelVal);

        [PreserveSig]
        int put_MaxMinorChannel([In] int NewMaxMinorChannelVal);

        [PreserveSig]
        int get_MinPhysicalChannel([Out] out int MinPhysicalChannelVal);

        [PreserveSig]
        int put_MinPhysicalChannel([In] int NewMinPhysicalChannelVal);

        [PreserveSig]
        int get_MaxPhysicalChannel([Out] out int MaxPhysicalChannelVal);

        [PreserveSig]
        int put_MaxPhysicalChannel([In] int NewMaxPhysicalChannelVal);
    }

    [ComImport,
    Guid("0369B4E0-45B6-11d3-B650-00C04F79498E"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IChannelTuneRequest : ITuneRequest
    {
        #region ITuneRequest Methods

        [PreserveSig]
        new int get_TuningSpace([Out] out ITuningSpace TuningSpace);

        [PreserveSig]
        new int get_Components([Out] out IComponents Components);

        [PreserveSig]
        new int Clone([Out] out ITuneRequest NewTuneRequest);

        [PreserveSig]
        new int get_Locator([Out] out ILocator Locator);

        [PreserveSig]
        new int put_Locator([In] ILocator Locator);

        #endregion

        [PreserveSig]
        int get_Channel([Out] out int Channel);

        [PreserveSig]
        int put_Channel([In] int Channel);
    }

    [ComImport,
    Guid("B874C8BA-0FA2-11d3-9D8E-00C04F72D980"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface ILanguageComponentType : IComponentType
    {
        #region IComponentType Methods

        [PreserveSig]
        new int get_Category([Out] out ComponentCategory Category);

        [PreserveSig]
        new int put_Category([In] ComponentCategory Category);

        [PreserveSig]
        new int get_MediaMajorType([Out, MarshalAs(UnmanagedType.BStr)] out string MediaMajorType);

        [PreserveSig]
        new int put_MediaMajorType([In, MarshalAs(UnmanagedType.BStr)] string MediaMajorType);

        [PreserveSig]
        new int get__MediaMajorType([Out] out Guid MediaMajorType);

        [PreserveSig]
        new int put__MediaMajorType([In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaMajorType);

        [PreserveSig]
        new int get_MediaSubType([Out, MarshalAs(UnmanagedType.BStr)] out string MediaSubType);

        [PreserveSig]
        new int put_MediaSubType([In, MarshalAs(UnmanagedType.BStr)] string MediaSubType);

        [PreserveSig]
        new int get__MediaSubType([Out] out Guid MediaSubType);

        [PreserveSig]
        new int put__MediaSubType([In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaSubType);

        [PreserveSig]
        new int get_MediaFormatType([Out, MarshalAs(UnmanagedType.BStr)] out string MediaFormatType);

        [PreserveSig]
        new int put_MediaFormatType([In, MarshalAs(UnmanagedType.BStr)] string MediaFormatType);

        [PreserveSig]
        new int get__MediaFormatType([Out] out Guid MediaFormatType);

        [PreserveSig]
        new int put__MediaFormatType([In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaFormatType);

        [PreserveSig]
        new int get_MediaType([Out] AMMediaType MediaType);

        [PreserveSig]
        new int put_MediaType([In] AMMediaType MediaType);

        [PreserveSig]
        new int Clone([Out] out IComponentType NewCT);

        #endregion

        [PreserveSig]
        int get_LangID([Out] out int LangID);

        [PreserveSig]
        int put_LangID([In] int LangID);
    }

    [ComImport,
    Guid("1493E353-1EB6-473c-802D-8E6B8EC9D2A9"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IMPEG2Component : IComponent
    {
        #region IComponent Methods

        [PreserveSig]
        new int get_Type([Out] out IComponentType CT);

        [PreserveSig]
        new int put_Type([In] IComponentType CT);

        [PreserveSig]
        new int get_DescLangID([Out] out int LangID);

        [PreserveSig]
        new int put_DescLangID([In] int LangID);

        [PreserveSig]
        new int get_Status([Out] out ComponentStatus Status);

        [PreserveSig]
        new int put_Status([In] ComponentStatus Status);

        [PreserveSig]
        new int get_Description([Out, MarshalAs(UnmanagedType.BStr)] out string Description);

        [PreserveSig]
        new int put_Description([In, MarshalAs(UnmanagedType.BStr)] string Description);

        [PreserveSig]
        new int Clone([Out] out IComponent NewComponent);

        #endregion

        [PreserveSig]
        int get_PID([Out] out int PID);

        [PreserveSig]
        int put_PID([In] int PID);

        [PreserveSig]
        int get_PCRPID([Out] out int PCRPID);

        [PreserveSig]
        int put_PCRPID([In] int PCRPID);

        [PreserveSig]
        int get_ProgramNumber([Out] out int ProgramNumber);

        [PreserveSig]
        int put_ProgramNumber([In] int ProgramNumber);
    }

    [ComImport,
    Guid("2C073D84-B51C-48c9-AA9F-68971E1F6E38"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IMPEG2ComponentType : ILanguageComponentType
    {
        #region IComponentType Methods

        [PreserveSig]
        new int get_Category([Out] out ComponentCategory Category);

        [PreserveSig]
        new int put_Category([In] ComponentCategory Category);

        [PreserveSig]
        new int get_MediaMajorType([Out, MarshalAs(UnmanagedType.BStr)] out string MediaMajorType);

        [PreserveSig]
        new int put_MediaMajorType([In, MarshalAs(UnmanagedType.BStr)] string MediaMajorType);

        [PreserveSig]
        new int get__MediaMajorType([Out] out Guid MediaMajorType);

        [PreserveSig]
        new int put__MediaMajorType([In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaMajorType);

        [PreserveSig]
        new int get_MediaSubType([Out, MarshalAs(UnmanagedType.BStr)] out string MediaSubType);

        [PreserveSig]
        new int put_MediaSubType([In, MarshalAs(UnmanagedType.BStr)] string MediaSubType);

        [PreserveSig]
        new int get__MediaSubType([Out] out Guid MediaSubType);

        [PreserveSig]
        new int put__MediaSubType([In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaSubType);

        [PreserveSig]
        new int get_MediaFormatType([Out, MarshalAs(UnmanagedType.BStr)] out string MediaFormatType);

        [PreserveSig]
        new int put_MediaFormatType([In, MarshalAs(UnmanagedType.BStr)] string MediaFormatType);

        [PreserveSig]
        new int get__MediaFormatType([Out] out Guid MediaFormatType);

        [PreserveSig]
        new int put__MediaFormatType([In, MarshalAs(UnmanagedType.LPStruct)] Guid MediaFormatType);

        [PreserveSig]
        new int get_MediaType([Out] AMMediaType MediaType);

        [PreserveSig]
        new int put_MediaType([In] AMMediaType MediaType);

        [PreserveSig]
        new int Clone([Out] out IComponentType NewCT);

        #endregion

        #region ILanguageComponentType Methods

        [PreserveSig]
        new int get_LangID([Out] out int LangID);

        [PreserveSig]
        new int put_LangID([In] int LangID);

        #endregion

        [PreserveSig]
        int get_StreamType([Out] out MPEG2StreamType MP2StreamType);

        [PreserveSig]
        int put_StreamType([In] MPEG2StreamType MP2StreamType);
    }

    [ComImport,
    Guid("E48244B8-7E17-4f76-A763-5090FF1E2F30"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IAuxInTuningSpace : ITuningSpace
    {
        #region ITuningSpace Methods

        [PreserveSig]
        new int get_UniqueName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_UniqueName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_FriendlyName([Out, MarshalAs(UnmanagedType.BStr)] out string Name);

        [PreserveSig]
        new int put_FriendlyName([In, MarshalAs(UnmanagedType.BStr)] string Name);

        [PreserveSig]
        new int get_CLSID([Out, MarshalAs(UnmanagedType.BStr)] out string SpaceCLSID);

        [PreserveSig]
        new int get_NetworkType([Out, MarshalAs(UnmanagedType.BStr)] out string NetworkTypeGuid);

        [PreserveSig]
        new int put_NetworkType([In, MarshalAs(UnmanagedType.BStr)] string NetworkTypeGuid);

        [PreserveSig]
        new int get__NetworkType([Out] out Guid NetworkTypeGuid);

        [PreserveSig]
        new int put__NetworkType([In, MarshalAs(UnmanagedType.LPStruct)] Guid NetworkTypeGuid);

        [PreserveSig]
        new int CreateTuneRequest([Out] out ITuneRequest TuneRequest);

        [PreserveSig]
        new int EnumCategoryGUIDs([Out, MarshalAs(UnmanagedType.IUnknown)] out object ppEnum); // IEnumGUID**

        [PreserveSig]
#if USING_NET11
        new int EnumDeviceMonikers([Out] out UCOMIEnumMoniker ppEnum);
#else
        new int EnumDeviceMonikers([Out] out IEnumMoniker ppEnum);
#endif

        [PreserveSig]
        new int get_DefaultPreferredComponentTypes([Out] out IComponentTypes ComponentTypes);

        [PreserveSig]
        new int put_DefaultPreferredComponentTypes([In] IComponentTypes NewComponentTypes);

        [PreserveSig]
        new int get_FrequencyMapping([Out, MarshalAs(UnmanagedType.BStr)] out string pMapping);

        [PreserveSig]
        new int put_FrequencyMapping([In, MarshalAs(UnmanagedType.BStr)] string Mapping);

        [PreserveSig]
        new int get_DefaultLocator([Out] out ILocator LocatorVal);

        [PreserveSig]
        new int put_DefaultLocator([In] ILocator LocatorVal);

        [PreserveSig]
        new int Clone([Out] out ITuningSpace NewTS);

        #endregion
    }

    [ComImport,
    Guid("6E42F36E-1DD2-43c4-9F78-69D25AE39034"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IDVBCLocator : ILocator
    {
        #region ILocator Methods

        [PreserveSig]
        new int get_CarrierFrequency([Out] out int Frequency);

        [PreserveSig]
        new int put_CarrierFrequency([In] int Frequency);

        [PreserveSig]
        new int get_InnerFEC([Out] out FECMethod FEC);

        [PreserveSig]
        new int put_InnerFEC([In] FECMethod FEC);

        [PreserveSig]
        new int get_InnerFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int put_InnerFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int get_OuterFEC([Out] out FECMethod FEC);

        [PreserveSig]
        new int put_OuterFEC([In] FECMethod FEC);

        [PreserveSig]
        new int get_OuterFECRate([Out] out BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int put_OuterFECRate([In] BinaryConvolutionCodeRate FEC);

        [PreserveSig]
        new int get_Modulation([Out] out ModulationType Modulation);

        [PreserveSig]
        new int put_Modulation([In] ModulationType Modulation);

        [PreserveSig]
        new int get_SymbolRate([Out] out int Rate);

        [PreserveSig]
        new int put_SymbolRate([In] int Rate);

        [PreserveSig]
        new int Clone([Out] out ILocator NewLocator);

        #endregion
    }

    [ComImport,
    Guid("1B9D5FC3-5BBC-4b6c-BB18-B9D10E3EEEBF"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMPEG2TuneRequestSupport
    {
    }

    [ComImport,
    Guid("3B21263F-26E8-489d-AAC4-924F7EFD9511"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IBroadcastEvent
    {
        [PreserveSig]
        int Fire(Guid EventID);
    }

    [ComImport,
    Guid("B34505E0-2F0E-497b-80BC-D43F3B24ED7F"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IBDAComparable
    {
        [PreserveSig]
        int CompareExact(
            [In, MarshalAs(UnmanagedType.IDispatch)] object CompareTo,
            [Out] out int Result
            );

        [PreserveSig]
        int CompareEquivalent(
              [In, MarshalAs(UnmanagedType.IDispatch)] object CompareTo,
              [In] BDACompFlags dwFlags,
              [Out] out int Result
              );

        [PreserveSig]
        int HashExact(
              [Out] out long Result
              );

        [PreserveSig]
        int HashExactIncremental(
              [In] long PartialResult,
              [Out] out long Result
              );

        [PreserveSig]
        int HashEquivalent(
              [In] BDACompFlags dwFlags,
              [Out] out long Result
              );

        [PreserveSig]
        int HashEquivalentIncremental(
              [In] long PartialResult,
              [In] BDACompFlags dwFlags,
              [Out] out long Result
              );
    }

    #endregion
}
