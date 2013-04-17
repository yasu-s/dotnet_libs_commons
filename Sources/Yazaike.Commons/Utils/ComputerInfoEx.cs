namespace Yazaike.Commons.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualBasic.Devices;
    using Microsoft.Win32;

    /// <summary>
    /// ComputerInfo Class
    /// </summary>
    public static class ComputerInfoEx
    {
        /// <summary>Registry Path : Central Processor</summary>
        private const string RegistryPathCentralProcessor = "HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0";

        /// <summary>Registry Path : BIOS</summary>
        private const string RegistryPathBIOS = "HARDWARE\\DESCRIPTION\\System\\BIOS";

        /// <summary>Registry Name : Processor Name</summary>
        private const string RegistryNameProcessorName = "ProcessorNameString";

        /// <summary>Registry Name : System Manufacturer</summary>
        private const string RegistryNameSystemManufacturer = "SystemManufacturer";

        /// <summary>Registry Name : System Product Name</summary>
        private const string RegistryNameSystemProductName = "SystemProductName";

        /// <summary>
        /// Gets OS Full Name.
        /// </summary>
        public static string OSFullName
        {
            get
            {
                ComputerInfo info = new ComputerInfo();
                return info.OSFullName;
            }
        }

        /// <summary>
        /// Gets OS Version String.
        /// </summary>
        public static string OSVersionString
        {
            get { return Environment.OSVersion.VersionString; }
        }

        /// <summary>
        /// Gets OS ServicePack.
        /// </summary>
        public static string OSServicePack
        {
            get { return Environment.OSVersion.ServicePack; }
        }

        /// <summary>
        /// Gets Processor Name.
        /// </summary>
        public static string ProcessorName
        {
            get { return GetLocalMachineRegistryKeyValue(RegistryPathCentralProcessor, RegistryNameProcessorName) as string; }
        }

        /// <summary>
        /// Gets System Manufacturer.
        /// </summary>
        public static string SystemManufacturer
        {
            get { return GetLocalMachineRegistryKeyValue(RegistryPathBIOS, RegistryNameSystemManufacturer) as string; }
        }

        /// <summary>
        /// Gets System Product Name.
        /// </summary>
        public static string SystemProductName
        {
            get { return GetLocalMachineRegistryKeyValue(RegistryPathBIOS, RegistryNameSystemProductName) as string; }
        }

        /// <summary>
        /// Gets Machine Name.
        /// </summary>
        public static string MachineName
        {
            get { return Environment.MachineName; }
        }

        /// <summary>
        /// Gets Domain Name.
        /// </summary>
        public static string DomainName
        {
            get { return Environment.UserDomainName; }
        }

        /// <summary>
        /// Gets Login User Name.
        /// </summary>
        public static string LoginUserName
        {
            get { return Environment.UserName; }
        }

        /// <summary>
        /// Gets Join Domain.
        /// </summary>
        public static bool IsJoinDomain
        {
            get { return !MachineName.Equals(DomainName); }
        }

        /// <summary>
        /// Gets Framework Version.
        /// </summary>
        public static string FrameworkVersion
        {
            get { return Environment.Version.ToString(); }
        }

        /// <summary>
        /// Gets Total Physical Memory.
        /// </summary>
        public static ulong TotalPhysicalMemory
        {
            get
            {
                ComputerInfo info = new ComputerInfo();
                return info.TotalPhysicalMemory;
            }
        }

        /// <summary>
        /// Gets Total Virtual Memory.
        /// </summary>
        public static ulong TotalVirtualMemory
        {
            get
            {
                ComputerInfo info = new ComputerInfo();
                return info.TotalVirtualMemory;
            }
        }

        /// <summary>
        /// Gets Available Physical Memory.
        /// </summary>
        public static ulong AvailablePhysicalMemory
        {
            get
            {
                ComputerInfo info = new ComputerInfo();
                return info.AvailablePhysicalMemory;
            }
        }

        /// <summary>
        /// Gets Available Virtual Memory.
        /// </summary>
        public static ulong AvailableVirtualMemory
        {
            get
            {
                ComputerInfo info = new ComputerInfo();
                return info.AvailableVirtualMemory;
            }
        }

        /// <summary>
        /// Get local machine registry value.
        /// </summary>
        /// <param name="path">Registry path.</param>
        /// <param name="name">Registry name.</param>
        /// <returns>Get registry value.</returns>
        public static object GetLocalMachineRegistryKeyValue(string path, string name)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(path);
            return (key != null) ? key.GetValue(name) : null;
        }
    }
}
