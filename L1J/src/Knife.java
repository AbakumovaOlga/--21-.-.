
public class Knife {
	public void Hit(Egg egg)
    {

        if (!egg.GetDirty())
        {
            if (egg.GetHave_eggshell())
            {
                egg.SetHave_eggshell(false);

            }
        }
    }
}
