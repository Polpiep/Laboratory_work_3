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
    }
}
