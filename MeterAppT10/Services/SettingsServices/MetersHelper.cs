using System;
using System.Collections.Generic;
using MeterAppT10.Models;

namespace MeterAppT10.Services.SettingsServices
{
    public static class MetersHelper
    {
        private static readonly Random _random = new Random();

        public static IEnumerable<MbusMeter> GetMbusMeters()
        {
            var meters = new List<MbusMeter>();

            for (int i = 0; i < 10; i++)
            {
                meters.Add(new MbusMeter
                {
                    SerialNumber = Guid.NewGuid().ToString(),
                    Prototype = GetRandomPrototype(),
                    Voltage1 = GetRandomVoltage(),
                    Voltage2 = GetRandomVoltage(),
                    Voltage3 = GetRandomVoltage()
                });
            }

            return meters;
        }

        public static IEnumerable<ZigbeeMeter> GetZigbeeMeters()
        {
            var meters = new List<ZigbeeMeter>();

            for (int i = 0; i < 10; i++)
            {
                meters.Add(new ZigbeeMeter
                {
                    SerialNumber = Guid.NewGuid().ToString(),
                    Prototype = GetRandomPrototype(),
                    Power1 = GetRandomPower(),
                    Power2 = GetRandomPower(),
                    Power3 = GetRandomPower()
                });
            }

            return meters;
        }

        private static int GetRandomPrototype()
        {
            return _random.Next(0, 3);
        }

        private static int GetRandomPower()
        {
            return _random.Next(0, 100);
        }

        private static int GetRandomVoltage()
        {
            return _random.Next(180, 260);
        }
    }
}