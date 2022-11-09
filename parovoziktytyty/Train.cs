using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace parovoziktytyty
{
    public class Train
    {
        /*** Инициализация данных ***/
        private const sbyte _length = 54; // Количество мест в вагоне 
        private sbyte[] _reserved_seat_up = new sbyte[18] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 }; // Верхние места в купе
        private sbyte[] _reserved_seat_down = new sbyte[18] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 }; // Нижние места в купе
        private sbyte[] _sidewall_up = new sbyte[9] { 38, 40, 42, 44, 46, 48, 50, 52, 54 }; // Верхние места сбоку
        private sbyte[] _sidewall_down = new sbyte[9] { 37, 39, 41, 43, 45, 47, 49, 51, 53 }; // Нижние места сбоку


        private bool _checkSide(sbyte number)
        {
            if (number % 2 != 0) return false;
            return true;
        }

        private bool _checkSidewall(sbyte number)
        {
            if (number < 38) return false;
            return true;
        }

        private bool _checkInArray(sbyte number, sbyte arrayNumber)
        {
            if (number == arrayNumber) return true;
            return false;
        }

        private sbyte _search_range(sbyte number)
        {
            sbyte place = 0;
            if (_checkSidewall(number))
            {
                if (_checkSide(number))
                {
                    sbyte temp = 0;
                    for (sbyte i = 8; i > 0; i--)
                    {
                        if (_checkInArray(number, _sidewall_up[temp])) return (sbyte)(i + 1);
                        temp++;
                    }
                }
                else
                {
                    sbyte temp = 0;
                    for (sbyte i = 8; i > 0; i--)
                    {
                        if (_checkInArray(number, _sidewall_down[temp])) return (sbyte)(i + 1);
                        temp++;
                    }
                }
            }
            else
            {
                if (_checkSide(number))
                {
                    for (sbyte i = 0; i < 18; i++)
                    {
                        if (_checkInArray(number, _reserved_seat_up[i])) return (sbyte)((i /2)+1);
                    }
                }
                else
                {
                    for (sbyte i = 0; i < 18; i++)
                    {
                        if (_checkInArray(number, _reserved_seat_down[i])) return (sbyte)((i /2)+1);
                    }
                }
            }
            return 0;
        }
        public string search_site(sbyte number)
        {
            if (number > _length || number < 1) return "Your site is not current, current number site in range 1 < x < 54";
            if (_checkSidewall(number))
            {
                sbyte result = _search_range(number);
                if (_checkSide(number)) return (result).ToString() + "бв";
                else return (result).ToString() + "бн";
            }
            else
            {
                sbyte result = _search_range(number);
                if (_checkSide(number)) return (result).ToString() + "кв";
                else return (result).ToString() + "кн";
            }
        }
    }
}
