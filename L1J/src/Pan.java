
public class Pan {
	private Egg[] eggs;
    private Salt salt;
    private Butter butter;

    public void Init(int countOfEggs)
    {

        eggs = new Egg[countOfEggs];

    }

    public void AddEgg(Egg e)
    {
        for (int i = 0; i < eggs.length; i++)
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
     //   salt.SetCount(true);
    }
    public void AddButter(Butter b)
    {
        butter = b;
     //   butter.SetCount(true);
    }

    public boolean Check()
    {

        if (eggs.length < 1) return false;
        for (int i = 0; i < eggs.length; ++i)
        {
            if (eggs[i] == null) return false;
        }
        if (salt==null) return false;
        if (butter==null) return false;
        return true;
    }

    public void Cook()
    {
         if (!Check()) return;
        for (int i = 0; i < eggs.length; i++)
        {
            eggs[i].Cook();
        }
    }

    public boolean IsReady()
    {
        for (int i = 0; i < eggs.length; i++)
        {
            if (eggs[i].Ready() < 10) return false;
        }
        return true;
    }

    public Egg[] GetEggs()
    {
        return eggs;
    }


}
