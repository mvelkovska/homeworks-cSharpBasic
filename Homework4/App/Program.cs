using AppDomain.Classes;
using System;

namespace App
{

    class Program
    {
        public static void RaceCars(Car c1, Car c2)
        {
            if (c1.CalculateSpeed(c1.TheDriver) > c2.CalculateSpeed(c2.TheDriver))

            {
                Console.WriteLine($"MODEL: {c1.Model} , SPEED: {c1.Speed}, {c1.TheDriver.Name} WON!");

            }

            else if (c1.CalculateSpeed(c1.TheDriver) < c2.CalculateSpeed(c2.TheDriver))
            {

                Console.WriteLine($"MODEL: {c2.Model} , SPEED: {c2.Speed}, {c2.TheDriver.Name} WON!");
            }
            else
            {
                Console.WriteLine("NOBODY WON THE RACE!");
            }
        }



        public static int CheckValidity(string c1, string c2, string d1, string d2, Driver[] drivers, Car[] cars)
        {
            // return 1(dobro), return 2(loso), return 3(izbor na korisnikot da ne prodolzi)
            bool flag1 = false;
            bool flag2 = false;

            if ((!(String.IsNullOrEmpty(c1))) && (!(String.IsNullOrEmpty(c2))) && (!(String.IsNullOrEmpty(d1))) && (!(String.IsNullOrEmpty(d2))))
            {

                foreach (Car c in cars)
                {


                    if (c1.Equals(c.Model, StringComparison.InvariantCultureIgnoreCase) || c2.Equals(c.Model, StringComparison.InvariantCultureIgnoreCase))
                    {
                        flag1 = true;
                    }
                }

                foreach (Driver d in drivers)
                {
                    if (d1.Equals(d.Name, StringComparison.InvariantCultureIgnoreCase) || d2.Equals(d.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        flag2 = true;
                    }
                }

                if (flag1 && flag2)
                {

                    return 1;
                }


            }
            else
            {
                Console.WriteLine("Please fill out everything! Try again or type x to leave");
                if (Console.ReadLine().Equals("x", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("BYE BYE");


                    return 3;
                }

                return 2;

            }


            Console.WriteLine("Some of your values are not correct! Try again or type x to leave.");
            if (Console.ReadLine().Equals("x", StringComparison.InvariantCultureIgnoreCase))

            {
                Console.WriteLine("BYE BYE");

                return 3;
            }
            return 2;
        }

        public static void PrintCars(Car[] c, string car)
        {
            int counter = 1;
            foreach (Car cc in c)
            {
                if (car.Equals(cc.Model, StringComparison.InvariantCultureIgnoreCase))
                {

                    continue;
                }
                else
                {
                    Console.WriteLine($"{counter}.{cc.Model}");
                    counter++;
                }
            }
        }

        public static void PrintDrivers(Driver[] d, string driver)
        {
            int counter = 1;
            foreach (Driver dd in d)
            {
                if (driver.Equals(dd.Name, StringComparison.InvariantCultureIgnoreCase))
                {

                    continue;
                }
                else
                {
                    Console.WriteLine($"{counter}.{dd.Name}");
                    counter++;
                }
            }
        }

        public static Car[] Assigning(Car[] CARS, Driver[] DRIVERS, string userCar, string userDriver)
        {

            Car[] THE_CAR = new Car[1];
            int j = 0;
            for (int i = 0; i < CARS.Length; i++)
            {
                if (userCar.ToLower() == CARS[i].Model.ToLower())
                {
                    THE_CAR[0] = CARS[i];
                }
            }

            while (j < DRIVERS.Length)
            {
                if (userDriver.ToLower() == DRIVERS[j].Name.ToLower())
                {
                    THE_CAR[0].TheDriver = DRIVERS[j];
                    break;
                }
                j++;
            }

            return THE_CAR;
        }

        static void Main(string[] args)
        {
            Driver[] drivers = new Driver[] {
            new Driver("Bob",15),
            new Driver("Greg",20),
            new Driver("Jill",5),
            new Driver("Anne",10)

            };

            Car[] cars = new Car[]
            {
                new Car("Hyundai",5000),
                new Car("Mazda",6000),
                new Car("Ferrari",880),
                new Car("Porsche",700)
            };

            string car1, car2, driver1, driver2;
            string randomWord1 = "word1";
            string randomWord2 = "word2";

            while (true)
            {

                do
                {
                    Console.WriteLine("Enter car1.Click enter to fill the next field");
                    PrintCars(cars, randomWord1);
                    car1 = Console.ReadLine();

                    Console.WriteLine("Enter driver1.Click enter to fill the next field");
                    PrintDrivers(drivers, randomWord2);
                    driver1 = Console.ReadLine();


                    Console.WriteLine("Enter car2.Click enter to fill the next field");
                    PrintCars(cars, car1);
                    car2 = Console.ReadLine();

                    Console.WriteLine("Enter driver2.This is your last field");
                    PrintDrivers(drivers, driver1);
                    driver2 = Console.ReadLine();

                }
                while ((CheckValidity(car1, driver1, car2, driver2, drivers, cars)) == 2);


                if ((CheckValidity(car1, driver1, car2, driver2, drivers, cars) == 1))
                {
                    Car[] firstCar = new Car[1];
                    Car[] secondCar = new Car[1];

                    firstCar = Assigning(cars, drivers, car1, driver1);
                    secondCar = Assigning(cars, drivers, car2, driver2);

                    Console.WriteLine(firstCar[0].Model); //Mazda
                    Console.WriteLine(firstCar[0].TheDriver.Name);//Bob

                    Console.WriteLine(secondCar[0].Model); //Ferrari
                    Console.WriteLine(secondCar[0].TheDriver.Name);//Jill


                    RaceCars(firstCar[0], secondCar[0]);


                    string usersInput;

                    Console.WriteLine("Do you want to play again? \"y\" or \"n\" ");
                    usersInput = Console.ReadLine();
                    if (usersInput.ToLower() == "n")
                    {
                        Console.WriteLine("GOODBYE!");
                        break;
                    }
                    else if (usersInput.ToLower() == "y")
                    {
                        Console.Clear();
                    }
                    else { return; }

                }
            }

            
            Console.ReadLine();



        }
    }
}