using IPTestFormASP.Data;
using IPTestFormASP.Models.Entities;
using System.Linq;
using System.Text;

namespace IPTestFormASP.Services
{
    public class IPService
    {
        private IPTestFormASPDbContext context;

        public IPService(IPTestFormASPDbContext context)
        {
            this.context = context;
        }

        public IPInfos CalculateIPInfos()
        {
            IPInfos ipInfos = new IPInfos();

            ipInfos.IPDec = PickRandomIP();
            List<string> ipDecOctets = ipInfos.IPDec.Split(".").ToList();
            List<string> ipBinOctets = GetIPBin(ipDecOctets);

            ipInfos.IPBin = string.Join("", ipBinOctets);
            ipInfos.NetworkClass = GetNetworkClass(ipInfos.IPBin);
            ipInfos.SubnetCount = PickRandomSubnetCount(ipInfos.NetworkClass);
            ipInfos.SMBin = GetSubnetMaskBin(ipInfos.NetworkClass);
            ipInfos.SMDec = IPConvertBinToDec(ipInfos.SMBin);
            ipInfos.NABin = GetNetworkAdressBin(ipInfos.NetworkClass, ipBinOctets);
            ipInfos.NADec = IPConvertBinToDec(ipInfos.NABin);
            ipInfos.BRABin = GetBroadcastAdressBin(ipInfos.NetworkClass, ipBinOctets);
            ipInfos.BRADec = IPConvertBinToDec(ipInfos.BRABin);
            ipInfos.Range = GetRange(ipInfos.NetworkClass, ipDecOctets);
            int power = GetSubnetPower(ipInfos.SubnetCount);

            ipInfos.SubnetSMBin = GetSubnetSMBin(ipInfos.NetworkClass, power);
            ipInfos.SubnetSMDec = IPConvertBinToDec(ipInfos.SubnetSMBin);

            ipInfos.SubnetNABin1 = GetSubnetNABin(1, ipInfos.NetworkClass, ipBinOctets, power);
            ipInfos.SubnetNADec1 = IPConvertBinToDec(ipInfos.SubnetNABin1);
            ipInfos.SubnetBRABin1 = GetSubnetBRABin(1, ipInfos.NetworkClass, ipBinOctets, power);
            ipInfos.SubnetBRADec1 = IPConvertBinToDec(ipInfos.SubnetBRABin1);
            ipInfos.SubnetRange1 = GetSubnetRange(ipInfos.SubnetNADec1, ipInfos.SubnetBRADec1);

            ipInfos.SubnetNABin2 = GetSubnetNABin(2, ipInfos.NetworkClass, ipBinOctets, power);
            ipInfos.SubnetNADec2 = IPConvertBinToDec(ipInfos.SubnetNABin2);
            ipInfos.SubnetBRABin2 = GetSubnetBRABin(2, ipInfos.NetworkClass, ipBinOctets, power);
            ipInfos.SubnetBRADec2 = IPConvertBinToDec(ipInfos.SubnetBRABin2);
            ipInfos.SubnetRange2 = GetSubnetRange(ipInfos.SubnetNADec2, ipInfos.SubnetBRADec2);

            ipInfos.SubnetNABin3 = GetSubnetNABin(3, ipInfos.NetworkClass, ipBinOctets, power);
            ipInfos.SubnetNADec3 = IPConvertBinToDec(ipInfos.SubnetNABin3);
            ipInfos.SubnetBRABin3 = GetSubnetBRABin(3, ipInfos.NetworkClass, ipBinOctets, power);
            ipInfos.SubnetBRADec3 = IPConvertBinToDec(ipInfos.SubnetBRABin3);
            ipInfos.SubnetRange3 = GetSubnetRange(ipInfos.SubnetNADec3, ipInfos.SubnetBRADec3);

            return ipInfos;
        }

        public string PickRandomIP()
        {
            Random random = new Random();
            int firstOctet = 0;
            int secondOctet = 0;
            int thirdOctet = 0;
            int forthOctet = 0;

            do
            {
                firstOctet = random.Next(0, 255);
                secondOctet = random.Next(0, 255);
                thirdOctet = random.Next(0, 255);
                forthOctet = random.Next(0, 255);
            }
            while (IsForbiddenIP(firstOctet, secondOctet, thirdOctet, forthOctet));

            string randomIP = $"{firstOctet}.{secondOctet}.{thirdOctet}.{forthOctet}";
            return randomIP;
        }

        public bool IsForbiddenIP(int firstOctet, int secondOctet, int thirdOctet, int forthOctet)
        {

            if ((firstOctet == 0) ||
                (firstOctet == 10) ||
                (firstOctet == 172 && secondOctet >= 16 && secondOctet <= 31) ||
                            (firstOctet == 192 && secondOctet == 168) ||
                            (firstOctet == 127) ||
                            (firstOctet == 169 && secondOctet == 254) ||
                            (firstOctet == 192 && secondOctet == 0 && thirdOctet == 2) ||
                            (firstOctet == 198 && secondOctet == 51 && thirdOctet == 100) ||
                            (firstOctet == 203 && secondOctet == 0 && thirdOctet == 113) ||
                            (firstOctet >= 224))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> GetIPBin(List<string> ipDecOctets)
        {
            List<string> ipBinOctets = new List<string>();

            for (int a = 0; a < 4; a++)
            {
                string binOctet = Convert.ToString(int.Parse(ipDecOctets[a]), 2);
                string ipBinOctet = string.Empty;
                for (int b = binOctet.Length; b < 8; b++)
                {
                    ipBinOctet += "0";
                }
                ipBinOctet += binOctet;
                ipBinOctets.Add(ipBinOctet);
            }
            return ipBinOctets;
        }

        public char GetNetworkClass(string ipBin)
        {
            if (ipBin.StartsWith("110"))
            {
                return 'C';
            }
            else if (ipBin.StartsWith("0"))
            {
                return 'A';
            }
            else if (ipBin.StartsWith("10"))
            {
                return 'B';
            }
            return '-';
        }

        public string IPConvertBinToDec(string binString)
        {
            List<string> subnetBinOctets = new List<string> { binString.Substring(0, 8), binString.Substring(8, 8), binString.Substring(16, 8), binString.Substring(24, 8) };

            string subnetDec = $"{Convert.ToInt32(subnetBinOctets[0], 2)}.{Convert.ToInt32(subnetBinOctets[1], 2)}.{Convert.ToInt32(subnetBinOctets[2], 2)}." +
                $"{Convert.ToInt32(subnetBinOctets[3], 2)}";
            return subnetDec;
        }

        public int PickRandomSubnetCount(char networkClass)
        {
            Random random = new Random();
            int subnetCount = 0;

            //Spliting the network into more than 1000 makes it harder for the students in my opinion
            //if(networkClass == 'A')
            //{
            //    subnetCount = random.Next(1, 4194303);
            //}
            //else if (networkClass == 'B')
            //{
            //    subnetCount = random.Next(1, 16383);
            //}
            //else if (networkClass == 'C')
            //{
            //    subnetCount = random.Next(1, 63);
            //}

            if (networkClass == 'C')
            {
                subnetCount = random.Next(1, 63);
            }
            else
            {
                subnetCount = random.Next(1, 1000);
            }
            return subnetCount;
        }

        public string GetSubnetMaskBin(char networkClass)
        {
            string networkPart = string.Empty;
            string hostPart = string.Empty;
            switch (networkClass)
            {
                case 'A':
                    networkPart = new string('1', 8);
                    hostPart = new string('0', 24);
                    break;
                case 'B':
                    networkPart = new string('1', 16);
                    hostPart = new string('0', 16);
                    break;
                case 'C':
                    networkPart = new string('1', 24);
                    hostPart = new string('0', 8);
                    break;
            }

            string smBin = networkPart + hostPart;
            return smBin;
        }

        public string GetNetworkAdressBin(char networkClass, List<string> ipBinOctets)
        {
            string networkPart = string.Empty;
            string hostPart = string.Empty;
            switch (networkClass)
            {
                case 'A':
                    networkPart = $"{ipBinOctets[0]}";
                    hostPart = new string('0', 24);
                    break;
                case 'B':
                    networkPart = $"{ipBinOctets[0]}{ipBinOctets[1]}";
                    hostPart = new string('0', 16);
                    break;
                case 'C':
                    networkPart = $"{ipBinOctets[0]}{ipBinOctets[1]}{ipBinOctets[2]}";
                    hostPart = new string('0', 8);
                    break;
            }

            string naBin = networkPart + hostPart;
            return naBin;
        }

        public string GetBroadcastAdressBin(char networkClass, List<string> ipBinOctets)
        {
            string networkPart = string.Empty;
            string hostPart = string.Empty;
            switch (networkClass)
            {
                case 'A':
                    networkPart = $"{ipBinOctets[0]}";
                    hostPart = new string('1', 24);
                    break;
                case 'B':
                    networkPart = $"{ipBinOctets[0]}{ipBinOctets[1]}";
                    hostPart = new string('1', 16);
                    break;
                case 'C':
                    networkPart = $"{ipBinOctets[0]}{ipBinOctets[1]}{ipBinOctets[2]}";
                    hostPart = new string('1', 8);
                    break;
            }

            string braBin = networkPart + hostPart;
            return braBin;
        }

        public string GetRange(char networkClass, List<string> ipDecOctets)
        {
            switch (networkClass)
            {
                case 'A':
                    return $"{ipDecOctets[0]}.0.0.1.{ipDecOctets[0]}.255.255.254";
                case 'B':
                    return $"{ipDecOctets[0]}.{ipDecOctets[1]}.0.1.{ipDecOctets[0]}.{ipDecOctets[1]}.255.254";
                case 'C':
                    return $"{ipDecOctets[0]}.{ipDecOctets[1]}.{ipDecOctets[2]}.1.{ipDecOctets[0]}.{ipDecOctets[1]}.{ipDecOctets[2]}.254";
                default:
                    return string.Empty;
            }
        }

        public static int GetSubnetPower(int subnetCount)
        {
            int power = 0;
            for (int n = 0; n < 25; n++)
            {
                if (subnetCount <= Math.Pow(2, n))
                {
                    power = n;
                    break;
                }
            }
            return power;
        }

        public string GetSubnetSMBin(char networkClass, int power)
        {
            string networkPart = string.Empty;
            string subNetworkPart = string.Empty;
            string hostPart = string.Empty;
            switch (networkClass)
            {
                case 'A':
                    networkPart = new string('1', 8);
                    break;
                case 'B':
                    networkPart = new string('1', 16);
                    break;
                case 'C':
                    networkPart = new string('1', 24);
                    break;
                default:
                    break;
            }
            subNetworkPart = new string('1', power);

            hostPart = new string('0', 32 - (networkPart.Length + subNetworkPart.Length));

            string subnetSMBin = networkPart + subNetworkPart + hostPart;
            return subnetSMBin;
        }

        public static string GetSubnetNABin(int currentSubnetNumber, char networkClass, List<string> ipBinOctets, int power)
        {
            string networkPart = string.Empty;
            string subNetworkPart = string.Empty;
            string hostPart = string.Empty;

            string subnetNumberBin = Convert.ToString(currentSubnetNumber, 2);
            switch (networkClass)
            {
                case 'A':
                    networkPart = $"{ipBinOctets[0]}";
                    break;
                case 'B':
                    networkPart = $"{ipBinOctets[0]}{ipBinOctets[1]}";
                    break;
                case 'C':
                    networkPart = $"{ipBinOctets[0]}{ipBinOctets[1]}{ipBinOctets[2]}";
                    break;
            }
            subNetworkPart += new string('0', power - subnetNumberBin.Length);
            subNetworkPart += subnetNumberBin;

            hostPart += new string('0', 32 - (networkPart.Length + subNetworkPart.Length));

            string subnetNaBin = networkPart + subNetworkPart + hostPart;
            return subnetNaBin;
        }

        public string GetSubnetBRABin(int currentSubnetNumber, char networkClass, List<string> ipBinOctets, int power)
        {
            string networkPart = string.Empty;
            string subNetworkPart = string.Empty;
            string hostPart = string.Empty;

            string subnetNumberBin = Convert.ToString(currentSubnetNumber, 2);
            switch (networkClass)
            {
                case 'A':
                    networkPart = $"{ipBinOctets[0]}";
                    break;
                case 'B':
                    networkPart = $"{ipBinOctets[0]}{ipBinOctets[1]}";
                    break;
                case 'C':
                    networkPart = $"{ipBinOctets[0]}{ipBinOctets[1]}{ipBinOctets[2]}";
                    break;
            }
            subNetworkPart += new string('0', power - subnetNumberBin.Length);
            subNetworkPart += subnetNumberBin;

            hostPart += new string('1', 32 - (networkPart.Length + subNetworkPart.Length));

            string subnetBRABin = networkPart + subNetworkPart + hostPart;
            return subnetBRABin;
        }

        public string GetSubnetRange(string subnetNADec, string subnetBRADec)
        {
            List<string> subnetNADecOctets = subnetNADec.Split(".").ToList();
            List<string> subnetBRADecOctets = subnetBRADec.Split(".").ToList();
            string range = $"{subnetNADecOctets[0]}.{subnetNADecOctets[1]}.{subnetNADecOctets[2]}.{int.Parse(subnetNADecOctets[3]) + 1}." +
                $"{subnetBRADecOctets[0]}.{subnetBRADecOctets[1]}.{subnetBRADecOctets[2]}.{int.Parse(subnetBRADecOctets[3]) - 1}";
            return range;
        }

        public IPInfos UpdateTestDatabase(IPInfos ipInfos, string name, string number, string schoolClass,
            string inputIPBin, char inputNetworkClass, string inputSMBin, string inputSMDec,
            string inputNABin, string inputNADec, string inputBRABin, string inputBRADec, string range,
            string inputSubnetSMBin, string inputSubnetSMDec,
            string inputSubnetNABin1, string inputSubnetNADec1, string inputSubnetBRABin1, string inputSubnetBRADec1, string inputSubnetRange1,
            string inputSubnetNABin2, string inputSubnetNADec2, string inputSubnetBRABin2, string inputSubnetBRADec2, string inputSubnetRange2,
            string inputSubnetNABin3, string inputSubnetNADec3, string inputSubnetBRABin3, string inputSubnetBRADec3, string inputSubnetRange3)
        {
            TimeSpan eetOffset = TimeSpan.FromHours(3);
            DateTime eetNow = DateTime.UtcNow + eetOffset;
            ipInfos.TurnedInDateTime = eetNow;

            ipInfos.Name = name;
            ipInfos.Number = number;
            ipInfos.SchoolClass = schoolClass;
            ipInfos.InputIPBin = inputIPBin;
            ipInfos.InputNetworkClass = inputNetworkClass;
            ipInfos.InputSMBin = inputSMBin;
            ipInfos.InputSMDec = inputSMDec;
            ipInfos.InputNABin = inputNABin;
            ipInfos.InputNADec = inputNADec;
            ipInfos.InputBRABin = inputBRABin;
            ipInfos.InputBRADec = inputBRADec;
            ipInfos.InputRange = range;
            ipInfos.InputSubnetSMBin = inputSubnetSMBin;
            ipInfos.InputSubnetSMDec = inputSubnetSMDec;
            ipInfos.InputSubnetNABin1 = inputSubnetNABin1;
            ipInfos.InputSubnetNADec1 = inputSubnetNADec1;
            ipInfos.InputSubnetBRABin1 = inputSubnetBRABin1;
            ipInfos.InputSubnetBRADec1 = inputSubnetBRADec1;
            ipInfos.InputSubnetRange1 = inputSubnetRange1;
            ipInfos.InputSubnetNABin2 = inputSubnetNABin2;
            ipInfos.InputSubnetNADec2 = inputSubnetNADec2;
            ipInfos.InputSubnetBRABin2 = inputSubnetBRABin2;
            ipInfos.InputSubnetBRADec2 = inputSubnetBRADec2;
            ipInfos.InputSubnetRange2 = inputSubnetRange2;
            ipInfos.InputSubnetNABin3 = inputSubnetNABin3;
            ipInfos.InputSubnetNADec3 = inputSubnetNADec3;
            ipInfos.InputSubnetBRABin3 = inputSubnetBRABin3;
            ipInfos.InputSubnetBRADec3 = inputSubnetBRADec3;
            ipInfos.InputSubnetRange3 = inputSubnetRange3;

            context.Add(ipInfos);
            context.SaveChanges();

            ipInfos = context.IPInfos.OrderBy(p => p.ID).Last();
            return ipInfos;
        }

        public IPInfos GetTestByID(int id)
        {
            IPInfos ipInfos = context.IPInfos.First(p => p.ID == id);
            return ipInfos;
        }
    }
}
