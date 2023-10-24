namespace sampledvm
{
    internal class Program
    {
       public  static void Main(string[] args)
       {
            // Erkeklerin 25 yıl kadınların da 20 yıl çalıştıktan sonra emekli olacağı varsayılam bir ortamda klavyeden girilen cinsiyet ve sigorta prim
            //sayısına göre kişinin emekliliğine ne kadar süresi kaldığını hesaplayan programcığı yazınız..

            //Hints
            // 1 yıl= 360 gün kabul edilecek
            // 1 ay= 30 gün kabul edilecek
            // Örnek: 1943 gün --> 5 yıl 4 ay 23 gün vardır diyecek.

            // Bu örnekteki kullanacağınız metoda cinsiyet parametresini de ekleyerek buna göre sonucu ekrana yazdrınız.
            //Yani cinsiyet erkek ve 6643 gün girdin --> emekliliğinize 6 yıl 6 ay 17 gün vardır diyecek

            Console.Write("Cinsiyet (erkek/kadın): ");
            string cinsiyet = Console.ReadLine();

            Console.Write("Sigorta prim sayısı (gün): ");
            int sigortaPrim = int.Parse(Console.ReadLine());

            int toplamGun = sigortaPrim;
            int toplamYil = toplamGun / 360;
            toplamGun %= 360;
            int toplamAy = toplamGun / 30;
            toplamGun %= 30;

            if (cinsiyet.ToLower() == "erkek")
            {
                Console.WriteLine($"Emekliliğinize {toplamYil} yıl {toplamAy} ay {toplamGun} gün vardır.");
            }
            else if (cinsiyet.ToLower() == "kadın")
            {
                int kadınEmeklilikYasi = 20 * 360;
                int kalanGun = kadınEmeklilikYasi - sigortaPrim;

                int kalanYil = kalanGun / 360;
                kalanGun %= 360;
                int kalanAy = kalanGun / 30;
                kalanGun %= 30;

                Console.WriteLine($"Emekliliğinize {kalanYil} yıl {kalanAy} ay {kalanGun} gün vardır.");
            }
            else
            {
                Console.WriteLine("Geçersiz cinsiyet bilgisi girdiniz.");
            }

       }
    }
}