// ----------------------------------------------------------------------------
// <Copyright File="OSInfo.cs" Company="FrancescoMagliocco"
//     Copyright (C) 2016 FrancescoMagliocco
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// <Contact Email="Magliocco.W.Francesco@Gmail.com"/>
// <Coded Year="2016">
//     <Month>04</Month>
//     <Day>06</Day>
//     <Time>19:35</Time>
// </Coded>
// ----------------------------------------------------------------------------

namespace FrancescoMagliocco.Utils.Helpers
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Management;

    using _Debug = System.Diagnostics.Debug;

    /// <summary>
    ///     Application boost is implemented by giving an application more execution time slices (quantum
    ///     lengths).
    /// </summary>
    public enum ApplicationBoost : byte
    {
        /// <summary> The system boosts the quantum length by 6. </summary>
        None = 0x0,

        /// <summary> The system boosts the quantum length by 12. </summary>
        Minimum = 0x1,

        /// <summary> The system boosts the quantum length by 18. </summary>
        Maximum = 0x2
    }

    /// <summary> Encryption level for secure transactions: 40-bit, 128-bit, or n-bit. </summary>
    /*
     * I'm using 'EncryptionLevels' rather than 'EncryptionLevel' because there is a property already called
     * 'EncryptionLevel' and there isn't a way (That I know of) to differentiate the two.
     */
    public enum EncryptionLevels : uint
    {
        /// <summary> 40-bit </summary>
        FourtyBit = 0x0,

        /// <summary> 128-bit </summary>
        OneHundreadTwentyEightBit = 0x1,

        /// <summary> n-bit </summary>
        NumberBit = 0x2
    }

    /// <summary> The following enum lists possible SKU values. </summary>
    /*
     * I'm using 'OperatingSystemSKUs' rather than 'OperatingSystemSKU' because there is a property already called
     * 'OperatingSystemSKU' and there isn't a way (That I know of) to differentiate the two.
     */
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum OperatingSystemSKUs : uint
    {
        /// <summary> Undefined </summary>
        Undefined = 0x0,

        /// <summary> Ultimate Edition </summary>
        UltimateEdition = 0x1,

        /// <summary> Home Basic Edition </summary>
        HomeBasicEdition = 0x2,

        /// <summary> Home Premium Edition </summary>
        HomePremiumEdition = 0x3,

        /// <summary> Enterprise Edition </summary>
        EnterpriseEdition = 0x4,

        /// <summary> Home Basic N Edition </summary>
        HomeBasic_N_Edition = 0x5,

        /// <summary> Business Edition </summary>
        BuisnessEdition = 0x6,

        /// <summary> Standard Server Edition </summary>
        StandardServerEdition = 0x7,

        /// <summary> Datacenter Server Edition </summary>
        DatacenterServerEdition = 0x8,

        /// <summary> Small Business Server Edition </summary>
        SmallBusinessServerEdition = 0x9,

        /// <summary> Enterprise Server Edition </summary>
        EnterpriseServerEdition = 0xA,

        /// <summary> Starter Edition </summary>
        StarterEdition = 0xB,

        /// <summary> Datacenter Server Core Edition </summary>
        DatacenterServerCoreEdition = 0xC,

        /// <summary> Standard Server Core Edition </summary>
        StandardServerCoreEdition = 0xD,

        /// <summary> Enterprise Server Core Edition </summary>
        EnterpriseServerCoreEdition = 0xE,

        /// <summary> Enterprise Server Edition for Itanium-Based Systems </summary>
        EnterpriseServerIA64Edition = 0xF,

        /// <summary> Business N Edition </summary>
        Business_N_Edition = 0x10,

        /// <summary> Web Server Edition </summary>
        WebServerEdition = 0x11,

        /// <summary> Cluster Server Edition </summary>
        ClusterServerEdition = 0x12,

        /// <summary> Home Server Edition </summary>
        HomeServerEdition = 0x13,

        /// <summary> Storage Express Server Edition </summary>
        StorageExpressServerEdition = 0x14,

        /// <summary> Storage Standard Server Edition </summary>
        StorageStandardServerEdition = 0x15,

        /// <summary> Storage Workgroup Server Edition </summary>
        StorageWorkgroupServerEdition = 0x16,

        /// <summary> Storage Enterprise Server Edition </summary>
        StorageEnterpriseServerEdition = 0x17,

        /// <summary> Server For Small Business Edition </summary>
        ServerForSmallBusinessEdition = 0x18,

        /// <summary> Small Business Server Premium Edition </summary>
        SmallBusinessServerPremiumEdition = 0x19,

        /// <summary> To Be Discovered </summary>
        TBD = 0x1A
    }

    /// <summary> Type of operating system. The following enum identifies the possible values. </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum OperatingSystemType : ushort
    {
        /// <summary> Unknown </summary>
        Unknown = 0x0,

        /// <summary> Other </summary>
        Other = 0x1,

        /// <summary> MACROS </summary>
        MACROS = 0x2,

        /// <summary> ATTUNIX </summary>
        ATTUNIX = 0x3,

        /// <summary> DGUX </summary>
        DGUX = 0x4,

        /// <summary> DECNT </summary>
        DECNT = 0x5,

        /// <summary> Digital UNIX </summary>
        DigitalUNIX = 0x6,

        /// <summary> OpenVMS </summary>
        OpenVMS = 0x7,

        /// <summary> HPUX </summary>
        HPUX = 0x8,

        /// <summary> AIX </summary>
        AIX = 0x9,

        /// <summary> MVS </summary>
        MVS = 0xA,

        /// <summary> OS400 </summary>
        OS400 = 0xB,

        /// <summary> OS/2 </summary>
        OS_2 = 0xC,

        /// <summary> JavaVM </summary>
        JavaVM = 0xD,

        /// <summary> MSDOS </summary>
        MSDOS = 0xE,

        /// <summary> WIN3x </summary>
        WIN3x = 0xF,

        /// <summary> WIN95 </summary>
        WIN95 = 0x10,

        /// <summary> WIN98 </summary>
        WIN98 = 0x11,

        /// <summary> WINNT </summary>
        WINNT = 0x12,

        /// <summary> WINCE </summary>
        WINCE = 0x13,

        /// <summary> NCR3000 </summary>
        NCR3000 = 0x14,

        /// <summary> NetWare </summary>
        NetWare = 0x15,

        /// <summary> OSF </summary>
        OSF = 0x16,

        /// <summary> DC/OS </summary>
        DC_OS = 0x17,

        /// <summary> Reliant UNIX </summary>
        ReliantUNIX = 0x18,

        /// <summary> SCO UnixWare </summary>
        SCOUnixWare = 0x19,

        /// <summary> SCO OpenServer </summary>
        SCOOpenServer = 0x1A,

        /// <summary> Sequent </summary>
        Sequent = 0x1B,

        /// <summary> IRIX </summary>
        IRIX = 0x1C,

        /// <summary> Solaris </summary>
        Solaris = 0x1D,

        /// <summary> SunOS </summary>
        SunOS = 0x1E,

        /// <summary> U6000 </summary>
        U6000 = 0x1F,

        /// <summary> ASERIES </summary>
        ASERIES = 0x20,

        /// <summary> TandemNSK </summary>
        TandemNSK = 0x21,

        /// <summary> TandemNT </summary>
        TandemNT = 0x22,

        /// <summary> BS2000 </summary>
        BS2000 = 0x23,

        /// <summary> LINUX </summary>
        LINUX = 0x24,

        /// <summary> Lynx </summary>
        Lynx = 0x25,

        /// <summary> XENIX </summary>
        XENIX = 0x26,

        /// <summary> VM/ESA </summary>
        VM_ESA = 0x27,

        /// <summary> Interactive UNIX </summary>
        InteractiveUNIX = 0x28,

        /// <summary> BSDUNIX </summary>
        BSDUNIX = 0x29,

        /// <summary> FreeBSD </summary>
        FreeBSD = 0x2A,

        /// <summary> NetBSD </summary>
        NetBSD = 0x2B,

        /// <summary> GNU Hurd </summary>
        GNUHurd = 0x2C,

        /// <summary> OS9 </summary>
        OS9 = 0x2D,

        /// <summary> MACH Kernel </summary>
        MACHKernel = 0x2E,

        /// <summary> Inferno </summary>
        Inferno = 0x2F,

        /// <summary> QNX </summary>
        QNX = 0x30,

        /// <summary> EPOC </summary>
        EPOC = 0x31,

        /// <summary> IxWorks </summary>
        IxWorks = 0x32,

        /// <summary> VxWorks </summary>
        VxWorks = 0x33,

        /// <summary> MiNT </summary>
        MiNT = 0x34,

        /// <summary> BeOS </summary>
        BeOS = 0x35,

        /// <summary> HP MPE </summary>
        HPMPE = 0x36,

        /// <summary> NextStep </summary>
        NextStep = 0x37,

        /// <summary> PalmPilot </summary>
        PalmPilot = 0x38,

        /// <summary> Rhapsody </summary>
        Rhapsody = 0x39
    }

    /// <summary> Installed and licensed system product additions to the operating system. </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum ProductSuite : uint
    {
        /// <summary>
        ///     Microsoft Small Business Server was once installed, but may have been upgraded to another version
        ///     of Windows.
        /// </summary>
        MicrosoftSmallBusinessServer_Past = 0x1,

        /// <summary> Windows Server 2008 Enterprise is installed. </summary>
        WindowsServer2008Enterprise = 0x2,

        /// <summary> Windows BackOffice components are installed. </summary>
        WindowsBackOffice = 0x4,

        /// <summary> Communication Server is installed. </summary>
        CommunicationServer = 0x8,

        /// <summary> Terminal Services is installed. </summary>
        TerminalService = 0x10,

        /// <summary> Microsoft Small Business Server is installed with the restrictive client license. </summary>
        MicrosoftSmallBusinessServer_Present = 0x20,

        /// <summary> Windows Embedded is installed. </summary>
        WindowsEmbedded = 0x40,

        /// <summary> A Datacenter edition is installed. </summary>
        Datacenter = 0x80,

        /// <summary> Terminal Services is installed, but only one interactive session is supported. </summary>
        TerminalServices_LimitedSupport = 0x100,

        /// <summary> Windows Home Edition is installed. </summary>
        WindowsHomeEdition = 0x200,

        /// <summary> Web Server Edition is installed. </summary>
        WebServerEdition = 0x400,

        /// <summary> Storage Server Edition is installed. </summary>
        StorageServerEdition = 0x2000,

        /// <summary> Compute Cluster Edition is installed. </summary>
        ComputeClusterEdition = 0x4000
    }

    /// <summary> Language version of the operating system installed.  The following enum lists the possible values. </summary>
    /*
     * I'm using 'OSLanguages' rather than 'OSLanguage' because there is a property already called
     * 'OSLanguage' and there isn't a way (That I know of) to differentiate the two.
     */
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum OSLanguages : uint
    {
        /// <summary> Arabic </summary>
        Arabic = 0x1,

        /// <summary> Chinese (Simplified)– China </summary>
        ChineseSimplified_China = 0x4,

        /// <summary> English </summary>
        English = 0x9,

        /// <summary> Arabic – Saudi Arabia </summary>
        Arabic_SaudiArabia = 0x401,

        /// <summary> Bulgarian </summary>
        Bulgarian = 0x402,

        /// <summary> Catalan </summary>
        Catalan = 0x403,

        /// <summary> Chinese (Traditional) – Taiwan </summary>
        ChineseTraditional_Taiwan = 0x404,

        /// <summary> Czech </summary>
        Czech = 0x405,

        /// <summary> Danish </summary>
        Danish = 0x406,

        /// <summary> German – Germany </summary>
        German_Germany = 0x407,

        /// <summary> Greek </summary>
        Greek = 0x408,

        /// <summary> English – United States </summary>
        English_UnitedStates = 0x409,

        /// <summary> Spanish – Traditional Sort </summary>
        Spanish_TraditionalSort = 0x40A,

        /// <summary> Finnish </summary>
        Finnish = 0x40B,

        /// <summary> French – France </summary>
        French_France = 0x40C,

        /// <summary> Hebrew </summary>
        Hebrew = 0x40D,

        /// <summary> Hungarian </summary>
        Hungarian = 0x40E,

        /// <summary> Icelandic </summary>
        Icelandic = 0x40F,

        /// <summary> Italian – Italy </summary>
        Italian_Italy = 0x410,

        /// <summary> Japanese </summary>
        Japanese = 0x411,

        /// <summary> Korean </summary>
        Korean = 0x412,

        /// <summary> Dutch – Netherlands </summary>
        Dutch_Netherlands = 0x413,

        /// <summary> Norwegian – Bokmal </summary>
        Norwegian_Bokmal = 0x414,

        /// <summary> Polish </summary>
        Polish = 0x415,

        /// <summary> Portuguese – Brazil </summary>
        Portuguese_Brazil = 0x416,

        /// <summary> Rhaeto-Romanic </summary>
        RhaetoRomanic = 0x417,

        /// <summary> Romanian </summary>
        Romanian = 0x418,

        /// <summary> Russian </summary>
        Russian = 0x419,

        /// <summary> Croatian </summary>
        Croatian = 0x41A,

        /// <summary> Slovak </summary>
        Slovak = 0x41B,

        /// <summary> Albanian </summary>
        Albanian = 0x41C,

        /// <summary> Swedish </summary>
        Swedish = 0x41D,

        /// <summary> Thai </summary>
        Thai = 0x41E,

        /// <summary> Turkish </summary>
        Turkish = 0x41F,

        /// <summary> Urdu </summary>
        Urdu = 0x420,

        /// <summary> Indonesian </summary>
        Indonesian = 0x421,

        /// <summary> Ukrainian </summary>
        Ukrainian = 0x422,

        /// <summary> Belarusian </summary>
        Belarusian = 0x423,

        /// <summary> Slovenian </summary>
        Slovenian = 0x424,

        /// <summary> Estonian </summary>
        Estonian = 0x425,

        /// <summary> Latvian </summary>
        Latvian = 0x426,

        /// <summary> Lithuanian </summary>
        Lithuanian = 0x427,

        /// <summary> Persian </summary>
        Persian = 0x429,

        /// <summary> Vietnamese </summary>
        Vietnamese = 0x42A,

        /// <summary> Basque (Basque) </summary>
        /// <remarks> Not a mistake in nameing. </remarks>
        BasqueBasque = 0x42D,

        /// <summary> Serbian </summary>
        Serbian = 0x42E,

        /// <summary> Macedonian (Macedonia (FYROM)) </summary>
        // Looks better formatted like this
        Macedonian_Macedonia_FYROM = 0x42F,

        /// <summary> Sutu </summary>
        Sutu = 0x430,

        /// <summary> Tsonga </summary>
        Tsonga = 0x431,

        /// <summary> Tswana </summary>
        Tswana = 0x432,

        /// <summary> Xhosa </summary>
        Xhosa = 0x434,

        /// <summary> Zulu </summary>
        Zulu = 0x435,

        /// <summary> Afrikaans </summary>
        Afrikaans = 0x436,

        /// <summary> Faeroese </summary>
        Faeroese = 0x438,

        /// <summary> Hindi </summary>
        Hindi = 0x439,

        /// <summary> Maltese </summary>
        Maltese = 0x43A,

        /// <summary> Scottish Gaelic (United Kingdom) </summary>
        // Looks better formatted like this.
        Scottish_Gaelic_UnitedKingdom = 0x43C,

        /// <summary> Yiddish </summary>
        Yiddish = 0x43D,

        /// <summary> Malay – Malaysia </summary>
        Malay_Malaysia = 0x43E,

        /// <summary> Arabic – Iraq </summary>
        Arabic_Iraq = 0x801,

        /// <summary> Chinese (Simplified) – PRC </summary>
        ChineseSimplified_PRC = 0x804,

        /// <summary> German – Switzerland </summary>
        German_Switzerland = 0x807,

        /// <summary> English – United Kingdom </summary>
        English_UnitedKingdom = 0x809,

        /// <summary> Spanish – Mexico </summary>
        Spanish_Mexico = 0x80A,

        /// <summary> French – Belgium </summary>
        French_Belgium = 0x80C,

        /// <summary> Italian – Switzerland </summary>
        Italian_Switzerland = 0x810,

        /// <summary> Dutch – Belgium </summary>
        Dutch_Belgium = 0x813,

        /// <summary> Norwegian – Nynorsk </summary>
        Norwegian_Nynorsk = 0x814,

        /// <summary> Portuguese – Portugal </summary>
        Portuguese_Portugal = 0x816,

        /// <summary> Romanian – Moldova </summary>
        Romanian_Moldova = 0x818,

        /// <summary> Russian – Moldova </summary>
        Russian_Moldova = 0x819,

        /// <summary> Serbian – Latin </summary>
        Serbian_Latin = 0x81A,

        /// <summary> Swedish – Finland </summary>
        Swedish_Finland = 0x81D,

        /// <summary> Arabic – Egypt </summary>
        Arabic_Egypt = 0xC01,

        /// <summary> Chinese (Traditional) – Hong Kong SAR </summary>
        ChineseTraditional_HongKongSAR = 0xC04,

        /// <summary> German – Austria </summary>
        German_Austria = 0xC07,

        /// <summary> English – Australia </summary>
        English_Australia = 0xC09,

        /// <summary> Spanish – International Sort </summary>
        Spanish_InternationalSort = 0xC0A,

        /// <summary> French – Canada </summary>
        French_Canada = 0xC0C,

        /// <summary> Serbian – Cyrillic </summary>
        Serbian_Cyrillic = 0xC1A,

        /// <summary> Arabic – Libya </summary>
        Arabic_Libya = 0x1001,

        /// <summary> Chinese (Simplified) – Singapore </summary>
        ChineseSimplified_Singapore = 0x1004,

        /// <summary> German – Luxembourg </summary>
        German_Luxembourg = 0x1007,

        /// <summary> English – Canada </summary>
        English_Canada = 0x1009,

        /// <summary> Spanish – Guatemala </summary>
        Spanish_Guatemala = 0x100A,

        /// <summary> French – Switzerland </summary>
        French_Switzerland = 0x100C,

        /// <summary> Arabic – Algeria </summary>
        Arabic_Algeria = 0x1401,

        /// <summary> German – Liechtenstein </summary>
        German_Liechtenstein = 0x1407,

        /// <summary> English – New Zealand </summary>
        English_NewZealand = 0x1409,

        /// <summary> Spanish – Costa Rica </summary>
        Spanish_CostaRica = 0x140A,

        /// <summary> French – Luxembourg </summary>
        French_Luxembourg = 0x140C,

        /// <summary> Arabic – Morocco </summary>
        Arabic_Morocco = 0x1801,

        /// <summary> English – Ireland </summary>
        English_Ireland = 0x1809,

        /// <summary> Spanish – Panama </summary>
        Spanish_Panama = 0x180A,

        /// <summary> Arabic – Tunisia </summary>
        Arabic_Tunisia = 0x1C01,

        /// <summary> English – South Africa </summary>
        English_SouthAfrica = 0x1C09,

        /// <summary> Spanish – Dominican Republic </summary>
        Spanish_DominicanRepublic = 0x1C0A,

        /// <summary> Arabic – Oman </summary>
        Arabic_Oman = 0x2001,

        /// <summary> English – Jamaica </summary>
        English_Jamaica = 0x2009,

        /// <summary> Spanish – Venezuela </summary>
        Spanish_Venezuela = 0x200A,

        /// <summary> Arabic – Yemen </summary>
        Arabic_Yemen = 0x2401,

        /// <summary> Spanish – Colombia </summary>
        Spanish_Colombia = 0x240A,

        /// <summary> Arabic – Syria </summary>
        Arabic_Syria = 0x2801,

        /// <summary> English – Belize </summary>
        English_Belize = 0x2809,

        /// <summary> Spanish – Peru </summary>
        Spanish_Peru = 0x280A,

        /// <summary> Arabic – Jordan </summary>
        Arabic_Jordan = 0x2C01,

        /// <summary> English – Trinidad </summary>
        English_Trinidad = 0x2C09,

        /// <summary> Spanish – Argentina </summary>
        Spanish_Argentina = 0x2C0A,

        /// <summary> Arabic – Lebanon </summary>
        Arabic_Lebanon = 0x3001,

        /// <summary> Spanish – Ecuador </summary>
        Spanish_Ecuador = 0x300A,

        /// <summary> Arabic – Kuwait </summary>
        Arabic_Kuwait = 0x3401,

        /// <summary> Spanish – Chile </summary>
        Spanish_Chile = 0x340A,

        /// <summary> Arabic – U.A.E. </summary>
        Arabic_UAE = 0x3801,

        /// <summary> Spanish – Uruguay </summary>
        Spanish_Uruguay = 0x380A,

        /// <summary> Arabic – Bahrain </summary>
        Arabic_Bahrain = 0x3C01,

        /// <summary> Spanish – Paraguay </summary>
        Spanish_Paraguay = 0x3C0A,

        /// <summary> Arabic – Qatar </summary>
        Arabic_Qatar = 0x4001,

        /// <summary> Spanish – Bolivia </summary>
        Spanish_Bolivia = 0x400A,

        /// <summary> Spanish – El Salvador </summary>
        Spanish_ElSalvador = 0x440A,

        /// <summary> Spanish – Honduras </summary>
        Spanish_Honduras = 0x480A,

        /// <summary> Spanish – Nicaragua </summary>
        Spanish_Nicaragua = 0x4C0A,

        /// <summary> Spanish – Puerto Rico </summary>
        Spanish_PuertoRico = 0x500A
    }

    /// <summary> Additional system information. </summary>
    /*
     * I'm using 'ProductTypes' rather than 'ProductType' because there is a property already called
     * 'ProductType' and there isn't a way (That I know of) to differentiate the two.
     */
    public enum ProductTypes : uint
    {
        /// <summary> Work Station </summary>
        WorkStation = 0x1,

        /// <summary> Domain Controller </summary>
        DomainController = 0x2,

        /// <summary> Server </summary>
        Server = 0x3
    }

    /// <summary> The number of clock ticks per quantum. </summary>
    /*
     * I'm using 'QuantumLengths' rather than 'QuantumLength' because there is a property already called
     * 'QuantumLength' and there isn't a way (That I know of) to differentiate the two.
     */
    public enum QuantumLengths : byte
    {
        /// <summary> Unknown </summary>
        Unknown = 0x0,

        /// <summary> One tick </summary>
        One = 0x1,

        /// <summary> Two ticks </summary>
        Two = 0x2
    }

    /// <summary> Specifies either fixed or variable length quantums. </summary>
    /*
     * I'm using 'QuantumTypes' rather than 'QuantumType' because there is a property already called
     * 'QuantumType' and there isn't a way (That I know of) to differentiate the two.
     */
    public enum QuantumTypes : byte
    {
        /// <summary> Quantum type is not known. </summary>
        Unknown = 0x0,

        /// <summary> Quantum length is fixed. </summary>
        Fixed = 0x1,

        /// <summary> Quantum length is variable. </summary>
        Variable = 0x2
    }

    /// <summary> Current status of the object. </summary>
    public enum State
    {
        /// <summary> OK </summary>
        OK,

        /// <summary> Error </summary>
        Error,

        /// <summary> Degraded </summary>
        Degraded,

        /// <summary> Unknown </summary>
        Unknown,

        // BUG If used with a switch statement 'PredFail' wont be able to be used as an accessable label.
        /// <summary> Pred Fail </summary>
        PredFail,

        /// <summary> Starting </summary>
        Starting,

        /// <summary> Stopping </summary>
        Stopping,

        /// <summary> Service </summary>
        Service
    }

    /// <summary>
    ///     Indicates which Data Execution Prevention (DEP) setting is applied. The DEP setting specifies the
    ///     extent to which DEP applies to 32-bit applications on the system. DEP is always applied to the Windows
    ///     kernel.
    /// </summary>
    public enum SupportPolicy : byte
    {
        /// <summary>
        ///     DEP is turned off for all 32-bit applications on the computer with no exceptions. This setting is
        ///     not available for the user interface.
        /// </summary>
        AlwaysOff = 0x0,

        /// <summary>
        ///     DEP is enabled for all 32-bit applications on the computer. This setting is not available for the
        ///     user interface.
        /// </summary>
        AlwaysOn = 0x1,

        /// <summary>
        ///     DEP is enabled for a limited number of binaries, the kernel, and all Windows-based services.
        ///     However, it is off by default for all 32-bit applications. A user or administrator must explicitly choose
        ///     either the AlwaysOn or the OptOut setting before DEP can be applied to 32-bit applications.
        /// </summary>
        Optin = 0x2,

        /// <summary>
        ///     DEP is enabled by default for all 32-bit applications. A user or administrator can explicitly
        ///     remove support for a 32-bit application by adding the application to an exceptions list.
        /// </summary>
        OptOut = 0x3
    }

    /*
     * I'm using 'SuiteMasks' rather than 'SuiteMask' because there is a property already called
     * 'SuiteMask' and there isn't a way (That I know of) to differentiate the two.
     */

    /// <summary> Bit flags that identify the product suites available on the system. </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum SuiteMasks : uint
    {
        /// <summary> Small Business </summary>
        SmallBusiness = 0x1,

        /// <summary> Enterprise </summary>
        Enterprise = 0x2,

        /// <summary> BackOffice </summary>
        BackOffice = 0x4,

        /// <summary> Communications </summary>
        Communications = 0x8,

        /// <summary> Terminal Services </summary>
        TerminalServices = 0x10,

        /// <summary> Small Business Restricted </summary>
        SmallBusiness_Restricted = 0x20,

        /// <summary> Embedded Edition </summary>
        EmbeddedEdition = 0x40,

        /// <summary> Datacenter Edition </summary>
        DatacenterEdition = 0x80,

        /// <summary> Single User </summary>
        SingleUser = 0x100,

        /// <summary> Home Edition </summary>
        HomeEdition = 0x200,

        /// <summary> Web Server Edition </summary>
        WebServerEdition = 0x400
    }

    /// <summary> A comprehensive helper class for the
    ///     <see langword="Win32_OperatingSystem"/>   <c> WMI class </c>
    ///     represents a Windows-based operating system installed on a computer. </summary>
    public static class OSInfo
    {
        #region Properties and Indexers
        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32API|DRIVE_MAP_INFO|btInt13Unit")<br/>
        ///     </remarks>
        ///     <para> Name of the disk drive from which the Windows operating system starts. </para>
        ///     <para> Example: "\\Device\Harddisk0" </para>
        /// </summary>
        public static string BootDevice => Get<string>("BootDevice");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|System Information Structures|<c> OSVERSIONINFOEX </c>
        ///         |dwBuildNumber")<br/>
        ///     </remarks>
        ///     <para>
        ///         Build number of an operating system. It can be used for more precise version information than
        ///         product release version numbers.
        ///     </para>
        ///     <para> Example: "1381" </para>
        /// </summary>
        public static string BuildNumber => Get<string>("BuildNumber");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32Registry|Software\\Microsoft\\Windows\\CurrentVersion|CurrentType")
        ///         <br/>
        ///     </remarks>
        ///     <para> Type of build used for an operating system. </para>
        ///     <para> Examples: ""retail build"", ""checked build"" </para>
        /// </summary>
        public static string BuildType => Get<string>("BuildType");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Short description of the object—a one-line string. The string includes the operating system
        ///         version. For example, "Microsoft Windows 7 Enterprise ". This property can be localized.
        ///     </para>
        ///     <para>
        ///         <see langword="Windows Vista and Windows 7:"/>   This property may contain trailing characters. For
        ///         example, the string "Microsoft Windows 7 Enterprise " (trailing space included) may be necessary to
        ///         retrieve information using this property.
        ///     </para>
        /// </summary>
        public static string Caption => Get<string>("Caption");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MaxLen </c> (6) , <c> MappingStrings </c>
        ///         ("Win32API|National Language Support Functions|
        ///         <c> GetLocaleInfo </c>|LOCALE_IDEFAULTANSICODEPAGE")<br/>
        ///     </remarks>
        ///     <para>
        ///         Code page value an operating system uses. A code page contains a character table that an operating
        ///         system uses to translate strings for different languages. The American National Standards Institute
        ///         (ANSI) lists values that represent defined code pages. If an operating system does not use an ANSI
        ///         code page, this member is set to 0 (zero). The
        ///         <see langword="CodeSet"/> string can use a maximum of six characters to define the code page value.
        ///     </para>
        ///     <para> Example: "1255" </para>
        /// </summary>
        public static string CodeSet => Get<string>("CodeSet");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|National Language Support Functions|
        ///         <c> GetLocaleInfo </c>
        ///         |LOCALE_ICOUNTRY")<br/>
        ///     </remarks>
        ///     <para>
        ///         Code for the country/region that an operating system uses. Values are based on international phone
        ///         dialing prefixes—also referred to as IBM country/region codes. This property can use a maximum of six
        ///         characters to define the country/region code value.
        ///     </para>
        ///     <para> Example: "1" (United States) </para>
        /// </summary>
        public static string CountryCode => Get<string>("CountryCode");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> Key </c>, <c> MaxLen </c> (256)<br/>
        ///     </remarks>
        ///     <para>
        ///         Name of the first concrete class that appears in the inheritance chain used in the creation of an
        ///         instance. When used with other key properties of the class, this property allows all instances of
        ///         this class and its subclasses to be identified uniquely.
        ///     </para>
        /// </summary>
        public static string CreateClassName => Get<string>("CreateClassName");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Creation class name of the scoping computer system. </para>
        /// </summary>
        public static string CSCreationClassName => Get<string>("CSCreationClassName");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|System Information Structures|<c> OSVERSIONINFOEX </c>
        ///         |szCSDVersion")<br/>
        ///     </remarks>
        ///     <para>
        ///         <see langword="NULL"/>-terminated string that indicates the latest service pack installed on a
        ///         computer. If no service pack is installed, the string is <see langword="NULL"/>.
        ///     </para>
        ///     <para> Example: "Service Pack 3" </para>
        /// </summary>
        public static string CSDVersion => Get<string>("CSDVersion");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Name of the scoping computer system. </para>
        /// </summary>
        public static string CSName => Get<string>("CSName");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="short"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Number, in minutes, an operating system is offset from Greenwich mean time (GMT). The number is
        ///         positive, negative, or zero.
        ///     </para>
        /// </summary>
        public static short CurrentTimeZone => Get<short>("CurrentTimeZone");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="bool"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("WMI")
        ///     </remarks>
        ///     <para>
        ///         Data execution prevention is a hardware feature to prevent buffer overrun attacks by stopping the
        ///         execution of code on data-type memory pages. If <see langword="True"/>, then this feature is
        ///         available. On 64-bit computers, the data execution prevention feature is configured in the BCD store
        ///         and the properties in
        ///         <see langword="Win32_OperatingSystem"/> are set accordingly.
        ///     </para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public static bool DataExecutionPrevention_Available => Get<bool>("DataExecutionPrevention_Available")
            ;

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="bool"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("WMI")<br/>
        ///     </remarks>
        ///     <para>
        ///         When the data execution prevention hardware feature is available, this property indicates that the
        ///         feature is set to work for 32-bit applications if <see langword="True"/>. On 64-bit computers, the
        ///         data execution prevention feature is configured in the
        ///         <c> Boot Configuration Data (BCD) </c> store and the properties in
        ///         <see langword="Win32_OperatingSystem"/> are set accordingly.
        ///     </para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public static bool DataExecutionPrevention_32BitApplications
            => Get<bool>("DataExecutionPrevention_32BitApplications");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="bool"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("WMI")<br/>
        ///     </remarks>
        ///     <para>
        ///         When the data execution prevention hardware feature is available, this property indicates that the
        ///         feature is set to work for drivers if
        ///         <see langword="True"/>. On 64-bit computers, the data execution prevention feature is configured in
        ///         the BCD store and the properties in
        ///         <see langword="Win32_OperatingSystem"/> are set accordingly.
        ///     </para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public static bool DataExecutionPrevention_Drivers => Get<bool>("DataExecutionPrevention_Drivers");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="SupportPolicy"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("WMI")<br/>
        ///     </remarks>
        ///     <para>
        ///         Indicates which Data Execution Prevention (DEP) setting is applied. The DEP setting specifies the
        ///         extent to which DEP applies to 32-bit applications on the system. DEP is always applied to the
        ///         Windows kernel.
        ///     </para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public static SupportPolicy DataExecutionPrevention_SupportPolicy
        {
            get
            {
                byte b;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'SupportPolicy' enum, that it may not recognize that it's of type
                 * byte and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(SupportPolicy);
                _Debug.WriteLineIf(
                                   !Enum.TryParse(
                                                  (b = Get<byte>("DataExecutionPrevention_SupportPolicy")).
                                                      ToString(),
                                                  out result),
                                   b + " is not in the correct format for 'SupportPolicy'",
                                   "FormatException");
                return result;
            }
        }

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="bool"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|
        ///         <c> GetSystemMetrics </c>|SM_DEBUG")<br/>
        ///     </remarks>
        ///     <para>
        ///         Operating system is a checked (debug) build. If
        ///         <see langword="True"/>, the debugging version is installed. Checked builds provide error checking,
        ///         argument verification, and system debugging code. Additional code in a checked binary generates a
        ///         kernel debugger error message and breaks into the debugger. This helps immediately determine the
        ///         cause and location of the error. Performance may be affected in a checked build due to the additional
        ///         code that is executed.
        ///     </para>
        /// </summary>
        public static bool Debug => Get<bool>("Debug");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <see langword="Override"/> ("Description") ,
        ///         <c> MappingStrings </c> ("WMI")<br/>
        ///     </remarks>
        ///     <para>
        ///         Description of the Windows operating system. Some user interfaces for example, those that allow
        ///         editing of this description, limit its length to 48 characters.
        ///     </para>
        /// </summary>
        public static string Description => Get<string>("Description");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="bool"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         If <c> True </c>, the operating system is distributed across several computer system nodes. If so,
        ///         these nodes should be grouped as a cluster.
        ///     </para>
        /// </summary>
        public static bool Distributed => Get<bool>("Distributed");

        /// <summary>
        ///     <remarks> Data type: <see cref="EncryptionLevels"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Encryption level for secure transactions: 40-bit, 128-bit, or n-bit. </para>
        ///     <para> </para>
        /// </summary>
        public static EncryptionLevels EncryptionLevel
        {
            get
            {
                uint ui;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'EncryptionLevel' enum, that it may not recognize that it's of type
                 * uint and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(EncryptionLevels);
                _Debug.WriteLineIf(
                                   !Enum.TryParse((ui = Get<uint>("EncryptionLevel")).ToString(), out result),
                                   ui + " is not in the correct format for 'EncryptionLevels'",
                                   "FormatException");
                return result;
            }
        }

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="ApplicationBoost"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32Registry|SYSTEM\\CurrentControlSet\\Control\\PriorityControl|Win32PrioritySeparation")
        ///         <br/>
        ///     </remarks>
        ///     <para>
        ///         Increase in priority is given to the foreground application. Application boost is implemented by
        ///         giving an application more execution time slices (quantum lengths).
        ///     </para>
        /// </summary>
        public static ApplicationBoost ForegroundApplicationBoost
        {
            get
            {
                byte b;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'ApplicationBoost' enum, that it may not recognize that it's of type
                 * byte and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(ApplicationBoost);
                _Debug.WriteLineIf(
                                   !Enum.TryParse((b = Get<byte>("ForegroundApplicationBoost")).ToString(),
                                                  out result),
                                   b + " is not in the correct format for 'ApplicationBoost'",
                                   "FormatException");
                return result;
            }

            set { Set("ForegroundApplicationBoost", (uint)value); }
        }

        /// <summary>
        ///     <remarks> Data type: <see cref="ulong"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Number, in kilobytes, of physical memory currently unused and available. </para>
        ///     <para> For more information about using <see cref="ulong"/> values in scripts, see
        ///         <c> cripting in WMI </c>. </para>
        /// </summary>
        public static ulong FreePhysicalMemory => Get<ulong>("FreePhysicalMemory");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="ulong"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Number, in kilobytes, that can be mapped into the operating system paging files without causing
        ///         any other pages to be swapped out.
        ///     </para>
        ///     <para>
        ///         For more information about using <see cref="ulong"/> values in scripts, see
        ///         <c> cripting in WMI </c>.
        ///     </para>
        /// </summary>
        public static ulong FreeSpaceInPagingFiles => Get<ulong>("FreeSpaceInPagingFiles");

        /// <summary>
        ///     <remarks> Data type: <see cref="ulong"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Number, in kilobytes, of virtual memory currently unused and available. </para>
        ///     <para> For more information about using <see cref="ulong"/> values in scripts, see
        ///         <c> cripting in WMI </c>. </para>
        /// </summary>
        public static ulong FreeVirutalMemory => Get<ulong>("FreeVirtualMemory");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="DateTime"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Date object was installed. This property does not require a value to indicate that the object is
        ///         installed.
        ///     </para>
        /// </summary>
        public static DateTime InstallDate => Get<DateTime>("InstallDate");

        /// <summary>
        ///     <remarks> Data type: <see cref="DateTime"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Date and time the operating system was last restarted. </para>
        /// </summary>
        public static DateTime LastBootUpTime => Get<DateTime>("LastBootUpTime");

        /// <summary>
        ///     <remarks> Data type: <see cref="DateTime"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Operating system version of the local date and time-of-day. </para>
        /// </summary>
        public static DateTime LocalDateTime => Get<DateTime>("LocalDateTime");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|National Language Support Functions|
        ///         <c> GetLocaleInfo </c>
        ///         |LOCALE_ILANGUAGE")<br/>
        ///     </remarks>
        ///     <para>
        ///         Language identifier used by the operating system. A language identifier is a standard
        ///         international numeric abbreviation for a country/region. Each language has a unique language
        ///         identifier (LANGID), a 16-bit value that consists of a primary language identifier and a secondary
        ///         language identifier.
        ///     </para>
        /// </summary>
        public static string Locale => Get<string>("Locale");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("WMI")<br/>
        ///     </remarks>
        ///     <para>
        ///         Name of the operating system manufacturer. For Windows-based systems, this value is "Microsoft
        ///         Corporation".
        ///     </para>
        /// </summary>
        public static string Manufacturer => Get<string>("Manufacturer");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="uint"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Maximum number of process contexts the operating system can support. The default value set by the
        ///         provider is 4294967295 (0xFFFFFFFF). If there is no fixed maximum, the value should be 0 (zero). On
        ///         systems that have a fixed maximum, this object can help diagnose failures that occur when the maximum
        ///         is reached—if unknown, enter 4294967295 (0xFFFFFFFF).
        ///     </para>
        /// </summary>
        public static uint MaxNumberOfProcesses => Get<uint>("MaxNumberOfProcesses");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="ulong"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Maximum number, in kilobytes, of memory that can be allocated to a process. For operating systems
        ///         with no virtual memory, typically this value is equal to the total amount of physical memory minus
        ///         the memory used by the BIOS and the operating system. For some operating systems, this value may be
        ///         infinity, in which case 0 (zero) should be entered. In other cases, this value could be a constant,
        ///         for example, 2G or 4G.
        ///     </para>
        ///     <para>
        ///         For more information about using <see cref="ulong"/> values in scripts, see
        ///         <c> Scripting in WMI </c>.
        ///     </para>
        /// </summary>
        public static ulong MaxProcessMemorySize => Get<ulong>("MaxProcessMemorySize");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/> <see cref="Array"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("WMI")<br/>
        ///     </remarks>
        ///     <para>
        ///         Multilingual User Interface Pack (MUI Pack ) languages installed on the computer. For example,
        ///         "en-us". MUI Pack languages are resource files that can be installed on the English version of the
        ///         operating system. When an MUI Pack is installed, you can can change the user interface language to
        ///         one of 33 supported languages.
        ///     </para>
        /// </summary>
        public static string[] MUILanguages => Get<string[]>("MUILanguages");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Operating system instance within a computer system. </para>
        /// </summary>
        public static string Name => Get<string>("Name");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="uint"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Number of user licenses for the operating system. If unlimited, enter 0 (zero). If unknown, enter
        ///         -1.
        ///     </para>
        /// </summary>
        public static uint NumberOfLicensedUsers => Get<uint>("NumberOfLicensedUsers");

        /// <summary>
        ///     <remarks> Data type: <see cref="uint"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Number of process contexts currently loaded or running on the operating system. </para>
        /// </summary>
        public static uint NumberOfProcesses => Get<uint>("NumberOfProcesses");

        /// <summary>
        ///     <remarks> Data type: <see cref="uint"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Number of user sessions for which the operating system is storing state information currently. </para>
        /// </summary>
        public static uint NumberOfUsers => Get<uint>("NumberOfUsers");

        /// <summary>
        ///     <remarks> Data type: <see cref="OperatingSystemSKUs"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("WMI")<br/>
        ///     </remarks>
        ///     <para> Stock Keeping Unit (SKU) number for the operating system. These values are the same as the
        ///         <see langword="PRODUCT_*"/> constants defined in WinNT.h that are used with the
        ///         <c> GetProductInfo </c>
        ///         function. </para>
        /// </summary>
        public static OperatingSystemSKUs OperatingSystemSKU
        {
            get
            {
                uint ui;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'OperatingSystemSKUs' enum, that it may not recognize that it's of type
                 * uint and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(OperatingSystemSKUs);
                _Debug.WriteLineIf(
                                   !Enum.TryParse((ui = Get<uint>("OperatingSystemSKU")).ToString(),
                                                  out result),
                                   ui + " is not in the correct format for 'OperatingSystemSKU'",
                                   "FormatException");
                return result;
            }
        }

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32Registry|Software\\Microsoft\\Windows\\CurrentVersion|RegisteredOrganization")
        ///         <br/>
        ///     </remarks>
        ///     <para> Company name for the registered user of the operating system. </para>
        ///     <para> Example: "Microsoft Corporation" </para>
        /// </summary>
        public static string Organization => Get<string>("Organization");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Architecture of the operating system, as opposed to the processor. This property can be localized. </para>
        ///     <para> Example: 32-bit </para>
        /// </summary>
        public static string OSArchitecture => Get<string>("OSArchitecture");

        /// <summary>
        ///     <remarks> Data type: <see cref="OSLanguages"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32Registry|DEFAULT\\Control Panel\\International|Locale")
        ///         <br/>
        ///     </remarks>
        ///     <para> Language version of the operating system installed. </para>
        ///     <para> Example: 0x0807 (German, Switzerland). </para>
        /// </summary>
        public static OSLanguages OSLanguage
        {
            get
            {
                uint ui;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'OSLanguages' enum, that it may not recognize that it's of type
                 * uint and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(OSLanguages);
                _Debug.WriteLineIf(!Enum.TryParse((ui = Get<uint>("OSLanguage")).ToString(), out result),
                                   ui + " is not in the correct format for 'OSLanguage'",
                                   "FormatException");
                return result;
            }
        }

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="ProductSuite"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32Registry|SYSTEM\\CurrentControlSet\\Control\\ProductOptions|ProductSuite") ,
        ///         <c> BitValues </c> ("Small Business", "Enterprise", "BackOffice", "Communication Server", "Terminal
        ///         Server", "Small Business(Restricted)", "Embedded NT", "Data Center")<br/>
        ///     </remarks>
        ///     <para>
        ///         Installed and licensed system product additions to the operating system. For example, the value of
        ///         146 (0x92) for
        ///         <see langword="OSProductSuite"/> indicates Enterprise, Terminal Services, and Data Center (bits one,
        ///         four, and seven set).
        ///     </para>
        /// </summary>
        public static ProductSuite OSProducSuite
        {
            get
            {
                uint ui;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'ProductSuite' enum, that it may not recognize that it's of type
                 * uint and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(ProductSuite);
                _Debug.WriteLineIf(!Enum.TryParse((ui = Get<uint>("OSProductSuite")).ToString(), out result),
                                   ui + " is not in the correct format for 'ProductSuite'",
                                   "FormatException");
                return result;
            }
        }

        /// <summary>
        ///     <remarks> Data type: <see cref="OperatingSystemType"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Type of operating system. </para>
        /// </summary>
        public static OperatingSystemType OSType
        {
            get
            {
                uint ui;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'OperatingSystemType' enum, that it may not recognize that it's of type
                 * ushort and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(OperatingSystemType);
                _Debug.WriteLineIf(!Enum.TryParse((ui = Get<uint>("OSType")).ToString(), out result),
                                   ui + " is not in the correct format for 'OperatingSystemType'",
                                   "FormatException");
                return result;
            }
        }

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Additional description for the current operating system version. </para>
        /// </summary>
        public static string OtherTypeDescription => Get<string>("OtherTypeDescription");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="bool"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         If <see langword="True"/>, the physical address extensions (PAE) are enabled by the operating
        ///         system running on Intel processors. PAE allows applications to address more than 4 GB of physical
        ///         memory. When PAE is enabled, the operating system uses three-level linear address translation rather
        ///         than two-level. Providing more physical memory to an application reduces the need to swap memory to
        ///         the page file and increases performance. To enable, PAE, use the "/PAE" switch in the Boot.ini file.
        ///         For more information about the Physical Address Extension feature, see
        ///         Http://Go.Microsoft.Com/FWLink/p/?LinkID=45912.
        ///     </para>
        /// </summary>
        public static bool PAEEnabled => Get<bool>("PAEEnabled");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32Registry|Software\\Microsoft\\Windows NT\\CurrentVersion|Plus! ProductId")<br/>
        ///     </remarks>
        ///     <para> Not supported. </para>
        /// </summary>
        // TODO Is there a purpose to this property?  Or is it Depricated?
        public static string PlusProductID => Get<string>("PlusProductID");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32Registry|Software\\Microsoft\\Windows NT\\CurrentVersion|Plus! VersionNumber")<br/>
        ///     </remarks>
        ///     <para> Not supported. </para>
        /// </summary>
        // TODO Is there a purpose to this property?  Or is it Depricated?
        public static string PlusVersionNumber => Get<string>("PlusVersionNumber");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="bool"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Specifies whether the operating system booted from an external USB device. If true, the operating
        ///         system has detected it is booting on a supported locally connected storage device.
        ///     </para>
        ///     <para>
        ///         <see langword="Windows Server 2008 R2, Windows 7, Windows Server 2008, and Windows Vista:"/>
        ///         This property is not supported before Windows 8 and Windows Server 2012.
        ///     </para>
        /// </summary>
        public static bool PortableOperatingSystem => Get<bool>("PortableOperatingSystem");

        /// <summary>
        ///     <remarks> Data type: <see cref="bool"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("WMI")<br/>
        ///     </remarks>
        ///     <para> Specifies whether this is the primary operating system. </para>
        /// </summary>
        public static bool Primary => Get<bool>("Primary");

        /// <summary>
        ///     <remarks> Data type: <see cref="ProductTypes"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Additional system information. </para>
        /// </summary>
        public static ProductTypes ProductType
        {
            get
            {
                uint ui;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'ProductTypes' enum, that it may not recognize that it's of type
                 * uint and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(ProductTypes);
                _Debug.WriteLineIf(!Enum.TryParse((ui = Get<uint>("ProductType")).ToString(), out result),
                                   ui + " is not in the correct format for 'ProductTypes'",
                                   "FormatException");
                return result;
            }
        }

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32Registry|Software\\Microsoft\\Windows NT\\CurrentVersion|RegisteredOwner")<br/>
        ///     </remarks>
        ///     <para> Name of the registered user of the operating system. </para>
        ///     <para> Example: "Ben Smith" </para>
        /// </summary>
        public static string RegisteredUser => Get<string>("RegisteredUser");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32Registry|Software\\Microsoft\\Windows NT\\CurrentVersion|ProductId")
        ///         <br/>
        ///     </remarks>
        ///     <para> Operating system product serial identification number. </para>
        ///     <para> Example: "10497-OEM-0031416-71674" </para>
        /// </summary>
        public static string SerialNumber => Get<string>("SerialNumber");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="ushort"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|System Information Structures|<c> OSVERSIONINFOEX </c>
        ///         |wServicePackMajor")<br/>
        ///     </remarks>
        ///     <para>
        ///         Major version number of the service pack installed on the computer system. If no service pack has
        ///         been installed, the value is 0 (zero).
        ///     </para>
        /// </summary>
        public static ushort ServicePackMajorVersion => Get<ushort>("ServicePackMajorVersion");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="ushort"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|System Information Structures|<c> OSVERSIONINFOEX </c>
        ///         |wServicePackMinor")<br/>
        ///     </remarks>
        ///     <para>
        ///         Minor version number of the service pack installed on the computer system. If no service pack has
        ///         been installed, the value is 0 (zero).
        ///     </para>
        /// </summary>
        public static ushort ServicePackMinorVersion => Get<ushort>("ServicePackMinorVersion");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="ulong"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Total number of kilobytes that can be stored in the operating system paging files—0 (zero)
        ///         indicates that there are no paging files. Be aware that this number does not represent the actual
        ///         physical size of the paging file on disk.
        ///     </para>
        ///     <para>
        ///         For more information about using <see cref="ulong"/> values in scripts, see
        ///         <c> Scripting in WMI </c>.
        ///     </para>
        /// </summary>
        public static ulong SizeStoredInPagingFiles => Get<ulong>("SizeStoredInPagingFiles");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="State"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Current status of the object. Various operational and nonoperational statuses can be defined.
        ///         Operational statuses include: "OK", "Degraded", and "Pred Fail" (an element, such as a SMART-enabled
        ///         hard disk drive may function properly, but predicts a failure in the near future). Nonoperational
        ///         statuses include: "Error", "Starting", "Stopping", and "Service". The Service status applies to
        ///         administrative work, such as mirror-resilvering of a disk, reload of a user permissions list, or
        ///         other administrative work. Not all such work is online, but the managed element is neither "OK" nor
        ///         in one of the other states.
        ///     </para>
        /// </summary>
        public static State Status
        {
            get
            {
                var state = Get<string>("Status");
                var result = default(State);
                switch (state.Contains(' ') ? (state = state.Replace(" ", string.Empty)) : state)
                {
                    case nameof(State.OK):
                    case nameof(State.Error):
                    case nameof(State.Degraded):
                    case nameof(State.Unknown):
                    case nameof(State.PredFail):
                    case nameof(State.Starting):
                    case nameof(State.Stopping):
                    case nameof(State.Service):
                        _Debug.WriteLineIf(!Enum.TryParse(state, out result),
                                           state + " is not in the correct format for 'State'",
                                           "FormatException");
                        break;
                    default:
                        _Debug.WriteLine(state + " is not in the correct format for 'State'",
                                         "FormatException");
                        break;
                }

                return result;
            }
        }

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="SuiteMasks"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> BitMap </c> ("0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10") ,
        ///         <c> BitValues </c>
        ///         ("Windows Server 2003, Small Business Edition", "Windows Server 2003, Enterprise Edition", "Windows
        ///         Server 2003, Backoffice Edition", "Windows Server 2003, Communications Edition", "Microsoft Terminal
        ///         Services", "Windows Server 2003, Small Business Edition Restricted", "Windows XP Embedded", "Windows
        ///         Server 2003, Datacenter Edition", "Single User", "Windows XP Home Edition", "Windows Server 2003, Web
        ///         Edition")<br/>
        ///     </remarks>
        ///     <para> Bit flags that identify the product suites available on the system. </para>
        ///     <para>
        ///         For example, to specify both Personal and BackOffice, set
        ///         <see langword="SuiteMask"/> to 4 | 512 or 516.
        ///     </para>
        /// </summary>
        public static SuiteMasks SuiteMask
        {
            get
            {
                uint ui;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'SuiteMasks' enum, that it may not recognize that it's of type
                 * uint and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(SuiteMasks);
                _Debug.WriteLineIf(!Enum.TryParse((ui = Get<uint>("SuiteMask")).ToString(), out result),
                                   ui + " is not in the correct format for 'SuiteMask'",
                                   "FormatException");
                return result;
            }
        }

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|Registry Functions|
        ///         <c> GetPrivateProfileString </c>
        ///         |Paths|TargetDevice")<br/>
        ///     </remarks>
        ///     <para> Physical disk partition on which the operating system is installed. </para>
        /// </summary>
        public static string SystemDevice => Get<string>("SystemDevice");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|System Information Functions|
        ///         <c> GetSystemDirectory </c>")<br/>
        ///     </remarks>
        ///     <para> System directory of the operating system. </para>
        ///     <para> Example: "C:\WINDOWS\SYSTEM32" </para>
        /// </summary>
        public static string SystemDirectory => Get<string>("SystemDirectory");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para> Letter of the disk drive on which the operating system resides. Example: "C:" </para>
        /// </summary>
        public static string SystemDrive => Get<string>("SystemDrive");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="ulong"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         Total swap space in kilobytes. This value may be
        ///         <see langword="NULL"/> (unspecified) if the swap space is not distinguished from page files. However,
        ///         some operating systems distinguish these concepts. For example, in UNIX, whole processes can be
        ///         swapped out when the free page list falls and remains below a specified amount.
        ///     </para>
        ///     <para>
        ///         For more information about using <see cref="ulong"/> values in scripts, see
        ///         <c> Scripting in WMI </c>.
        ///     </para>
        /// </summary>
        public static ulong TotalSwapSpaceSize => Get<ulong>("TotalSwapSpaceSize");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers:<br/>
        ///     </remarks>
        ///     <para>
        ///         Number, in kilobytes, of virtual memory. For example, this may be calculated by adding the amount
        ///         of total RAM to the amount of paging space, that is, adding the amount of memory in or aggregated by
        ///         the computer system to the property, <see cref="SizeStoredInPagingFiles"/>.
        ///     </para>
        ///     <para>
        ///         For more information about using <see cref="ulong"/> values in scripts, see
        ///         <c> Scripting in WMI </c>.
        ///     </para>
        /// </summary>
        public static ulong TotalVirtualMemorySize => Get<ulong>("TotalVirtualMemorySize");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="ulong"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers:<br/>
        ///     </remarks>
        ///     <para>
        ///         Total amount, in kilobytes, of physical memory available to the operating system. This value does
        ///         not necessarily indicate the true amount of physical memory, but what is reported to the operating
        ///         system as available to it.
        ///     </para>
        ///     <para>
        ///         For more information about using <see cref="ulong"/> values in scripts, see
        ///         <c> Scripting in WMI </c>.
        ///     </para>
        /// </summary>
        public static ulong TotalVisibleMemorySize => Get<ulong>("TotalVisableMemorySize");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> Override </c> ("Version") , <c> MappingStrings </c>
        ///         ("Win32API|System Information Structures|
        ///         <c> OSVERSIONINFOEX </c>|dwMajorVersion, dwMinorVersion")<br/>
        ///     </remarks>
        ///     <para> Version number of the operating system. </para>
        ///     <para> Example: "4.0" </para>
        /// </summary>
        public static string Version => Get<string>("Version");

        /// <summary>
        ///     <remarks> Data type: <see cref="string"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c> ("Win32API|System Information Functions|
        ///         <c> GetWindowsDirectory </c>")<br/>
        ///     </remarks>
        ///     <para> Windows directory of the operating system. </para>
        ///     <para> Example: "C:\WINDOWS" </para>
        /// </summary>
        public static string WindowsDirectory => Get<string>("WindowsDirectory");

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="QuantumLengths"/><br/>
        ///         Access type: Read-only<br/>
        ///         Qualifiers: <c> MappingStrings </c>
        ///         ("Win32Registry|SYSTEM\\CurrentControlSet\\Control\\PriorityControl|Win32PrioritySeparation")
        ///         <br/>
        ///     </remarks>
        ///     <para>
        ///         The <see langword="QuantumLength"/> property defines the number of clock ticks per quantum. A
        ///         quantum is a unit of execution time that the scheduler is allowed to give to an application before
        ///         switching to other applications. When a thread runs one quantum, the kernel preempts it and moves it
        ///         to the end of a queue for applications with equal priorities. The actual length of a thread's quantum
        ///         varies across different Windows platforms. For Windows NT/Windows 2000 only.
        ///     </para>
        /// </summary>
        public static QuantumLengths QuantumLength
        {
            get
            {
                byte b;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'QuantumLengths' enum, that it may not recognize that it's of type
                 * byte and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(QuantumLengths);
                _Debug.WriteLineIf(!Enum.TryParse((b = Get<byte>("QuantumLength")).ToString(), out result),
                                   b + " is not in the correct format for 'QuantumLengths'",
                                   "FormatException");
                return result;
            }

            set { Set("QuantumLength", (byte)value); }
        }

        /// <summary>
        ///     <remarks>
        ///         Data type: <see cref="QuantumTypes"/><br/>
        ///         Access type: Read-only<br/>
        ///     </remarks>
        ///     <para>
        ///         The <see langword="QuantumType"/> property specifies either fixed or variable length quantums.
        ///         Windows defaults to variable length quantums where the foreground application has a longer quantum
        ///         than the background applications. Windows Server defaults to fixed-length quantums. A quantum is a
        ///         unit of execution time that the scheduler is allowed to give to an application before switching to
        ///         another application. When a thread runs one quantum, the kernel preempts it and moves it to the end
        ///         of a queue for applications with equal priorities. The actual length of a thread's quantum varies
        ///         across different Windows platforms.
        ///     </para>
        /// </summary>
        public static QuantumTypes QuantumType
        {
            get
            {
                byte b;
                /*
                 * TODO Can't help but think that this may cause an issue for the reason being that even though I'm
                 * using the default value of the 'QuantumTypes' enum, that it may not recognize that it's of type
                 * byte and maybe seen as something else because I'm declaring it implicityly rather than explicitly.
                 */
                var result = default(QuantumTypes);
                _Debug.WriteLineIf(!Enum.TryParse((b = Get<byte>("QuantumType")).ToString(), out result),
                                   b + " is not in the correct format for 'QuantumTu[es'",
                                   "FormatException");
                return result;
            }

            set { Set("QuantumType", (byte)value); }
        }
        #endregion

        #region Members
        private static T Get<T>(string propertyName)
            =>
                (T)
                Convert.ChangeType(
                                   (from x in
                                        new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").
                                        Get().Cast<ManagementObject>()
                                    select x.GetPropertyValue(propertyName)).FirstOrDefault(),
                                   typeof(T));

        private static void Set(string propertyName, object propertyValue) { }
        #endregion

        ////         select x.SetPropertyValue(propertyName, propertyValue));
        ////             new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
        ////        (from x in

        ////=>
    }
}