using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancescoMagliocco.Utils.Helpers
{
    using System.Management;

    /// <summary>
    /// Used to retreive information about the current <see cref="Environment.OSVersion"/>.  <seealso cref="Environment"/>.
    /// </summary>
    public static class OSInfo
    {
        /// <summary>
        /// Gets the inernal <see cref="OperatingSystem"/> representing the current Operating System (<see cref="Environment.OSVersion"/>) via <code>Environment.OSVersion;</code>.  <seealso cref="Environment"/>.
        /// </summary>
        /// <value>The <see cref="OperatingSystem"/> representing the current Operating System.  <see cref="Environment.OSVersion"/>.</value>
        public static OperatingSystem InternalOperatingSystem => Environment.OSVersion;

        /// <summary>
        /// Gets the inernal <see cref="Version"/> representing the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/> via <code>Environment.OSVersion.Version;</code>.  <seealso cref="Environment"/>.
        /// </summary>
        /// <value>The <see cref="Version"/> representing the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.</value>
        public static Version InternalVersion => Environment.OSVersion.Version;

        /// <summary>
        /// Gets the internal <see cref="PlatformID"/> representing the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Platform"/> via <code>Environment.OSVersion.Platform;</code>.  <seealso cref="Environment"/>.
        /// </summary>
        /// <value>The <see cref="PlatformID"/> representing the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Platform"/>.</value>
        public static PlatformID Platform => Environment.OSVersion.Platform;

        /// <summary>
        /// Gets the <seealso cref="OperatingSystem.ServicePack"/> of the current Operating System.  <see cref="Environment.OSVersion"/>.
        /// </summary>
        /// <value>The <seealso cref="OperatingSystem.ServicePack"/> of the current Operating System.  <see cref="Environment.OSVersion"/>.</value>
        public static string ServicePack => Environment.OSVersion.ServicePack;

        /// <summary>
        /// Gets the <see cref="Version.Major"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.
        /// </summary>
        /// <value>The <see cref="Version.Major"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.</value>
        public static int MajorVersion => Environment.OSVersion.Version.Major;

        /// <summary>
        /// Gets the <see cref="Version.Minor"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.
        /// </summary>
        /// <value>The <see cref="Version.Minor"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.</value>
        public static int MinorVersion => Environment.OSVersion.Version.Minor;

        /// <summary>
        /// Gets the <see cref="Version.Build"/> number of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.
        /// </summary>
        /// <value>The <see cref="Version.Build"/> number of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.</value>
        public static int Build => Environment.OSVersion.Version.Build;

        /// <summary>
        /// Gets the <see cref="Version.Revision"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.
        /// </summary>
        /// <value>The <see cref="Version.Revision"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.</value>
        public static int Revision => Environment.OSVersion.Version.Revision;

        /// <summary>
        /// Gets the <see cref="Version.MajorRevision"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.
        /// </summary>
        /// <value>The <see cref="Version.MajorRevision"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.</value>
        public static short MajorRevisionVersion => Environment.OSVersion.Version.MajorRevision;

        /// <summary>
        /// Gets the <see cref="Version.MinorRevision"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.
        /// </summary>
        /// <value>The <see cref="Version.MinorRevision"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/>.</value>
        public static short MinorRevisionVersion => Environment.OSVersion.Version.MinorRevision;

        /// <summary>
        /// Gets <see cref="OperatingSystem.VersionString"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/> including the <see cref="PlatformID"/> and <see cref="OperatingSystem.ServicePack"/>.
        /// </summary>
        /// <value>The <see cref="OperatingSystem.VersionString"/> of the current Operating System's (<see cref="Environment.OSVersion"/>) <see cref="OperatingSystem.Version"/> including the <see cref="PlatformID"/> and <see cref="OperatingSystem.ServicePack"/>.</value>
        public static string VersionString => Environment.OSVersion.VersionString;

        /// <summary>
        /// Gets the full name of the current Operating System (<see cref="Environment.OSVersion"/>) including the <see cref="WindowsName"/> and <see cref="Edition"/>.
        /// </summary>
        /// <value>Full name of the current Operating System.  <see cref="Environment.OSVersion"/>.  <example>Microsoft Windows 10 Pro</example></value>
        public static string FullOSName
            =>
                (from x in
                     new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                 select x.GetPropertyValue("Caption")).FirstOrDefault()?.ToString().Trim() ?? "Unknown";

        /// <summary>
        /// Gets the Windows Name of the current Operating System.  <see cref="Environment.OSVersion"/>.  <seealso cref="FullOSName"/>.
        /// </summary>
        /// <value>The Windows Name of the current Operating System.  <see cref="Environment.OSVersion"/>.  <example>Windows 10</example></value>
        public static string WindowsName
        {
            get
            {
                var fullOSNameArray = FullOSName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return fullOSNameArray.Length < 3 ? "Unknown" : string.Format("{0} {1}", fullOSNameArray[1], fullOSNameArray[2]);
            }
        }

        /// <summary>
        /// Gets the Edition of the current Operating System.  <see cref="Environment.OSVersion"/>.  <seealso cref="FullOSName"/>.  <seealso cref="WindowsName"/>.
        /// </summary>
        /// <value>The Edition of the current Operating System.  <see cref="Environment.OSVersion"/>.  <example>Pro</example></value>
        public static string Edition
        {
            get
            {
                var windowsName = "Windows " + WindowsName;
                string fullOSName;
                return (fullOSName = FullOSName).Contains(windowsName)
                           ? fullOSName.Remove(0, windowsName.Length).Trim()
                           : "Unknown";
            }
        }
    }
}
