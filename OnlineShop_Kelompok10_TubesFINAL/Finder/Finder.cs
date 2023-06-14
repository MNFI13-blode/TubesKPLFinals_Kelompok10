using System;

namespace Finders
{
    public class Finder
    {
        public static int Searching(string searching)
        {
            bool check = Check(searching);
            if (check)
            {
                if (searching == "Pena" || searching == "pena")
                {
                    return 1;
                }
                else if (searching == "Pensil" || searching == "pensil")
                {
                    return 2;
                }
                else if (searching == "Pensil Kenko" || searching == "pensil kenko")
                {
                    return 3;
                }
                else if (searching == "Pensil Joyko" || searching == "pensil joyko")
                {
                    return 4;
                }
                else if (searching == "Pensil Stabilo" || searching == "pensil stabilo")
                {
                    return 5;
                }
                else if (searching == "Pensil Faber Castel" || searching == "pensil faber castel")
                {
                    return 6;
                }
                else if (searching == "Pena Dell" || searching == "pena dell")
                {
                    return 7;
                }
                else if (searching == "Pena Joyko" || searching == "pena joyko")
                {
                    return 8;
                }
                else if (searching == "Pena Snowmann" || searching == "pena snowmann")
                {
                    return 9;
                }
                else if (searching == "Water Colour" || searching == "water colour" || searching == "cat warna")
                {
                    return 10;
                }
                else if (searching == "Buku Tulis" || searching == "buku tulis")
                {
                    return 11;
                }
                else if (searching == "Buku Gambar" || searching == "buku gambar")
                {
                    return 12;
                }
                else if (searching == "Correction Pen" || searching == "correction pen")
                {
                    return 13;
                }
                else if (searching == "Penggaris" || searching == "penggaris")
                {
                    return 14;
                }

                else
                {
                    return -1;
                }

            }
            return 0;
        }
        public static bool Check(string searching)
        {
            if (string.IsNullOrEmpty(searching))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(searching))
            {
                return false;
            }
            return true;
        }
    }
}
