using System;
using System.Collections.Generic;
using System.Linq;
namespace partI
{
    public static class AddSpace
    {
        public static void Space(ref string str)
        {
            List<char> _str = new List<char>();
            int k = 0;
            for (int i = str.Count() - 1; i >= 0; i--)
            {

                k++;
                _str.Add(Convert.ToChar(str[i]));
                if (k == 3)
                {
                    _str.Add(' ');

                    k = 0;
                }
            }
            str = "";
            _str.Reverse();
            for (int i = 0; i < _str.Count; i++)
                str = str + _str[i].ToString();
        }
    }
}
