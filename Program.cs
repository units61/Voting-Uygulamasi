
namespace voiting_app
{
   class Program
   {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hoşgeldiniz kullanıcı adınızı giriniz:");
            string userName = Console.ReadLine();
            Console.WriteLine("Şifre giriniz:");
            string password = Console.ReadLine();
            UserController userController = new UserController();
            bool a = userController.Controller(userName, password);
            int aksiyon =0;
            int komedi =0;
            int fantezi =0;
            int korku =0;
            int ask =0;
            int bilimkurgu =0;
            int western =0;
            int muzikal =0;
            int i=1;

            if (a== true && a != null)
            {
                Console.WriteLine("giriş onaylandı hoşgeldiniz");
                Console.WriteLine("lütfen oylamaya katılın");
                foreach (string name in Enum.GetNames(typeof(filmCategory)))
                {
                    
                    Console.WriteLine(name +" için " + i++);
                }
                Console.WriteLine("oyunuz için teşekkürler.");
                int b = Convert.ToInt32(Console.ReadLine());
                
                if (b == 1) aksiyon++;
                if (b == 2) komedi++;
                if (b == 3) fantezi++;
                if (b == 4) korku++;
                if (b == 5) ask++;
                if (b == 6) bilimkurgu++;
                if (b == 7) western++;
                if (b == 8) muzikal++;

                Console.WriteLine("AKSİYON:" + aksiyon);
                Console.WriteLine("KOMEDİ:" + komedi);
                Console.WriteLine("FANTEZİ:" + fantezi);
                Console.WriteLine("KORKU:" + korku);
                Console.WriteLine("ASK:" + ask);
                Console.WriteLine("BİLİM KURGU:" + bilimkurgu);
                Console.WriteLine("WESTERN:" + western);
                Console.WriteLine("MUZİKAL:" + muzikal);
                float sonuc1 = aksiyon*8/100f;
                Console.WriteLine("Aksiyon filmleri %" + sonuc1 + " oy almıştır.");
                float sonuc2 = komedi*8/100f;
                Console.WriteLine("Komedi filmleri %" + sonuc2 + " oy almıştır.");
                float sonuc3 = fantezi*8/100f;
                Console.WriteLine("Fantezi filmleri %" + sonuc3 + " oy almıştır.");
                float sonuc4 = korku*8/100f;
                Console.WriteLine("Korku filmleri %" + sonuc4 + " oy almıştır.");
                float sonuc5 = ask*8/100f;
                Console.WriteLine("Aşk filmleri %" + sonuc5 + " oy almıştır.");
                float sonuc6 = bilimkurgu*8/100f;
                Console.WriteLine("Bilim Kurgu filmleri %" + sonuc6 + " oy almıştır.");
                float sonuc7 = western*8/100f;
                Console.WriteLine("Western filmleri %" + sonuc7 + " oy almıştır.");
                float sonuc8 = muzikal*8/100f;
                Console.WriteLine("Müzikal filmleri %" + sonuc8 + " oy almıştır.");
            }
            if (a== false && a == null)
            {
                Console.WriteLine("kayıt olmak için username giriniz");
                string newUserName = Console.ReadLine();
                Console.WriteLine("şifre girin");
                string newPassword = Console.ReadLine();
                bool c = userController.AddUser(newUserName, newPassword);
                if (c == true) Console.WriteLine("kayıt başarılı");
                else Console.WriteLine("kullanıcı adı kullanımda");    

             
            }
        }
        
    }

    enum filmCategory{
        Aksiyon = 1,
        Komedi,
        Fantezi,
        Korku,
        Aşk,
        BilimKurgu,
        Western,
        Müzikal, 

    }

}

