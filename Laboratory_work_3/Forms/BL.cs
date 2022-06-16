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
            int uping = Convert.ToInt32(10 * m);
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
                    return("Недостаточно денег");
                }
            }
            else
            {
                return("Недостаточно опыта");
            }
        }
    }
}
