using Laboratory_work_3.Model;
using System;

namespace Laboratory_work_3.Forms
{
    public class BL
    {

        public static string Eating(double m)
        {
            int needRich = Convert.ToInt32(10 * m);

            if (App.myGamer.Satiety == 100)
            {

                GameWindow gameWindow = new GameWindow();
                return ("Вы максимально сыты");
            }
            else if (App.myGamer.Money >= needRich)
            {
                App.myGamer.Money -= (needRich);
                if (App.myGamer.Satiety > 90)
                {
                    App.myGamer.Satiety = 100;
                    GameWindow gameWindow = new GameWindow();
                    return ("Вы полностью сыты");
                }
                else
                {
                    App.myGamer.Satiety += (needRich);
                    GameWindow gameWindow = new GameWindow();
                    return ("Вы успешно перекусили");
                }
            }
            else
            {
                GameWindow gameWindow = new GameWindow();
                return ("У вас не хватает денег");
            }
        }

        public static string Corning(double m)
        {
            int needs = Convert.ToInt32(50 * m);
            int uping = Convert.ToInt32(5 * m);
            if (App.myWork.Experience > needs)
            {
                if (App.myGamer.Money >= needs)
                {
                    App.myGamer.Fatigue += uping;
                    App.myWork.Experience += uping;
                    App.myGamer.Money -= needs;
                    return ("Вы успешно выполнили то, что планировали");

                }
                else
                {
                    return ("Недостаточно денег");
                }
            }
            else
            {
                return ("Недостаточно опыта");
            }
        }
        public static void Corning(int randNum)
        {
            App.myGamer.Fatigue += 2 * randNum;
            App.myWork.Experience += 10 * randNum;
        }
        public static void Upgraiding(int NumUpdate)
        {
            if (NumUpdate == 1)
            {
                App.myHome.Home += 1;
            }
            else if (NumUpdate == 2)
            {
                App.myHome.Farmers += 1;
            }
            else if (NumUpdate == 3)
            {
                App.myHome.Tools += 1;
            }
            else if (NumUpdate == 4)
            {
                App.myHome.ArayleLand += 1;
            }

            else if (NumUpdate == 5)
            {
                App.myHome.Livestock += 1;
            }
            else if (NumUpdate == 6)
            {
                App.myHome.LivestockFeed += 1;
            }
            else if (NumUpdate == 7)
            {
                App.myHome.LivestockMan += 1;
            }else if (NumUpdate == 8)
            {
                App.myHome.Drug += 1;
            }
            App.myGamer.Money -= 1000;
        }
        public static void Saving()
        {

            Model.Gamer newGamer = new Model.Gamer();
            Model.HomeLand newFarm = new Model.HomeLand();
            Model.Work newWork = new Model.Work();

            newGamer.Name = App.myGamer.Name;
            newGamer.Age = App.myGamer.Age;
            newGamer.Gender = App.myGamer.Gender;
            newGamer.Satiety = App.myGamer.Satiety;
            newGamer.Fatigue = App.myGamer.Fatigue;
            newGamer.Money = App.myGamer.Money;
            newGamer.Day = App.myGamer.Day;

            newFarm.Farmers = App.myHome.Farmers;
            newFarm.Tools = App.myHome.Tools;
            newFarm.Livestock = App.myHome.Livestock;
            newFarm.LivestockFeed = App.myHome.LivestockFeed;
            newFarm.LivestockMan = App.myHome.LivestockMan;
            newFarm.ArayleLand = App.myHome.ArayleLand;
            newFarm.Home = App.myHome.Home;
            newFarm.Drug = App.myHome.Drug;

            newWork.Name = App.myWork.Name;
            newWork.Wages = App.myWork.Wages;
            newWork.Minqualifications = App.myWork.Minqualifications;
            newWork.Experience = App.myWork.Experience;
            newWork.UpExperience = App.myWork.UpExperience;

            using DB.MySqlLiteContext mySqlLiteContext = new DB.MySqlLiteContext();
            mySqlLiteContext.Gamers.Add(newGamer);
            mySqlLiteContext.SaveChanges();
            mySqlLiteContext.Farms.Add(newFarm);
            mySqlLiteContext.SaveChanges();
            mySqlLiteContext.Works.Add(newWork);
            mySqlLiteContext.SaveChanges();

        }
        public static void NextDay()
        {
            Work work = new Work();
            Gamer gamer = new Gamer();
            work.Experience += App.myWork.UpExperience;
            gamer.Money += App.myWork.Wages;
            gamer.Fatigue = 0;
            gamer.Day += 1;
            gamer.Satiety -= 10;
        }
    }
}
