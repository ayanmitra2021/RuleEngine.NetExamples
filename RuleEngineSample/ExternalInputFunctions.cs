﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineSaple
{
    public static class ExternalInputFunctions
    {
        public static bool SalaryCodeCheck(string extraCode5Value, string extraCodeAllowedList)
        {
            if (string.IsNullOrEmpty(extraCode5Value)) return false;

            if (string.IsNullOrEmpty(extraCodeAllowedList)) return false;

            string[] extraCodeAllowedListSplit = extraCodeAllowedList.Split(',');

            return extraCodeAllowedListSplit.Contains(extraCode5Value);

        }

        public static bool IIf(bool exp, bool truePart, bool falsePart)
        {
            return exp ? truePart : falsePart;
        }

        public static bool IIf(bool exp, bool truePart)
        {
            return exp ? truePart : false;
        }

        public static bool ExtraIntCheck(int extraInt1Value, string extraInt1AllowedList)
        {
            if (string.IsNullOrEmpty(extraInt1AllowedList)) return false;

            string[] extraInt1AllowedListSplit = extraInt1AllowedList.Split(',');

            bool result = false;
            int value = 0;

            foreach (string x in extraInt1AllowedListSplit)
            {
                if (int.TryParse(x, out value) && value == extraInt1Value)
                {
                    result = true;
                    break;
                }
            };

            return result;

        }

        public static bool ResidenceStateCheck(string stateCode, string allowedStateCodes)
        {
            if (string.IsNullOrEmpty(stateCode)) return false;

            if (string.IsNullOrEmpty(allowedStateCodes)) return false;

            string[] allowedStateCodeList = allowedStateCodes.Split(',');

            return allowedStateCodeList.Contains(stateCode);
        }

        public static decimal EvaluateCredit(decimal frozenSalary, string managerEmployeeNo, string fullOrPartTimeCode)
        {
            if (!string.IsNullOrEmpty(managerEmployeeNo) && managerEmployeeNo != "3C") return 250;

            if (!string.IsNullOrEmpty(fullOrPartTimeCode) && fullOrPartTimeCode == "PT") return 250;

            if (!string.IsNullOrEmpty(managerEmployeeNo) && managerEmployeeNo == "3A") return 250;

            if (!string.IsNullOrEmpty(managerEmployeeNo) && managerEmployeeNo == "3I") return 250;

            const decimal FACTOR = 0.142062M;
            if (!string.IsNullOrEmpty(managerEmployeeNo) && managerEmployeeNo == "3C" && frozenSalary > 0) return frozenSalary * FACTOR;

            if (!string.IsNullOrEmpty(managerEmployeeNo) && managerEmployeeNo == "3C" && frozenSalary == 0) return 0;

            if (frozenSalary < 300000) return (frozenSalary * FACTOR) + 250;

            return 250 + (300000 * FACTOR);
        }

    }
}
