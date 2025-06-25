using Blinko_5_minute.darkStore;

namespace Blinko_5_minute.manager
{
    public class DarkStoreManager
    {
        public DarkStore darkStore;
        string name;
        //public static DarkStoreManager Instance;

        //private DarkStoreManager()
        //{
        //    // Private constructor to prevent instantiation without parameters
        //}

        //public static  DarkStoreManager GetInsance()
        //{
        //    if (Instance == null)
        //    {
        //        Instance = new DarkStoreManager();
        //    }
        //    return Instance;
        //}
        public DarkStoreManager(DarkStore darkStore, string name)
        {
            this.darkStore = darkStore;
            this.name = name;
        }

        public double GetDistance(double x, double y)
        {
            return darkStore.GetDistance(x, y);
        }




    }
}
