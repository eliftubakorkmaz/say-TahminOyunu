
Console.WriteLine("Sayı Tahmini Oyununa Hoşgeldiniz!");
Console.WriteLine("Oyunun kurallarına bir bakalım!");
Console.WriteLine("1 - 20 arasında bir sayı tahmin etmeniz gerekiyor. Unutma! 1 veya 20 de olabilir!!");
Console.WriteLine("5 kere tahminde bulunma hakkın var! Sonra yanarsın! Bakalım hakkın bitmeden kaç denemede bileceksin.");
Console.WriteLine("Şimdi lütfen ismini gir:");

string oyuncu = Console.ReadLine();
Console.WriteLine($"Hadi bakalım görelim seni {oyuncu}");

Random rastgele = new();
int sayi = rastgele.Next(1, 20);

int tahmin = 0;
int hak = 5;
int deneme = 1;

while (sayi != tahmin)
{
    Console.WriteLine("Lütfen 1-20 arasında bir sayı yazın:");
    string tahminEdilenSayi = Console.ReadLine();
    
    if (!int.TryParse(tahminEdilenSayi, out tahmin)) 
    {
        Console.WriteLine("Lütfen 1-20 arasında bir sayı giriniz.");
        continue;
    }

    if (tahmin > 20)
    {
        Console.WriteLine("20 dahil olabilir demiştik. 20'den büyük olamaz!");
        continue;
    }

    if ( tahmin == sayi)
    {
        Console.WriteLine($"Tebrikler!! Tuttuğum sayıyı {hak - 1} hakkın kala ve {deneme}. denemede buldun!!");
        Console.WriteLine("Daha iyi bir sonuç için yine oyna!");
        sayi = tahmin;
        continue;
    }

    if ( hak == 1)
    {
        Console.WriteLine($"Hakkınız bitti. Bilmeniz gereken sayı: {sayi}");
        break;
    }

    Console.WriteLine("Tuttuğum sayıyı bilemediniz!");
    deneme++;
    hak--;

}