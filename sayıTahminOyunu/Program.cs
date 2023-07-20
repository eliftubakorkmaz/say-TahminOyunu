
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

