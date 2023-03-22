namespace FinalTask
{
    class Program
    {
        public static void Main(string[] args)
        {
			User[] arr = new User[] { 
				new User("11111", "Pavel", false ), 
				new User("22222", "Alexander", true), 
				new User("33333", "Michail", false) 
			};
            for (int  i = 0;  i < arr.Length;  i++)
            {
				arr[i].Greeting();
                if (arr[i].IsPremium != true)
                {
					ShowAds();
                }
            }
        }
		static void ShowAds()
		{
			Console.WriteLine("Сайт для совершения интернет платежей в играх pay2win.com");
			Thread.Sleep(1000);
			Console.WriteLine("Оформляйте премиум версию чтобы не платить больше, а также чтобы скрыть рекламу.");
			Thread.Sleep(2000);
			Console.WriteLine("С премиум версией вы можете совершать больше сделок");
			Thread.Sleep(3000);
            Console.WriteLine();
		}
	}
}
