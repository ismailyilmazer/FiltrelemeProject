using HtmlAgilityPack;
using Microsoft.Data.SqlClient;


namespace UrlCrawl
{
    public class HaberBaslik
    {
        public int Id;
        public string? HaberBasligi;

    }
  
    class Program
    {
      
        HaberBaslik haberBasligi = new HaberBaslik();
        static void Main(string[] args)
        {
            var web = new HtmlWeb();
            var doc = new HtmlDocument();
            doc = web.Load("https://www.sozcu.com.tr/kategori/ekonomi/");
            SqlConnection baglanti = new SqlConnection("Data Source=ISMAILYILMAZER\\MSSQLSERVER01; Initial Catalog=HaberDB; Integrated Security=True;TrustServerCertificate=True");
            foreach (var item in doc.DocumentNode.SelectNodes("//a[@class='news-item-title']"))
            {
                HaberBaslik haberBasligi = new HaberBaslik();
                haberBasligi.HaberBasligi = item.InnerText;

                string sorgu = " Insert into HaberBasliklari (Description) select '@Description' where '@Description'not in " +
                    "(select Description from HaberBasliklari) ";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
          
                komut.Parameters.AddWithValue("@Description", haberBasligi.HaberBasligi);



                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

            }

        }

    }
}
