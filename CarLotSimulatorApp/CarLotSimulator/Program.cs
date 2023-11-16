using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE__Create a seperate class file called Car DONE!

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var lot = new CarLot();
            
            
            //Dot Notation
            var generalLee = new ClassyCar();
            generalLee.Make = "Dodge";
            generalLee.Model = "Charger";
            generalLee.Year = 1969;
            generalLee.EngineNoise = "Vroooooooooooom!";
            generalLee.HonkNoise = "Dixie";
            generalLee.IsDriveable = true;

            lot.Cars.Add(generalLee);


            //Object Inititalizer Syntax
            var batMobile = new ClassyCar()
            {
                Year = 1955,
                Make = "Ford",
                Model = "Lincoln",
                EngineNoise = "rrrRrrrrrrRrrrrrrrrrRrrrrrrrrrrrrrrr!",
                HonkNoise = "NaNaNaNaNaNaNaNa-BAT-MAAAAAN!!!",
                IsDriveable = true

            };

            lot.Cars.Add(batMobile);

            //List Parameters 
            var timeMachine = new ClassyCar(1981, "DeLorean", "dmc-12", "Whhooooosssshhhhh!", "ERRRRRRR", true);

            lot.Cars.Add(timeMachine);

            generalLee.MakeEngineNoise(generalLee.EngineNoise);
            batMobile.MakeEngineNoise(batMobile.EngineNoise);
            timeMachine.MakeEngineNoise(timeMachine.EngineNoise);

            Console.WriteLine();

            generalLee.MakeHonkNoise(generalLee.HonkNoise);
            batMobile.MakeHonkNoise(batMobile.HonkNoise);
            timeMachine.MakeHonkNoise(timeMachine.HonkNoise);

            Console.WriteLine();

            Console.WriteLine($"Number of new cars: {CarLot.numberOfCars}");

            
            foreach (var ClassyCar in lot.Cars)
            {
                Console.WriteLine($"Year: {ClassyCar.Year} Make: {ClassyCar.Make} Model: {ClassyCar.Model}");
                 
            }


            //*************BONUS*************//

            //DONE Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
