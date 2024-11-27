using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum Weather
    {
        Sunny,
        Rainy,
        Cloudy,
        Stormy
    }
    public class HavaDurumuTahmini
    {
        public string GetAdvice(Weather weather)
        {
            switch (weather)
            {
                case Weather.Sunny:
                    return "Güzel bir gün! Dışarıda vakit geçirebilirsiniz.";
                case Weather.Rainy:
                    return "Yağmur yağabilir, şemsiye almayı unutmayın.";
                case Weather.Cloudy:
                    return "Hava kapalı, hazırlıklı olun.";
                case Weather.Stormy:
                    return "Fırtına var, evde kalmak en iyisi.";
                default:
                    return "Bilinmeyen hava durumu!";
            }
        }
    }
}
