namespace mylib;
public class NumberGuesser
{
    public string GuessTheNumber(int? x)
    {
        if(x > 0){
            return "yes";
        }else{
            return "no";
        }
        
    }

}
