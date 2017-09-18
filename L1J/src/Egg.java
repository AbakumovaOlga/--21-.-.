
public class Egg {

	private int ready;
	
	public int Ready(){
		
		return ready;
	}
	

    private boolean have_eggshell = true;

    public void SetHave_eggshell (boolean value){
    	have_eggshell=value;
    }
    
    public boolean GetHave_eggshell(){
    	return have_eggshell;
    }

    
    private boolean dirty = true;
    public boolean GetDirty (){
    	return dirty;
    }
    public void SetDirty(boolean d){
    	dirty=d;
    }
    
    public void Cook()
    {
        if (Ready() < 10)
        {
            ready++;
   
        }
    }


}
