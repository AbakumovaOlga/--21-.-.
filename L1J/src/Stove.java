
public class Stove {
	private Pan pan;
    private boolean state ;
    public boolean GetState(){
    	return state;
    }
    public void SetState(boolean s){
    	state=s;
    }
    
    
    
  //  public Pan Pan { set { pan = value; } get { return pan; } }
public Pan GetPan(){
	return pan;
}
public void SetPan(Pan p){
	pan=p;
}

    
    
    
    
    public void Cooking()
    {
        if (GetState()==true) // если плита включена 
        {
            while (!pan.IsReady()) // пока не будет готово 
            {
                pan.Cook();
            }
        }
    }
}
