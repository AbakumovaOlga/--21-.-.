using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Прогр1_1_
{
    class Pan
    {
        private Egg[] eggs;
        private Salt salt;
        private Butter butter;

        public void Init(int countOfEggs)
        {

            eggs = new Egg[countOfEggs];

        }

        public void AddEgg(Egg e)
        {
            for (int i = 0; i < eggs.Length; i++)
            {
                if (eggs[i] == null)
                {
                    eggs[i] = e;
                    return;
                }
            }
        }

        public void AddSalt(Salt s)
        {
            salt = s;
            salt.Count = true;
        }
        public void AddButter(Butter b)
        {
            butter = b;
            butter.Count = true;
        }

        public bool Check()
        {
            if (eggs == null)
            {
               return false;
            }

            if (eggs.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Have_eggshell)
                {
                    return false;
                }
            }

            if (eggs.Length < 1) return false;
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i] == null) return false;
            }
            if (!salt.Count) return false;
            if (!butter.Count) return false;
            return true;
        }

        public void Cook()
        {
             if (!Check()) return;
            for (int i = 0; i < eggs.Length; i++)
            {
                eggs[i].Cook();
            }
        }

        public bool IsReady()
        {
          if (eggs == null)
            {
                return false;
            }

            if (eggs.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Have_eggshell)
                {
                    return false;
                }
            }
            for (int i = 0; i < eggs.Length; i++)
            {
                if (eggs[i].Ready < 10) return false;
            }
            return true;
        }

        public Egg[] GetEggs()
        {
            return eggs;
        }
    }
}
