// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int deger1 = 20;
string strdeger1 = "25";
string degersonuc1 = deger1.ToString() + strdeger1;
Console.WriteLine("int den str ye dönüştürme sonuc "+degersonuc1);

int deger2 = 20;
string strdeger2 = "25";
int degersonuc2 = deger2 + Convert.ToInt32(strdeger2);
Console.WriteLine("str den int e dönüştürme " + degersonuc2);

// false dönecek bir bool tanımlıyoruz.

bool booldeger = deger1 is string;
Console.WriteLine("deger1 değişkeni string değer tutar = " + booldeger);

string businessdate1 = DateTime.Now.ToString("yyyy-MM-dd"); // burada sorun yqaşadım küçük mm yaptığımda minutes getiriyormuş. Anncak düzelttim.
Console.WriteLine("businessdate1 değişkeni = " + businessdate1);
string businessdate2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
Console.WriteLine("businessdate2 değişkeni = " + businessdate2); // sql datetime oldu çok işime yarayacak :D
string businesstime1 = DateTime.Now.ToString("HH:mm:ss");
Console.WriteLine("businesstime1 değişkeni = " + businesstime1);
