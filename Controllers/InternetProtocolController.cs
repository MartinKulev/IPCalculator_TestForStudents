using IPTestFormASP.Models.Entities;
using IPTestFormASP.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace IPTestFormASP.Controllers
{
    public class InternetProtocolController : Controller
    {
        private IPService ipService;

        public InternetProtocolController(IPService ipService)
        {
            this.ipService = ipService;
        }


        public IActionResult TestForm()
        {
            IPInfos ipInfos = ipService.CalculateIPInfos();
            TempData["IPInfos"] = JsonConvert.SerializeObject(ipInfos);
            return View(ipInfos);          
        }

        [HttpPost]
        public IActionResult TestForm(string name, string number, string schoolClass,
            string ipBin1, string ipBin2, string ipBin3, string ipBin4, string ipBin5, string ipBin6, string ipBin7,
            string ipBin8, string ipBin9, string ipBin10, string ipBin11, string ipBin12, string ipBin13, string ipBin14,
            string ipBin15, string ipBin16, string ipBin17, string ipBin18, string ipBin19, string ipBin20,
            string ipBin21, string ipBin22, string ipBin23, string ipBin24, string ipBin25, string ipBin26,
            string ipBin27, string ipBin28, string ipBin29, string ipBin30,string ipBin31, string ipBin32,
            char networkClass,
            string smBin1, string smBin2, string smBin3, string smBin4, string smBin5, string smBin6, string smBin7,
            string smBin8, string smBin9, string smBin10, string smBin11, string smBin12, string smBin13, string smBin14,
            string smBin15, string smBin16, string smBin17, string smBin18, string smBin19, string smBin20, 
            string smBin21, string smBin22, string smBin23, string smBin24, string smBin25, string smBin26, 
            string smBin27, string smBin28, string smBin29, string smBin30, string smBin31, string smBin32,
            string smDec1, string smDec2, string smDec3, string smDec4,
            string naBin1, string naBin2, string naBin3, string naBin4, string naBin5, string naBin6, string naBin7,
            string naBin8, string naBin9, string naBin10, string naBin11, string naBin12, string naBin13, string naBin14,
            string naBin15, string naBin16, string naBin17, string naBin18, string naBin19, string naBin20,
            string naBin21, string naBin22, string naBin23, string naBin24, string naBin25, string naBin26,
            string naBin27, string naBin28, string naBin29, string naBin30, string naBin31, string naBin32,
            string naDec1, string naDec2, string naDec3, string naDec4,
            string braBin1, string braBin2, string braBin3, string braBin4, string braBin5, string braBin6, string braBin7,
            string braBin8, string braBin9, string braBin10, string braBin11, string braBin12, string braBin13, string braBin14,
            string braBin15, string braBin16, string braBin17, string braBin18, string braBin19, string braBin20,
            string braBin21, string braBin22, string braBin23, string braBin24, string braBin25, string braBin26,
            string braBin27, string braBin28, string braBin29, string braBin30, string braBin31, string braBin32,
            string braDec1, string braDec2, string braDec3, string braDec4,
            string rangeFrom1, string rangeFrom2, string rangeFrom3, string rangeFrom4,
            string rangeTo1, string rangeTo2, string rangeTo3, string rangeTo4,
            string subnetSMBin1, string subnetSMBin2, string subnetSMBin3, string subnetSMBin4, string subnetSMBin5, string subnetSMBin6, string subnetSMBin7,
            string subnetSMBin8, string subnetSMBin9, string subnetSMBin10, string subnetSMBin11, string subnetSMBin12, string subnetSMBin13, string subnetSMBin14,
            string subnetSMBin15, string subnetSMBin16, string subnetSMBin17, string subnetSMBin18, string subnetSMBin19, string subnetSMBin20,
            string subnetSMBin21, string subnetSMBin22, string subnetSMBin23, string subnetSMBin24, string subnetSMBin25, string subnetSMBin26,
            string subnetSMBin27, string subnetSMBin28, string subnetSMBin29, string subnetSMBin30, string subnetSMBin31, string subnetSMBin32,
            string subnetSMDec1, string subnetSMDec2, string subnetSMDec3, string subnetSMDec4,

            string subnetNABin11, string subnetNABin12, string subnetNABin13, string subnetNABin14, string subnetNABin15, string subnetNABin16, string subnetNABin17,
            string subnetNABin18, string subnetNABin19, string subnetNABin110, string subnetNABin111, string subnetNABin112, string subnetNABin113, string subnetNABin114,
            string subnetNABin115, string subnetNABin116, string subnetNABin117, string subnetNABin118, string subnetNABin119, string subnetNABin120,
            string subnetNABin121, string subnetNABin122, string subnetNABin123, string subnetNABin124, string subnetNABin125, string subnetNABin126,
            string subnetNABin127, string subnetNABin128, string subnetNABin129, string subnetNABin130, string subnetNABin131, string subnetNABin132,
            string subnetNADec11, string subnetNADec12, string subnetNADec13, string subnetNADec14,
            string subnetBRABin11, string subnetBRABin12, string subnetBRABin13, string subnetBRABin14, string subnetBRABin15, string subnetBRABin16, string subnetBRABin17,
            string subnetBRABin18, string subnetBRABin19, string subnetBRABin110, string subnetBRABin111, string subnetBRABin112, string subnetBRABin113, string subnetBRABin114,
            string subnetBRABin115, string subnetBRABin116, string subnetBRABin117, string subnetBRABin118, string subnetBRABin119, string subnetBRABin120,
            string subnetBRABin121, string subnetBRABin122, string subnetBRABin123, string subnetBRABin124, string subnetBRABin125, string subnetBRABin126,
            string subnetBRABin127, string subnetBRABin128, string subnetBRABin129, string subnetBRABin130, string subnetBRABin131, string subnetBRABin132,
            string subnetBRADec11, string subnetBRADec12, string subnetBRADec13, string subnetBRADec14,
            string subnetRangeFrom11, string subnetRangeFrom12, string subnetRangeFrom13, string subnetRangeFrom14,
            string subnetRangeTo11, string subnetRangeTo12, string subnetRangeTo13, string subnetRangeTo14,

            string subnetNABin21, string subnetNABin22, string subnetNABin23, string subnetNABin24, string subnetNABin25, string subnetNABin26, string subnetNABin27,
            string subnetNABin28, string subnetNABin29, string subnetNABin210, string subnetNABin211, string subnetNABin212, string subnetNABin213, string subnetNABin214,
            string subnetNABin215, string subnetNABin216, string subnetNABin217, string subnetNABin218, string subnetNABin219, string subnetNABin220,
            string subnetNABin221, string subnetNABin222, string subnetNABin223, string subnetNABin224, string subnetNABin225, string subnetNABin226,
            string subnetNABin227, string subnetNABin228, string subnetNABin229, string subnetNABin230, string subnetNABin231, string subnetNABin232,
            string subnetNADec21, string subnetNADec22, string subnetNADec23, string subnetNADec24,
            string subnetBRABin21, string subnetBRABin22, string subnetBRABin23, string subnetBRABin24, string subnetBRABin25, string subnetBRABin26, string subnetBRABin27,
            string subnetBRABin28, string subnetBRABin29, string subnetBRABin210, string subnetBRABin211, string subnetBRABin212, string subnetBRABin213, string subnetBRABin214,
            string subnetBRABin215, string subnetBRABin216, string subnetBRABin217, string subnetBRABin218, string subnetBRABin219, string subnetBRABin220,
            string subnetBRABin221, string subnetBRABin222, string subnetBRABin223, string subnetBRABin224, string subnetBRABin225, string subnetBRABin226,
            string subnetBRABin227, string subnetBRABin228, string subnetBRABin229, string subnetBRABin230, string subnetBRABin231, string subnetBRABin232,
            string subnetBRADec21, string subnetBRADec22, string subnetBRADec23, string subnetBRADec24,
            string subnetRangeFrom21, string subnetRangeFrom22, string subnetRangeFrom23, string subnetRangeFrom24,
            string subnetRangeTo21, string subnetRangeTo22, string subnetRangeTo23, string subnetRangeTo24,

            string subnetNABin31, string subnetNABin32, string subnetNABin33, string subnetNABin34, string subnetNABin35, string subnetNABin36, string subnetNABin37,
            string subnetNABin38, string subnetNABin39, string subnetNABin310, string subnetNABin311, string subnetNABin312, string subnetNABin313, string subnetNABin314,
            string subnetNABin315, string subnetNABin316, string subnetNABin317, string subnetNABin318, string subnetNABin319, string subnetNABin320,
            string subnetNABin321, string subnetNABin322, string subnetNABin323, string subnetNABin324, string subnetNABin325, string subnetNABin326,
            string subnetNABin327, string subnetNABin328, string subnetNABin329, string subnetNABin330, string subnetNABin331, string subnetNABin332,
            string subnetNADec31, string subnetNADec32, string subnetNADec33, string subnetNADec34,
            string subnetBRABin31, string subnetBRABin32, string subnetBRABin33, string subnetBRABin34, string subnetBRABin35, string subnetBRABin36, string subnetBRABin37,
            string subnetBRABin38, string subnetBRABin39, string subnetBRABin310, string subnetBRABin311, string subnetBRABin312, string subnetBRABin313, string subnetBRABin314,
            string subnetBRABin315, string subnetBRABin316, string subnetBRABin317, string subnetBRABin318, string subnetBRABin319, string subnetBRABin320,
            string subnetBRABin321, string subnetBRABin322, string subnetBRABin323, string subnetBRABin324, string subnetBRABin325, string subnetBRABin326,
            string subnetBRABin327, string subnetBRABin328, string subnetBRABin329, string subnetBRABin330, string subnetBRABin331, string subnetBRABin332,
            string subnetBRADec31, string subnetBRADec32, string subnetBRADec33, string subnetBRADec34,
            string subnetRangeFrom31, string subnetRangeFrom32, string subnetRangeFrom33, string subnetRangeFrom34,
            string subnetRangeTo31, string subnetRangeTo32, string subnetRangeTo33, string subnetRangeTo34)
        {
            IPInfos ipInfos = JsonConvert.DeserializeObject<IPInfos>(TempData["IPInfos"] as string);

            ipBin1 = ipBin1 ?? "-";
            ipBin2 = ipBin2 ?? "-";
            ipBin3 = ipBin3 ?? "-";
            ipBin4 = ipBin4 ?? "-";
            ipBin5 = ipBin5 ?? "-";
            ipBin6 = ipBin6 ?? "-";
            ipBin7 = ipBin7 ?? "-";
            ipBin8 = ipBin8 ?? "-";
            ipBin9 = ipBin9 ?? "-";
            ipBin10 = ipBin10 ?? "-";
            ipBin11 = ipBin11 ?? "-";
            ipBin12 = ipBin12 ?? "-";
            ipBin13 = ipBin13 ?? "-";
            ipBin14 = ipBin14 ?? "-";
            ipBin15 = ipBin15 ?? "-";
            ipBin16 = ipBin16 ?? "-";
            ipBin17 = ipBin17 ?? "-";
            ipBin18 = ipBin18 ?? "-";
            ipBin19 = ipBin19 ?? "-";
            ipBin20 = ipBin20 ?? "-";
            ipBin21 = ipBin21 ?? "-";
            ipBin22 = ipBin22 ?? "-";
            ipBin23 = ipBin23 ?? "-";
            ipBin24 = ipBin24 ?? "-";
            ipBin25 = ipBin25 ?? "-";
            ipBin26 = ipBin26 ?? "-";
            ipBin27 = ipBin27 ?? "-";
            ipBin28 = ipBin28 ?? "-";
            ipBin29 = ipBin29 ?? "-";
            ipBin30 = ipBin30 ?? "-";
            ipBin31 = ipBin31 ?? "-";
            ipBin32 = ipBin32 ?? "-";
            smBin1 = smBin1 ?? "-";
            smBin2 = smBin2 ?? "-";
            smBin3 = smBin3 ?? "-";
            smBin4 = smBin4 ?? "-";
            smBin5 = smBin5 ?? "-";
            smBin6 = smBin6 ?? "-";
            smBin7 = smBin7 ?? "-";
            smBin8 = smBin8 ?? "-";
            smBin9 = smBin9 ?? "-";
            smBin10 = smBin10 ?? "-";
            smBin11 = smBin11 ?? "-";
            smBin12 = smBin12 ?? "-";
            smBin13 = smBin13 ?? "-";
            smBin14 = smBin14 ?? "-";
            smBin15 = smBin15 ?? "-";
            smBin16 = smBin16 ?? "-";
            smBin17 = smBin17 ?? "-";
            smBin18 = smBin18 ?? "-";
            smBin19 = smBin19 ?? "-";
            smBin20 = smBin20 ?? "-";
            smBin21 = smBin21 ?? "-";
            smBin22 = smBin22 ?? "-";
            smBin23 = smBin23 ?? "-";
            smBin24 = smBin24 ?? "-";
            smBin25 = smBin25 ?? "-";
            smBin26 = smBin26 ?? "-";
            smBin27 = smBin27 ?? "-";
            smBin28 = smBin28 ?? "-";
            smBin29 = smBin29 ?? "-";
            smBin30 = smBin30 ?? "-";
            smBin31 = smBin31 ?? "-";
            smBin32 = smBin32 ?? "-";
            smDec1 = smDec1 ?? "-";
            smDec2 = smDec2 ?? "-";
            smDec3 = smDec3 ?? "-";
            smDec4 = smDec4 ?? "-";
            naBin1 = naBin1 ?? "-";
            naBin2 = naBin2 ?? "-";
            naBin3 = naBin3 ?? "-";
            naBin4 = naBin4 ?? "-";
            naBin5 = naBin5 ?? "-";
            naBin6 = naBin6 ?? "-";
            naBin7 = naBin7 ?? "-";
            naBin8 = naBin8 ?? "-";
            naBin9 = naBin9 ?? "-";
            naBin10 = naBin10 ?? "-";
            naBin11 = naBin11 ?? "-";
            naBin12 = naBin12 ?? "-";
            naBin13 = naBin13 ?? "-";
            naBin14 = naBin14 ?? "-";
            naBin15 = naBin15 ?? "-";
            naBin16 = naBin16 ?? "-";
            naBin17 = naBin17 ?? "-";
            naBin18 = naBin18 ?? "-";
            naBin19 = naBin19 ?? "-";
            naBin20 = naBin20 ?? "-";
            naBin21 = naBin21 ?? "-";
            naBin22 = naBin22 ?? "-";
            naBin23 = naBin23 ?? "-";
            naBin24 = naBin24 ?? "-";
            naBin25 = naBin25 ?? "-";
            naBin26 = naBin26 ?? "-";
            naBin27 = naBin27 ?? "-";
            naBin28 = naBin28 ?? "-";
            naBin29 = naBin29 ?? "-";
            naBin30 = naBin30 ?? "-";
            naBin31 = naBin31 ?? "-";
            naBin32 = naBin32 ?? "-";
            naDec1 = naDec1 ?? "-";
            naDec2 = naDec2 ?? "-";
            naDec3 = naDec3 ?? "-";
            naDec4 = naDec4 ?? "-";
            braBin1 = braBin1 ?? "-";
            braBin2 = braBin2 ?? "-";
            braBin3 = braBin3 ?? "-";
            braBin4 = braBin4 ?? "-";
            braBin5 = braBin5 ?? "-";
            braBin6 = braBin6 ?? "-";
            braBin7 = braBin7 ?? "-";
            braBin8 = braBin8 ?? "-";
            braBin9 = braBin9 ?? "-";
            braBin10 = braBin10 ?? "-";
            braBin11 = braBin11 ?? "-";
            braBin12 = braBin12 ?? "-";
            braBin13 = braBin13 ?? "-";
            braBin14 = braBin14 ?? "-";
            braBin15 = braBin15 ?? "-";
            braBin16 = braBin16 ?? "-";
            braBin17 = braBin17 ?? "-";
            braBin18 = braBin18 ?? "-";
            braBin19 = braBin19 ?? "-";
            braBin20 = braBin20 ?? "-";
            braBin21 = braBin21 ?? "-";
            braBin22 = braBin22 ?? "-";
            braBin23 = braBin23 ?? "-";
            braBin24 = braBin24 ?? "-";
            braBin25 = braBin25 ?? "-";
            braBin26 = braBin26 ?? "-";
            braBin27 = braBin27 ?? "-";
            braBin28 = braBin28 ?? "-";
            braBin29 = braBin29 ?? "-";
            braBin30 = braBin30 ?? "-";
            braBin31 = braBin31 ?? "-";
            braBin32 = braBin32 ?? "-";
            braDec1 = braDec1 ?? "-";
            braDec2 = braDec2 ?? "-";
            braDec3 = braDec3 ?? "-";
            braDec4 = braDec4 ?? "-";
            rangeFrom1 = rangeFrom1 ?? "-";
            rangeFrom2 = rangeFrom2 ?? "-";
            rangeFrom3 = rangeFrom3 ?? "-";
            rangeFrom4 = rangeFrom4 ?? "-";
            rangeTo1 = rangeTo1 ?? "-";
            rangeTo2 = rangeTo2 ?? "-";
            rangeTo3 = rangeTo3 ?? "-";
            rangeTo4 = rangeTo4 ?? "-";
            subnetSMBin1 = subnetSMBin1 ?? "-";
            subnetSMBin2 = subnetSMBin2 ?? "-";
            subnetSMBin3 = subnetSMBin3 ?? "-";
            subnetSMBin4 = subnetSMBin4 ?? "-";
            subnetSMBin5 = subnetSMBin5 ?? "-";
            subnetSMBin6 = subnetSMBin6 ?? "-";
            subnetSMBin7 = subnetSMBin7 ?? "-";
            subnetSMBin8 = subnetSMBin8 ?? "-";
            subnetSMBin9 = subnetSMBin9 ?? "-";
            subnetSMBin10 = subnetSMBin10 ?? "-";
            subnetSMBin11 = subnetSMBin11 ?? "-";
            subnetSMBin12 = subnetSMBin12 ?? "-";
            subnetSMBin13 = subnetSMBin13 ?? "-";
            subnetSMBin14 = subnetSMBin14 ?? "-";
            subnetSMBin15 = subnetSMBin15 ?? "-";
            subnetSMBin16 = subnetSMBin16 ?? "-";
            subnetSMBin17 = subnetSMBin17 ?? "-";
            subnetSMBin18 = subnetSMBin18 ?? "-";
            subnetSMBin19 = subnetSMBin19 ?? "-";
            subnetSMBin20 = subnetSMBin20 ?? "-";
            subnetSMBin21 = subnetSMBin21 ?? "-";
            subnetSMBin22 = subnetSMBin22 ?? "-";
            subnetSMBin23 = subnetSMBin23 ?? "-";
            subnetSMBin24 = subnetSMBin24 ?? "-";
            subnetSMBin25 = subnetSMBin25 ?? "-";
            subnetSMBin26 = subnetSMBin26 ?? "-";
            subnetSMBin27 = subnetSMBin27 ?? "-";
            subnetSMBin28 = subnetSMBin28 ?? "-";
            subnetSMBin29 = subnetSMBin29 ?? "-";
            subnetSMBin30 = subnetSMBin30 ?? "-";
            subnetSMBin31 = subnetSMBin31 ?? "-";
            subnetSMBin32 = subnetSMBin32 ?? "-";
            subnetSMDec1 = subnetSMDec1 ?? "-";
            subnetSMDec2 = subnetSMDec2 ?? "-";
            subnetSMDec3 = subnetSMDec3 ?? "-";
            subnetSMDec4 = subnetSMDec4 ?? "-";
            subnetNABin11 = subnetNABin11 ?? "-";
            subnetNABin12 = subnetNABin12 ?? "-";
            subnetNABin13 = subnetNABin13 ?? "-";
            subnetNABin14 = subnetNABin14 ?? "-";
            subnetNABin15 = subnetNABin15 ?? "-";
            subnetNABin16 = subnetNABin16 ?? "-";
            subnetNABin17 = subnetNABin17 ?? "-";
            subnetNABin18 = subnetNABin18 ?? "-";
            subnetNABin19 = subnetNABin19 ?? "-";
            subnetNABin110 = subnetNABin110 ?? "-";
            subnetNABin111 = subnetNABin111 ?? "-";
            subnetNABin112 = subnetNABin112 ?? "-";
            subnetNABin113 = subnetNABin113 ?? "-";
            subnetNABin114 = subnetNABin114 ?? "-";
            subnetNABin115 = subnetNABin115 ?? "-";
            subnetNABin116 = subnetNABin116 ?? "-";
            subnetNABin117 = subnetNABin117 ?? "-";
            subnetNABin118 = subnetNABin118 ?? "-";
            subnetNABin119 = subnetNABin119 ?? "-";
            subnetNABin120 = subnetNABin120 ?? "-";
            subnetNABin121 = subnetNABin121 ?? "-";
            subnetNABin122 = subnetNABin122 ?? "-";
            subnetNABin123 = subnetNABin123 ?? "-";
            subnetNABin124 = subnetNABin124 ?? "-";
            subnetNABin125 = subnetNABin125 ?? "-";
            subnetNABin126 = subnetNABin126 ?? "-";
            subnetNABin127 = subnetNABin127 ?? "-";
            subnetNABin128 = subnetNABin128 ?? "-";
            subnetNABin129 = subnetNABin129 ?? "-";
            subnetNABin130 = subnetNABin130 ?? "-";
            subnetNABin131 = subnetNABin131 ?? "-";
            subnetNABin132 = subnetNABin132 ?? "-";
            subnetNADec11 = subnetNADec11 ?? "-";
            subnetNADec12 = subnetNADec12 ?? "-";
            subnetNADec13 = subnetNADec13 ?? "-";
            subnetNADec14 = subnetNADec14 ?? "-";
            subnetBRABin11 = subnetBRABin11 ?? "-";
            subnetBRABin12 = subnetBRABin12 ?? "-";
            subnetBRABin13 = subnetBRABin13 ?? "-";
            subnetBRABin14 = subnetBRABin14 ?? "-";
            subnetBRABin15 = subnetBRABin15 ?? "-";
            subnetBRABin16 = subnetBRABin16 ?? "-";
            subnetBRABin17 = subnetBRABin17 ?? "-";
            subnetBRABin18 = subnetBRABin18 ?? "-";
            subnetBRABin19 = subnetBRABin19 ?? "-";
            subnetBRABin110 = subnetBRABin110 ?? "-";
            subnetBRABin111 = subnetBRABin111 ?? "-";
            subnetBRABin112 = subnetBRABin112 ?? "-";
            subnetBRABin113 = subnetBRABin113 ?? "-";
            subnetBRABin114 = subnetBRABin114 ?? "-";
            subnetBRABin115 = subnetBRABin115 ?? "-";
            subnetBRABin116 = subnetBRABin116 ?? "-";
            subnetBRABin117 = subnetBRABin117 ?? "-";
            subnetBRABin118 = subnetBRABin118 ?? "-";
            subnetBRABin119 = subnetBRABin119 ?? "-";
            subnetBRABin120 = subnetBRABin120 ?? "-";
            subnetBRABin121 = subnetBRABin121 ?? "-";
            subnetBRABin122 = subnetBRABin122 ?? "-";
            subnetBRABin123 = subnetBRABin123 ?? "-";
            subnetBRABin124 = subnetBRABin124 ?? "-";
            subnetBRABin125 = subnetBRABin125 ?? "-";
            subnetBRABin126 = subnetBRABin126 ?? "-";
            subnetBRABin127 = subnetBRABin127 ?? "-";
            subnetBRABin128 = subnetBRABin128 ?? "-";
            subnetBRABin129 = subnetBRABin129 ?? "-";
            subnetBRABin130 = subnetBRABin130 ?? "-";
            subnetBRABin131 = subnetBRABin131 ?? "-";
            subnetBRABin132 = subnetBRABin132 ?? "-";
            subnetBRADec11 = subnetBRADec11 ?? "-";
            subnetBRADec12 = subnetBRADec12 ?? "-";
            subnetBRADec13 = subnetBRADec13 ?? "-";
            subnetBRADec14 = subnetBRADec14 ?? "-";
            subnetRangeFrom11 = subnetRangeFrom11 ?? "-";
            subnetRangeFrom12 = subnetRangeFrom12 ?? "-";
            subnetRangeFrom13 = subnetRangeFrom13 ?? "-";
            subnetRangeFrom14 = subnetRangeFrom14 ?? "-";
            subnetRangeTo11 = subnetRangeTo11 ?? "-";
            subnetRangeTo12 = subnetRangeTo12 ?? "-";
            subnetRangeTo13 = subnetRangeTo13 ?? "-";
            subnetRangeTo14 = subnetRangeTo14 ?? "-";
            subnetNABin21 = subnetNABin21 ?? "-";
            subnetNABin22 = subnetNABin22 ?? "-";
            subnetNABin23 = subnetNABin23 ?? "-";
            subnetNABin24 = subnetNABin24 ?? "-";
            subnetNABin25 = subnetNABin25 ?? "-";
            subnetNABin26 = subnetNABin26 ?? "-";
            subnetNABin27 = subnetNABin27 ?? "-";
            subnetNABin28 = subnetNABin28 ?? "-";
            subnetNABin29 = subnetNABin29 ?? "-";
            subnetNABin210 = subnetNABin210 ?? "-";
            subnetNABin211 = subnetNABin211 ?? "-";
            subnetNABin212 = subnetNABin212 ?? "-";
            subnetNABin213 = subnetNABin213 ?? "-";
            subnetNABin214 = subnetNABin214 ?? "-";
            subnetNABin215 = subnetNABin215 ?? "-";
            subnetNABin216 = subnetNABin216 ?? "-";
            subnetNABin217 = subnetNABin217 ?? "-";
            subnetNABin218 = subnetNABin218 ?? "-";
            subnetNABin219 = subnetNABin219 ?? "-";
            subnetNABin220 = subnetNABin220 ?? "-";
            subnetNABin221 = subnetNABin221 ?? "-";
            subnetNABin222 = subnetNABin222 ?? "-";
            subnetNABin223 = subnetNABin223 ?? "-";
            subnetNABin224 = subnetNABin224 ?? "-";
            subnetNABin225 = subnetNABin225 ?? "-";
            subnetNABin226 = subnetNABin226 ?? "-";
            subnetNABin227 = subnetNABin227 ?? "-";
            subnetNABin228 = subnetNABin228 ?? "-";
            subnetNABin229 = subnetNABin229 ?? "-";
            subnetNABin230 = subnetNABin230 ?? "-";
            subnetNABin231 = subnetNABin231 ?? "-";
            subnetNABin232 = subnetNABin232 ?? "-";
            subnetNADec21 = subnetNADec21 ?? "-";
            subnetNADec22 = subnetNADec22 ?? "-";
            subnetNADec23 = subnetNADec23 ?? "-";
            subnetNADec24 = subnetNADec24 ?? "-";
            subnetBRABin21 = subnetBRABin21 ?? "-";
            subnetBRABin22 = subnetBRABin22 ?? "-";
            subnetBRABin23 = subnetBRABin23 ?? "-";
            subnetBRABin24 = subnetBRABin24 ?? "-";
            subnetBRABin25 = subnetBRABin25 ?? "-";
            subnetBRABin26 = subnetBRABin26 ?? "-";
            subnetBRABin27 = subnetBRABin27 ?? "-";
            subnetBRABin28 = subnetBRABin28 ?? "-";
            subnetBRABin29 = subnetBRABin29 ?? "-";
            subnetBRABin210 = subnetBRABin210 ?? "-";
            subnetBRABin211 = subnetBRABin211 ?? "-";
            subnetBRABin212 = subnetBRABin212 ?? "-";
            subnetBRABin213 = subnetBRABin213 ?? "-";
            subnetBRABin214 = subnetBRABin214 ?? "-";
            subnetBRABin215 = subnetBRABin215 ?? "-";
            subnetBRABin216 = subnetBRABin216 ?? "-";
            subnetBRABin217 = subnetBRABin217 ?? "-";
            subnetBRABin218 = subnetBRABin218 ?? "-";
            subnetBRABin219 = subnetBRABin219 ?? "-";
            subnetBRABin220 = subnetBRABin220 ?? "-";
            subnetBRABin221 = subnetBRABin221 ?? "-";
            subnetBRABin222 = subnetBRABin222 ?? "-";
            subnetBRABin223 = subnetBRABin223 ?? "-";
            subnetBRABin224 = subnetBRABin224 ?? "-";
            subnetBRABin225 = subnetBRABin225 ?? "-";
            subnetBRABin226 = subnetBRABin226 ?? "-";
            subnetBRABin227 = subnetBRABin227 ?? "-";
            subnetBRABin228 = subnetBRABin228 ?? "-";
            subnetBRABin229 = subnetBRABin229 ?? "-";
            subnetBRABin230 = subnetBRABin230 ?? "-";
            subnetBRABin231 = subnetBRABin231 ?? "-";
            subnetBRABin232 = subnetBRABin232 ?? "-";
            subnetBRADec21 = subnetBRADec21 ?? "-";
            subnetBRADec22 = subnetBRADec22 ?? "-";
            subnetBRADec23 = subnetBRADec23 ?? "-";
            subnetBRADec24 = subnetBRADec24 ?? "-";
            subnetRangeFrom21 = subnetRangeFrom21 ?? "-";
            subnetRangeFrom22 = subnetRangeFrom22 ?? "-";
            subnetRangeFrom23 = subnetRangeFrom23 ?? "-";
            subnetRangeFrom24 = subnetRangeFrom24 ?? "-";
            subnetRangeTo21 = subnetRangeTo21 ?? "-";
            subnetRangeTo22 = subnetRangeTo22 ?? "-";
            subnetRangeTo23 = subnetRangeTo23 ?? "-";
            subnetRangeTo24 = subnetRangeTo24 ?? "-";
            subnetNABin31 = subnetNABin31 ?? "-";
            subnetNABin32 = subnetNABin32 ?? "-";
            subnetNABin33 = subnetNABin33 ?? "-";
            subnetNABin34 = subnetNABin34 ?? "-";
            subnetNABin35 = subnetNABin35 ?? "-";
            subnetNABin36 = subnetNABin36 ?? "-";
            subnetNABin37 = subnetNABin37 ?? "-";
            subnetNABin38 = subnetNABin38 ?? "-";
            subnetNABin39 = subnetNABin39 ?? "-";
            subnetNABin310 = subnetNABin310 ?? "-";
            subnetNABin311 = subnetNABin311 ?? "-";
            subnetNABin312 = subnetNABin312 ?? "-";
            subnetNABin313 = subnetNABin313 ?? "-";
            subnetNABin314 = subnetNABin314 ?? "-";
            subnetNABin315 = subnetNABin315 ?? "-";
            subnetNABin316 = subnetNABin316 ?? "-";
            subnetNABin317 = subnetNABin317 ?? "-";
            subnetNABin318 = subnetNABin318 ?? "-";
            subnetNABin319 = subnetNABin319 ?? "-";
            subnetNABin320 = subnetNABin320 ?? "-";
            subnetNABin321 = subnetNABin321 ?? "-";
            subnetNABin322 = subnetNABin322 ?? "-";
            subnetNABin323 = subnetNABin323 ?? "-";
            subnetNABin324 = subnetNABin324 ?? "-";
            subnetNABin325 = subnetNABin325 ?? "-";
            subnetNABin326 = subnetNABin326 ?? "-";
            subnetNABin327 = subnetNABin327 ?? "-";
            subnetNABin328 = subnetNABin328 ?? "-";
            subnetNABin329 = subnetNABin329 ?? "-";
            subnetNABin330 = subnetNABin330 ?? "-";
            subnetNABin331 = subnetNABin331 ?? "-";
            subnetNABin332 = subnetNABin332 ?? "-";
            subnetNADec31 = subnetNADec31 ?? "-";
            subnetNADec32 = subnetNADec32 ?? "-";
            subnetNADec33 = subnetNADec33 ?? "-";
            subnetNADec34 = subnetNADec34 ?? "-";
            subnetBRABin31 = subnetBRABin31 ?? "-";
            subnetBRABin32 = subnetBRABin32 ?? "-";
            subnetBRABin33 = subnetBRABin33 ?? "-";
            subnetBRABin34 = subnetBRABin34 ?? "-";
            subnetBRABin35 = subnetBRABin35 ?? "-";
            subnetBRABin36 = subnetBRABin36 ?? "-";
            subnetBRABin37 = subnetBRABin37 ?? "-";
            subnetBRABin38 = subnetBRABin38 ?? "-";
            subnetBRABin39 = subnetBRABin39 ?? "-";
            subnetBRABin310 = subnetBRABin310 ?? "-";
            subnetBRABin311 = subnetBRABin311 ?? "-";
            subnetBRABin312 = subnetBRABin312 ?? "-";
            subnetBRABin313 = subnetBRABin313 ?? "-";
            subnetBRABin314 = subnetBRABin314 ?? "-";
            subnetBRABin315 = subnetBRABin315 ?? "-";
            subnetBRABin316 = subnetBRABin316 ?? "-";
            subnetBRABin317 = subnetBRABin317 ?? "-";
            subnetBRABin318 = subnetBRABin318 ?? "-";
            subnetBRABin319 = subnetBRABin319 ?? "-";
            subnetBRABin320 = subnetBRABin320 ?? "-";
            subnetBRABin321 = subnetBRABin321 ?? "-";
            subnetBRABin322 = subnetBRABin322 ?? "-";
            subnetBRABin323 = subnetBRABin323 ?? "-";
            subnetBRABin324 = subnetBRABin324 ?? "-";
            subnetBRABin325 = subnetBRABin325 ?? "-";
            subnetBRABin326 = subnetBRABin326 ?? "-";
            subnetBRABin327 = subnetBRABin327 ?? "-";
            subnetBRABin328 = subnetBRABin328 ?? "-";
            subnetBRABin329 = subnetBRABin329 ?? "-";
            subnetBRABin330 = subnetBRABin330 ?? "-";
            subnetBRABin331 = subnetBRABin331 ?? "-";
            subnetBRABin332 = subnetBRABin332 ?? "-";
            subnetBRADec31 = subnetBRADec31 ?? "-";
            subnetBRADec32 = subnetBRADec32 ?? "-";
            subnetBRADec33 = subnetBRADec33 ?? "-";
            subnetBRADec34 = subnetBRADec34 ?? "-";
            subnetRangeFrom31 = subnetRangeFrom31 ?? "-";
            subnetRangeFrom32 = subnetRangeFrom32 ?? "-";
            subnetRangeFrom33 = subnetRangeFrom33 ?? "-";
            subnetRangeFrom34 = subnetRangeFrom34 ?? "-";
            subnetRangeTo31 = subnetRangeTo31 ?? "-";
            subnetRangeTo32 = subnetRangeTo32 ?? "-";
            subnetRangeTo33 = subnetRangeTo33 ?? "-";
            subnetRangeTo34 = subnetRangeTo34 ?? "-";

            string inputIPBin = ipBin1 + ipBin2 + ipBin3 + ipBin4 + ipBin5 + ipBin6 + ipBin7 + ipBin8 +
                ipBin9 + ipBin10 + ipBin11 + ipBin12 + ipBin13 + ipBin14 + ipBin15 + ipBin16 +
                ipBin17 + ipBin18 + ipBin19 + ipBin20 + ipBin21 + ipBin22 + ipBin23 + ipBin24 +
                ipBin25 + ipBin26 + ipBin27 + ipBin28 + ipBin29 + ipBin30 + ipBin31 + ipBin32; 

            string inputSMBin = smBin1 + smBin2 + smBin3 + smBin4 + smBin5 + smBin6 + smBin7 + smBin8 +
                smBin9 + smBin10 + smBin11 + smBin12 + smBin13 + smBin14 + smBin15 + smBin16 +
                smBin17 + smBin18 + smBin19 + smBin20 + smBin21 + smBin22 + smBin23 + smBin24 +
                smBin25 + smBin26 + smBin27 + smBin28 + smBin29 + smBin30 + smBin31 + smBin32;

            string inputSMDec = smDec1 + "." + smDec2 + "." + smDec3 + "." + smDec4;

            string inputNABin = naBin1 + naBin2 + naBin3 + naBin4 + naBin5 + naBin6 + naBin7 + naBin8 +
                naBin9 + naBin10 + naBin11 + naBin12 + naBin13 + naBin14 + naBin15 + naBin16 +
                naBin17 + naBin18 + naBin19 + naBin20 + naBin21 + naBin22 + naBin23 + naBin24 +
                naBin25 + naBin26 + naBin27 + naBin28 + naBin29 + naBin30 + naBin31 + naBin32;

            string inputNADec = naDec1 + "." + naDec2 + "." + naDec3 + "." + naDec4;

            string inputBRABin = braBin1 + braBin2 + braBin3 + braBin4 + braBin5 + braBin6 + braBin7 + braBin8 +
               braBin9 + braBin10 + braBin11 + braBin12 + braBin13 + braBin14 + braBin15 + braBin16 +
               braBin17 + braBin18 + braBin19 + braBin20 + braBin21 + braBin22 + braBin23 + braBin24 +
               braBin25 + braBin26 + braBin27 + braBin28 + braBin29 + braBin30 + braBin31 + braBin32;

            string inputBRADec = braDec1 + "." + braDec2 + "." + braDec3 + "." + braDec4;

            string inputRange = rangeFrom1 + "." + rangeFrom2 + "." + rangeFrom3 + "." + rangeFrom4 + "." +
                rangeTo1 + "." + rangeTo2 + "." + rangeTo3 + "." + rangeTo4;

            string inputSubnetSMBin = subnetSMBin1 + subnetSMBin2 + subnetSMBin3 + subnetSMBin4 + subnetSMBin5 + subnetSMBin6 + subnetSMBin7 + subnetSMBin8 +
               subnetSMBin9 + subnetSMBin10 + subnetSMBin11 + subnetSMBin12 + subnetSMBin13 + subnetSMBin14 + subnetSMBin15 + subnetSMBin16 +
               subnetSMBin17 + subnetSMBin18 + subnetSMBin19 + subnetSMBin20 + subnetSMBin21 + subnetSMBin22 + subnetSMBin23 + subnetSMBin24 +
               subnetSMBin25 + subnetSMBin26 + subnetSMBin27 + subnetSMBin28 + subnetSMBin29 + subnetSMBin30 + subnetSMBin31 + subnetSMBin32;

            string inputSubnetSMDec = subnetSMDec1 + "." + subnetSMDec2 + "." + subnetSMDec3 + "." + subnetSMDec4;

            string inputSubnetNABin1 = subnetNABin11 + subnetNABin12 + subnetNABin13 + subnetNABin14 + subnetNABin15 + subnetNABin16 + subnetNABin17 + subnetNABin18 +
                subnetNABin19 + subnetNABin110 + subnetNABin111 + subnetNABin112 + subnetNABin113 + subnetNABin114 + subnetNABin115 + subnetNABin116 +
                subnetNABin117 + subnetNABin118 + subnetNABin119 + subnetNABin120 + subnetNABin121 + subnetNABin122 + subnetNABin123 + subnetNABin124 +
                subnetNABin125 + subnetNABin126 + subnetNABin127 + subnetNABin128 + subnetNABin129 + subnetNABin130 + subnetNABin131 + subnetNABin132;

            string inputSubnetNADec1 = subnetNADec11 + "." + subnetNADec12 + "." + subnetNADec13 + "." + subnetNADec14;

            string inputSubnetBRABin1 = subnetBRABin11 + subnetBRABin12 + subnetBRABin13 + subnetBRABin14 + subnetBRABin15 + subnetBRABin16 + subnetBRABin17 + subnetBRABin18 +
                subnetBRABin19 + subnetBRABin110 + subnetBRABin111 + subnetBRABin112 + subnetBRABin113 + subnetBRABin114 + subnetBRABin115 + subnetBRABin116 +
                subnetBRABin117 + subnetBRABin118 + subnetBRABin119 + subnetBRABin120 + subnetBRABin121 + subnetBRABin122 + subnetBRABin123 + subnetBRABin124 +
                subnetBRABin125 + subnetBRABin126 + subnetBRABin127 + subnetBRABin128 + subnetBRABin129 + subnetBRABin130 + subnetBRABin131 + subnetBRABin132;

            string inputSubnetBRADec1 = subnetBRADec11 + "." + subnetBRADec12 + "." + subnetBRADec13 + "." + subnetBRADec14;

            string inputSubnetRange1 = subnetRangeFrom11 + "." + subnetRangeFrom12 + "." + subnetRangeFrom13 + "." + subnetRangeFrom14 + "." +
                subnetRangeTo11 + "." + subnetRangeTo12 + "." + subnetRangeTo13 + "." + subnetRangeTo14;

            string inputSubnetNABin2 = subnetNABin21 + subnetNABin22 + subnetNABin23 + subnetNABin24 + subnetNABin25 + subnetNABin26 + subnetNABin27 + subnetNABin28 +
                subnetNABin29 + subnetNABin210 + subnetNABin211 + subnetNABin212 + subnetNABin213 + subnetNABin214 + subnetNABin215 + subnetNABin216 +
                subnetNABin217 + subnetNABin218 + subnetNABin219 + subnetNABin220 + subnetNABin221 + subnetNABin222 + subnetNABin223 + subnetNABin224 +
                subnetNABin225 + subnetNABin226 + subnetNABin227 + subnetNABin228 + subnetNABin229 + subnetNABin230 + subnetNABin231 + subnetNABin232;

            string inputSubnetNADec2 = subnetNADec21 + "." + subnetNADec22 + "." + subnetNADec23 + "." + subnetNADec24;

            string inputSubnetBRABin2 = subnetBRABin21 + subnetBRABin22 + subnetBRABin23 + subnetBRABin24 + subnetBRABin25 + subnetBRABin26 + subnetBRABin27 + subnetBRABin28 +
                subnetBRABin29 + subnetBRABin210 + subnetBRABin211 + subnetBRABin212 + subnetBRABin213 + subnetBRABin214 + subnetBRABin215 + subnetBRABin216 +
                subnetBRABin217 + subnetBRABin218 + subnetBRABin219 + subnetBRABin220 + subnetBRABin221 + subnetBRABin222 + subnetBRABin223 + subnetBRABin224 +
                subnetBRABin225 + subnetBRABin226 + subnetBRABin227 + subnetBRABin228 + subnetBRABin229 + subnetBRABin230 + subnetBRABin231 + subnetBRABin232;

            string inputSubnetBRADec2 = subnetBRADec21 + "." + subnetBRADec22 + "." + subnetBRADec23 + "." + subnetBRADec24;

            string inputSubnetRange2 = subnetRangeFrom21 + "." + subnetRangeFrom22 + "." + subnetRangeFrom23 + "." + subnetRangeFrom24 + "." +
                subnetRangeTo21 + "." + subnetRangeTo22 + "." + subnetRangeTo23 + "." + subnetRangeTo24;

            string inputSubnetNABin3 = subnetNABin31 + subnetNABin32 + subnetNABin33 + subnetNABin34 + subnetNABin35 + subnetNABin36 + subnetNABin37 + subnetNABin38 +
                subnetNABin39 + subnetNABin310 + subnetNABin311 + subnetNABin312 + subnetNABin313 + subnetNABin314 + subnetNABin315 + subnetNABin316 +
                subnetNABin317 + subnetNABin318 + subnetNABin319 + subnetNABin320 + subnetNABin321 + subnetNABin322 + subnetNABin323 + subnetNABin324 +
                subnetNABin325 + subnetNABin326 + subnetNABin327 + subnetNABin328 + subnetNABin329 + subnetNABin330 + subnetNABin331 + subnetNABin332; 

            string inputSubnetNADec3 = subnetNADec31 + "." + subnetNADec32 + "." + subnetNADec33 + "." + subnetNADec34;

            string inputSubnetBRABin3 = subnetBRABin31 + subnetBRABin32 + subnetBRABin33 + subnetBRABin34 + subnetBRABin35 + subnetBRABin36 + subnetBRABin37 + subnetBRABin38 +
                subnetBRABin39 + subnetBRABin310 + subnetBRABin311 + subnetBRABin312 + subnetBRABin313 + subnetBRABin314 + subnetBRABin315 + subnetBRABin316 +
                subnetBRABin317 + subnetBRABin318 + subnetBRABin319 + subnetBRABin320 + subnetBRABin321 + subnetBRABin322 + subnetBRABin323 + subnetBRABin324 +
                subnetBRABin325 + subnetBRABin326 + subnetBRABin327 + subnetBRABin328 + subnetBRABin329 + subnetBRABin330 + subnetBRABin331 + subnetBRABin332;

            string inputSubnetBRADec3 = subnetBRADec31 + "." + subnetBRADec32 + "." + subnetBRADec33 + "." + subnetBRADec34;

            string inputSubnetRange3 = subnetRangeFrom31 + "." + subnetRangeFrom32 + "."  + subnetRangeFrom33 + "." + subnetRangeFrom34 + "." +
                subnetRangeTo31 + "." + subnetRangeTo32 + "." + subnetRangeTo33 + "." + subnetRangeTo34;

            ipInfos = ipService.UpdateTestDatabase(ipInfos,  name,  number,  schoolClass,  inputIPBin, networkClass,  inputSMBin,
             inputSMDec,  inputNABin,  inputNADec,  inputBRABin,  inputBRADec,  inputRange,  inputSubnetSMBin,
             inputSubnetSMDec,  inputSubnetNABin1,  inputSubnetNADec1,  inputSubnetBRABin1,  inputSubnetBRADec1,  inputSubnetRange1
             ,  inputSubnetNABin2,  inputSubnetNADec2,  inputSubnetBRABin2,  inputSubnetBRADec2,  inputSubnetRange2,
             inputSubnetNABin3,  inputSubnetNADec3,  inputSubnetBRABin3,  inputSubnetBRADec3,  inputSubnetRange3);

            return RedirectToAction("TurnedIn", new { id = ipInfos.ID });
        }

        [Route("{id}/TurnedIn")]
        public IActionResult TurnedIn(int id)
        {
            return View();
        }

        [HttpPost]
        [Route("{id}/TurnedIn")]
        public IActionResult TurnedIn(int id, int a)
        {
            return RedirectToAction("Results", new { id });
        }

        [Route("{id}/Results")]
        public IActionResult Results(int id)
        {
            IPInfos ipInfos = ipService.GetTestByID(id);
            return View(ipInfos);
        }
    }
}
