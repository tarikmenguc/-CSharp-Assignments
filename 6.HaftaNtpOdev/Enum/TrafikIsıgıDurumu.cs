using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    public class TrafikIsıgıDurumu
    {
        public string GetAction(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    return "Dur!";
                case TrafficLight.Yellow:
                    return "Hazırlanın, kırmızı ışık geliyor!";
                case TrafficLight.Green:
                    return "Geçebilirsiniz!";
                default:
                    return "Bilinmeyen ışık durumu!";
            }
        }
    }
}
