using System;
using System.Collections.Generic;
using MeterAppT10.Models;

namespace MeterAppT10.Services.SettingsServices
{
    public static class MetersHelper
    {
        public static IEnumerable<ZigbeeMeter> GetZigbeeMeters()
        {
            List<ZigbeeMeter> zigbeeMeters = new List<ZigbeeMeter>();

            for (int i = 0; i < 10; i++)
            {
                zigbeeMeters.Add(new ZigbeeMeter
                {
                    SerialNumber = Guid.NewGuid().ToString(),
                    Prototype = GetRandomPrototype(),
                    Power1 = GetRandomPower(),
                    Power2 = GetRandomPower(),
                    Power3 = GetRandomPower()
                });
            }

            return zigbeeMeters;
        }

        private static int GetRandomPrototype()
        {
            var random = new Random();
            return random.Next(0, 2);
        }

        private static int GetRandomPower()
        {
            var random = new Random();
            return random.Next(0, 100);
        }
    }
}