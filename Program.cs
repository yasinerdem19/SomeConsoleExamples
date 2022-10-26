// See https://aka.ms/new-console-template for more information


Console.WriteLine("Array lenght: ");
int boyut =Convert.ToInt32( Console.ReadLine());
int[] sayilar = new int[boyut];


var r = new Random();

for (int i = 0; i < sayilar.Length; i++)
    sayilar[i] = r.Next(5,19);

foreach (var item in sayilar)
    Console.WriteLine($"{item,5}  {item*item,9}");


int t = Karsilastir(sayilar[0], sayilar[1]);
Console.WriteLine("Bigger Number in First Two is:  " + t);


int tInt = SeriToplami(sayilar);
Console.WriteLine("Sum Of random array is :  {0,6:0,000.0#}", tInt);


static int Karsilastir(int A ,int B)
{
    return A > B ? A : B ;
}

static int SeriToplami(params int[] seri)
{
    int toplam = 0;
    foreach (int item in seri)
    {
        toplam += item;
    }
    return toplam;
}
//Lambda Expression
var sehirler = new List<string>() { "Adana","Adıyaman","Afyon"};
sehirler.ForEach (degiskenAdi => Console.WriteLine(degiskenAdi));


