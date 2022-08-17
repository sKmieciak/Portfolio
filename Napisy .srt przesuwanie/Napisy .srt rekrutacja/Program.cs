using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Napisy.srt_rekrutacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Krzyzacy.srt");
            StreamWriter asw = new StreamWriter("KrzyzacyBezRownejSekundy.srt");
            int Anothercounter = 1;
            int counter = 1;
            int counterMiliSec = 0;
            int counterSec = 0;
            int counterMinutes = 0;
            int hours=0;
            int counterin = 0;
            int min=0;
            int sec = 0;
            int milisec = 1;
            int hours1 = 0;
            int min1 = 0;
            int sec1 = 0;
            int milisec1 = 1;
            int przesuniecieMiliSec = 880;
            int przesuniecieSec = 5;
           // Console.WriteLine(1);
            sw.WriteLine(1);
            asw.WriteLine(1);
            foreach (string line in System.IO.File.ReadLines(@"napisy do filmu.srt"))
            {
                if (line.Length == 0)
                {
                    if(milisec == 0 || milisec1==0)
                    {
                        //Console.WriteLine(line);
                        //Console.WriteLine(Anothercounter);
                        Anothercounter++;
                        if (Anothercounter != 74)
                        {
                            asw.WriteLine(line);
                            asw.WriteLine(Anothercounter.ToString());
                        }
                    }
                    else
                    {
                       // Console.WriteLine(line);
                       // Console.WriteLine(counter);
                        counter++;
                        sw.WriteLine(line);
                        sw.WriteLine(counter.ToString());
                    }
                }
                if (line.Length != 0 && line.Length>4)
                {
                    char[] str = new char[line.Length];
                    str = line.ToCharArray();
                    if (str[0] != '0'&&(milisec !=0 && milisec1!= 0) )
                    {
                       // System.Console.WriteLine(line);
                        sw.WriteLine(line);
                    }
                    else if (str[0] != '0' && (milisec == 0 || milisec1 == 0))
                    {
                        //System.Console.WriteLine(line);
                        asw.WriteLine(line);
                    }
                        if (str[0] == '0')
                    {
                        string newStr = line.Remove(12, 4);
                        string[] subs = newStr.Split(' ', ',', ':');

                        foreach (var sub in subs)
                        {
                            counterin++;
                            counterin = counterin % 8;

                            if (counterin == 1)
                            {
                                hours = int.Parse(sub);
                                hours += counterMinutes;
                                counterMinutes = 0;

                            }
                            if (counterin == 2)
                            {
                                min = int.Parse(sub);
                                if (min > 59)
                                {
                                    min = (min + counterSec) % 60;
                                    counterMinutes++;
                                    counterSec = 0;
                                }
                            }
                            if (counterin == 3)
                            {
                                sec = int.Parse(sub);
                                sec += przesuniecieSec+1;
                                if (sec > 59)
                                {
                                    sec = (sec + counterMiliSec) % 60;
                                    counterSec++;
                                    counterMiliSec = 0;
                                }
                            }
                            if (counterin == 4)
                            {
                                milisec = int.Parse(sub);
                                //tu przesuwamy film
                                milisec += przesuniecieMiliSec;
                                if (milisec > 999)
                                {
                                    milisec = milisec % 1000;
                                    counterMiliSec++;
                                }
                            }
                            if (counterin == 5)
                            {
                                hours1 = int.Parse(sub);
                                hours1 += counterMinutes;
                                counterMinutes = 0;

                            }
                            if (counterin == 6)
                            {
                                min1 = int.Parse(sub);
                                if (min1 > 59)
                                {
                                    min1 = (min1 + counterSec) % 60;
                                    counterMinutes++;
                                    counterSec = 0;
                                }
                            }
                            if (counterin == 7)
                            {
                                sec1 = int.Parse(sub);
                                sec1 += przesuniecieSec+1;
                                if (sec1 > 59)
                                {
                                    sec1 = (sec1 + counterMiliSec) % 60;
                                    counterSec++;
                                    counterMiliSec = 0;
                                }
                            }
                            if (counterin == 0)
                            {
                                milisec1 = int.Parse(sub);
                                milisec1 += przesuniecieMiliSec;
                                if (milisec1 > 999)
                                {
                                    milisec1 = milisec1 % 1000;
                                    counterMiliSec++;
                                }
                            }
                        }
                        if (milisec == 0 || milisec1 == 0)
                        {
                            //Console.WriteLine(hours.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00") + "," + milisec.ToString("000") + " --> " + hours1.ToString("00") + ":" + min1.ToString("00") + ":" + sec1.ToString("00") + "," + milisec1.ToString("000"));
                            asw.WriteLine(hours.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00") + "," + milisec.ToString("000") + " --> " + hours1.ToString("00") + ":" + min1.ToString("00") + ":" + sec1.ToString("00") + "," + milisec1.ToString("000"));

                        }
                        else
                        {
                            //Console.WriteLine(hours.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00") + "," + milisec.ToString("000") + " --> " + hours1.ToString("00") + ":" + min1.ToString("00") + ":" + sec1.ToString("00") + "," + milisec1.ToString("000"));
                            sw.WriteLine(hours.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00") + "," + milisec.ToString("000") + " --> " + hours1.ToString("00") + ":" + min1.ToString("00") + ":" + sec1.ToString("00") + "," + milisec1.ToString("000"));

                        }
                    }
                } 
            }
            sw.Close();
            asw.Close();
        }
    }
}
