// See https://aka.ms/new-console-template for more information
//alirazanazeri
List<stu> stus = new List<stu>();

StreamReader k = new StreamReader(@"D:\vs\tamrin7\100 stu name and score.txt");

while (!k.EndOfStream)
{
    string line = k.ReadLine();
    stu stu = new stu();

    stu.name = line.Split(',')[0];
    stu.riazi = Convert.ToDouble(line.Split(',')[1]);
    stu.pishrafe1 = Convert.ToDouble(line.Split(',')[2]);
    stu.pishrafte2 = Convert.ToDouble(line.Split(',')[3]);
    stu.algoritm = Convert.ToDouble(line.Split(',')[4]);
    stu.sheygraee = Convert.ToDouble(line.Split(',')[5]);
    stu.tarbiatBadani = Convert.ToDouble(line.Split(',')[6]);
    stu.zabanENG = Convert.ToDouble(line.Split(',')[7]);
    stu.sistemAmel = Convert.ToDouble(line.Split(',')[8]);
    stu.tafsir = Convert.ToDouble(line.Split(',')[9]);
    stu.karagah = Convert.ToDouble(line.Split(',')[10]);

    stus.Add(stu);
}
bool exit = false;

var sortedList = stus.OrderByDescending(s => s.avrg()).ToList();
var sortedList5 = stus.OrderByDescending(s => s.avrg5()).ToList();
var sortedList2 = stus.OrderByDescending(s => s.avrg2()).ToList();
var sortedList3 = stus.OrderByDescending(s => s.avrg3()).ToList();
var sortedList4 = stus.OrderByDescending(s => s.avrg4()).ToList();

do
{
    Console.WriteLine("ye chizi bezn?");
    Console.WriteLine("1_hamash ");
    Console.WriteLine("2_moadel kol");
    Console.WriteLine("3_moadeltakhasosi");
    Console.WriteLine("4_moadel**");
    Console.WriteLine("5_moadel*");
    Console.WriteLine("6_moadel omumi");
    Console.WriteLine("7_adad alav");
    Console.WriteLine("8_khoruj");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x == 1)
    {


        foreach (var stu in stus)
        {
            Console.WriteLine("profile:");
            Console.WriteLine("");
            Console.WriteLine(stu.name);
            Console.WriteLine("moadel kol:");
            Console.WriteLine((Math.Round(stu.avrg(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg(), 2)))));
            Console.WriteLine("");
            Console.WriteLine("moadel dorus takhasosi:");
            Console.WriteLine((Math.Round(stu.avrg5(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg5(), 2)))));
            Console.WriteLine("");
            Console.WriteLine("moadel dorus**:");
            Console.WriteLine((Math.Round(stu.avrg2(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg2(), 2)))));
            Console.WriteLine("");
            Console.WriteLine("moadel dorus*:");
            Console.WriteLine((Math.Round(stu.avrg3(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg3(), 2)))));
            Console.WriteLine("");
            Console.WriteLine("moadel dorus omumi:");
            Console.WriteLine((Math.Round(stu.avrg4(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg4(), 2)))));
            Console.WriteLine("===================================");
        }
    }
    else if (x == 2)
    {
        foreach (var stu in sortedList)
        {

            Console.WriteLine("moadel:");
            Console.WriteLine(stu.name);
            Console.WriteLine("=");
            Console.WriteLine((Math.Round(stu.avrg(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg(), 2)))));
            Console.WriteLine("===================================");

        }

    }
    else if (x == 3)
    {
        foreach (var stu in sortedList5)
        {


            Console.WriteLine("moadel:");
            Console.WriteLine(stu.name);
            Console.WriteLine("=");
            Console.WriteLine((Math.Round(stu.avrg5(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg5(), 2)))));
            Console.WriteLine("==============================");
        }

    }
    else if (x == 4)
    {
        foreach (var stu in sortedList2)
        {
            Console.WriteLine("Moadel:");
            Console.WriteLine(stu.name);
            Console.WriteLine("=");
            Console.WriteLine((Math.Round(stu.avrg2(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg2(), 2)))));
            Console.WriteLine("================================");

        }

    }
    else if (x == 5)
    {
        foreach (var stu in sortedList3)
        {
            Console.WriteLine("moadel:");
            Console.WriteLine(stu.name);
            Console.WriteLine("=");
            Console.WriteLine((Math.Round(stu.avrg3(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg3(), 2)))));
            Console.WriteLine("=======================");

        }

    }
    else if (x == 6)
    {
        foreach (var stu in sortedList4)
        {
            Console.WriteLine("moadel:");
            Console.WriteLine(stu.name);
            Console.WriteLine("=");
            Console.WriteLine((Math.Round(stu.avrg4(), 2)));
            Console.WriteLine((stu.rank((Math.Round(stu.avrg4(), 2)))));
            Console.WriteLine("====================");

        }
    }
    else if (x == 7)
    {
        foreach (var stu in stus)
        {

            stu.aa(Convert.ToInt32(stu.riazi));
            stu.aa(Convert.ToInt32(stu.pishrafe1));
            stu.aa(Convert.ToInt32(stu.pishrafte2));
            stu.aa(Convert.ToInt32(stu.tafsir));
            stu.aa(Convert.ToInt32(stu.tarbiatBadani));
            stu.aa(Convert.ToInt32(stu.algoritm));
            stu.aa(Convert.ToInt32(stu.sheygraee));
            stu.aa(Convert.ToInt32(stu.sistemAmel));
            stu.aa(Convert.ToInt32(stu.zabanENG));
            stu.aa(Convert.ToInt32(stu.karagah));

        }
    }
    else if (x == 8)
    {
        exit = true;
    }
}
while (!exit);


class stu
{

    public string name { get; set; }

    public double riazi { get; set; }

    public double pishrafe1 { get; set; }

    public double pishrafte2 { get; set; }

    public double algoritm { get; set; }

    public double sheygraee { get; set; }

    public double tarbiatBadani { get; set; }

    public double zabanENG { get; set; }

    public double sistemAmel { get; set; }

    public double tafsir { get; set; }

    public double karagah { get; set; }

    public double avrg()
    {
        return ((riazi * 2 + pishrafe1 * 3 + pishrafte2 * 3 + algoritm * 3 + sheygraee * 3 + tarbiatBadani + zabanENG * 2 + sistemAmel * 3 + tafsir + karagah) / 22);

    }

    public double avrg2()
    {
        return ((pishrafe1 * 3 + pishrafte2 * 3 + sheygraee * 3) / 9);
    }
    public double avrg3()
    {
        return ((sistemAmel * 3 + algoritm * 3) / 6);
    }
    public double avrg5()
    {
        return ((pishrafe1 * 3 + pishrafte2 * 3 + sheygraee * 3 + sistemAmel * 3 + algoritm * 3) / 15);

    }
    public double avrg4()
    {
        return ((tafsir + riazi * 2 + karagah + zabanENG * 2 + tarbiatBadani) / 7);

    }
    public static string rank(double f)

    {
        switch (f)

        {


            case double n when (3 >= n && n < 7):

                return "grad_F";
                break;

            case double n when (7 >= n && n < 10):

                return "grad_E";

                break;
            case double n when (10 >= n && n < 13):

                return "grad_D";
                break;

            case double n when (13 >= n && n < 15):

                return "grad_C";
                break;
            case double n when (15 >= n && n < 17):

                return "grad_B";
                break;

            case double n when (17 >= n && n <= 20):

                return "grad_A";
                break;


        }
        return "";
    }
    public void aa(int num)
    {
        int sum = 0;

        for (int i = 1; i < num; i++)
        {

            if (num % i == 0)
            {
                sum++;
            }

        }
        if (sum < 2 && num > 1)
            Console.WriteLine(num);
    }
}
