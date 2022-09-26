using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.Zones
{
    public static class Zones
    {
        private static readonly IEnumerable<string> zones = new List<string>()
        {
            "Taiga",
            "Arctic",
            "Savannah",
            "Desert",
            "Jungle"
        };

        /// <summary>
        /// Checks whether a zone is known
        /// </summary>
        /// <param name="input">The zone text</param>
        /// <returns>True if it is a valid zone, otherwise false.</returns>
        public static bool IsValid(string input)
        {
            char[] stringAsArray = input.ToCharArray();
            //Make sure first character is capital
            if(input.ToLower() == input)
            {
                char firstLetter = input[0];
                stringAsArray[0] = char.ToUpper(firstLetter);
            }

            StringBuilder sb = new StringBuilder();
            foreach(char c in stringAsArray)
            {
                sb.Append(c);
            }

            return zones.Contains(sb.ToString());
        }

        public static IReadOnlyList<string> AllowedZones => zones.ToList();
    }
}
