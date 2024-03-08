namespace dotnetWebApi.Models
{
    public class Character
    {
        public int Id{get; set;}

        public string Name {get; set;} = "frodo";

        public int Strength {get; set;} = 10;

        public int Defence {get; set;} = 10;


        public int Intelligence {get; set;} = 10;

        public RpgClass Class {get; set;} = RpgClass.Knight;
        
        

    }
}