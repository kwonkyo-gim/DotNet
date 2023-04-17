using System;

namespace PropertyAll
{
    public class Car
    {
        
        private string color;

        
        public Car()
        {
            this.color = "Black";
        }

        
        public void SetColor(string color)
        {
            this.color = color; 
        }

        public string GetColor()
        {
            return color;
        }

        
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        
        public string Make
        {
            get
            {
                return "한국자동차";
            }
        }

        
        private string _Type;
        public string Type
        {
            set
            {
                _Type = value;
            }
        }

        
        public string Name { get; set; }
    }

    class PropertyAll
    {
        static void Main()
        {
            
            Car car1 = new Car();
            car1.SetColor("Red");
            Console.WriteLine(car1.GetColor());

            
            Car whiteCar = new Car();
            whiteCar.Color = "White"; 
            Console.WriteLine(whiteCar.Color); 

            
            Car k = new Car();
            
            Console.WriteLine(k.Make);

            
            Car car = new Car();
            car.Type = "중형"; 
            

            Car myCar = new Car();
            myCar.Name = "좋은차";
            Console.WriteLine(myCar.Name);
        }
    }
}