

namespace AppDomain.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver TheDriver { get; set; }


     public Car(string model,int speed,Driver thedriver)
        {
            Model = model;
            Speed = speed;
            TheDriver = thedriver;
        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed(Driver d)
        {
            return Speed * d.Skill;
        }

       

    }
}
