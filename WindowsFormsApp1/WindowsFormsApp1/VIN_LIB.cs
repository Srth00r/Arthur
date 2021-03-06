﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class VIN_LIB
    {
        public bool CheckVIN(string vin)
        {
            Regex regex = new Regex(@"[A-HJ-NPR-Z\d]{17}");
            if (!regex.IsMatch(vin))
            return false;
            return true;
        }
        public string GetVINCountry(string vin)
        {
            Dictionary<string, string> Country = new Dictionary<string, string>();
            Country.Add("AA-AH", "ЮАР");
            Country.Add("AJ-AN", "Котд’Ивуар ");
            Country.Add("AP-A0", "не используется ");
            Country.Add("BA-BE", "Ангола");
            Country.Add("BF-BK", "Кения ");
            Country.Add("BL-BR", "Танзания ");
            Country.Add("BS-B0", "не используется ");
            Country.Add("CA-CE", "Бенин ");
            Country.Add("CF-CK", "Мадагаскар ");
            Country.Add("CL-CR", "Тунис ");
            Country.Add("CS-C0", " не используется ");
            Country.Add("DA-DE", "Египет ");
            Country.Add("DF-DK", "Марокко ");
            Country.Add("DL-DR", "Замбия ");
            Country.Add("DS-D0", "не используется");
            Country.Add("EA-EE", "Эфиопия ");
            Country.Add("EF-EK", "Мозамбик ");
            Country.Add("EL-E0", "не используется");
            Country.Add("FA-FE", "Гана ");
            Country.Add("FF-FK", "Нигерия ");
            Country.Add("FL-F0", "не используется ");
            Country.Add("GA-G0", "не используется ");
            Country.Add("HA-H0", "не используется ");
            Country.Add("JA-JT", "Япония ");
            Country.Add("KA-KE", "Шри-Ланка ");
            Country.Add("KF-KK", "Израиль ");
            Country.Add("KL-KR", "Южная Корея ");
            Country.Add("KS-K0", "Казахстан ");
            Country.Add("LA-L0", "Китай ");
            Country.Add("MA-ME", "Индия ");
            Country.Add("MF-MK", "Индонезия ");
            Country.Add("ML-MR", "Таиланд ");
            Country.Add("MS-M0", "не используется");
            Country.Add("NF-NK", "Пакистан ");
            Country.Add("NL-NR", "Турция ");
            Country.Add("NT-N0", "не используется");
            Country.Add("PA-PE", "Филиппины ");
            Country.Add("PF-PK", "Сингапур ");
            Country.Add("PL-PR", "Малайзия ");
            Country.Add("PS-P0", "не используется ");
            Country.Add("RA-RE", "ОАЭ ");
            Country.Add("RF-RK", "Тайвань ");
            Country.Add("RL-RR", "Вьетнам ");
            Country.Add("RS-R0", "Саудовская Аравия ");
            Country.Add("SA-SM", "Великобритания ");
            Country.Add("SN-ST", "Германия ");
            Country.Add("SU-SZ", "Польша ");
            Country.Add("S1-S4", "Латвия ");
            Country.Add("TA-TH", "Швейцария ");
            Country.Add("TJ-TP", "Чехия ");
            Country.Add("TR-TV", "Венгрия ");
            Country.Add("TW-T1", "Португалия ");
            Country.Add("T2-T0", "не используется");
            Country.Add("UA-UG", "не используется");
            Country.Add("UH-UM", "Дания ");
            Country.Add("UN-UT", "Ирландия ");
            Country.Add("UU-UZ", "Румыния ");
            Country.Add("U1-U4", "не используется");
            Country.Add("U5-U7", "Словакия ");
            Country.Add("U8-U0", "не используется");
            Country.Add("VA-VE", "Австрия ");
            Country.Add("VF-VR", "Франция ");
            Country.Add("VS-VW", "Испания ");
            Country.Add("VX-V2", "Сербия ");
            Country.Add("V3-V5", "Хорватия ");
            Country.Add("V6-V0", "Эстония ");
            Country.Add("WA-W0", "Германия ");
            Country.Add("XA-XE", "Болгария ");
            Country.Add("XF-XK", "Греция ");
            Country.Add("XL-XR", "Нидерланды ");
            Country.Add("XS-XW", "СССР/СНГ ");
            Country.Add("XX-X2", "Люксембург ");
            Country.Add("X3-X0", "Россия ");
            Country.Add("YA-YE", "Бельгия ");
            Country.Add("YF-YK", "Финляндия ");
            Country.Add("YL-YR", "Мальта ");
            Country.Add("YS-YW", "Швеция ");
            Country.Add("YX-Y2", "Норвегия ");
            Country.Add("Y3-Y5", "Беларусь ");
            Country.Add("Y6-Y0", "Украина ");
            Country.Add("ZA-ZR", "Италия ");
            Country.Add("ZS-ZW", "не используется");
            Country.Add("ZX-Z2", "Словения ");
            Country.Add("Z3-Z5", "Литва ");
            Country.Add("Z6-Z0", "Россия ");
            Country.Add("1A-10", "США ");
            Country.Add("2A-20", "Канада ");
            Country.Add("3A-3W", "Мексика ");
            Country.Add("3X-37", "Коста Рика");
            Country.Add("38-30", "Каймановы острова");
            Country.Add("4A-40", "США ");
            Country.Add("5A-50", "США ");
            Country.Add("6A-6W", "Австралия ");
            Country.Add("6X-60", "не используется");
            Country.Add("7A-7E", "Новая Зеландия ");
            Country.Add("7F-70", "не используется");
            Country.Add("8A-8E", "Аргентина ");
            Country.Add("8F-8K", "Чили ");
            Country.Add("8L-8R", "Эквадор ");
            Country.Add("8S-8W", "Перу ");
            Country.Add("8X-82", "Венесуэла ");
            Country.Add("83-80", "не используется");
            Country.Add("9A-9E", "Бразилия ");
            Country.Add("9F-9K", "Колумбия ");
            Country.Add("9L-9R", "Парагвай ");
            Country.Add("9S-9W", "Уругвай ");
            Country.Add("9X-92", "Тринидад и Тобаго ");
            Country.Add("93-99", "Бразилия ");
            Country.Add("90", "не используется ");
            return null;
        }
        public int GetTransportYear(string vin)
        {
            Dictionary<string, string> Year = new Dictionary<string, string>();
            Year.Add("A","1980");
             Year.Add("B","1981");
             Year.Add("C", "1982");
             Year.Add("D", "1983");
             Year.Add("E", "1984");
             Year.Add("F", "1985");
             Year.Add("G", "1986");
             Year.Add("H", "1987");
             Year.Add("J", "1988");
             Year.Add("K", "1989");
             Year.Add("L", "1990");
             Year.Add("M", "1991");
             Year.Add("N", "1992");
             Year.Add("P", "1993");
             Year.Add("R", "1994");
             Year.Add("S", "1995");
             Year.Add("T", "1996");
             Year.Add("V", "1997");
             Year.Add("W", "1998");
             Year.Add("X", "1999");
             Year.Add("Y", "2000");
             Year.Add("1", "2001");
             Year.Add("2", "2002");
             Year.Add("3", "2003");
            Year.Add("4","2004");
            Year.Add("5", "2005");
            Year.Add("6", "2006");
            Year.Add("7", "2007");
            Year.Add("8", "2008");
            Year.Add("9", "2009");
            Year.Add("A", "2010");
            Year.Add("B", "2011");
            Year.Add("C", "2012");
            Year.Add("D", "2013");
            Year.Add("E", "2014");
            Year.Add("F", "2015");
            Year.Add("G", "2016");
            Year.Add("H", "2017");
            Year.Add("J", "2018");
            Year.Add("K", "2019");
            Year.Add("L", "2020");
            Year.Add("M", "2021");
            Year.Add("N", "2022");
            Year.Add("P", "2023");
            Year.Add("R", "2024");
            Year.Add("S", "2025");
            Year.Add("T", "2026");
            Year.Add("V", "2027");
            Year.Add("W", "2028");
            Year.Add("X", "2029");
            Year.Add("Y", "2030");
            Year.Add("1", "2031");
            Year.Add("2", "2032");
            Year.Add("3", "2033");
            Year.Add("4", "2034");
            Year.Add("5", "2035");
            Year.Add("6", "2036");
            Year.Add("7", "2037");
            Year.Add("8", "2038");
            Year.Add("9", "2039");
            return 0;
        }
    }
}