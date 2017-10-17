using System;
namespace NASAIsABlast.Models
{
    public class CrewRequirements
    {
        public CrewRequirements() { }

		public int DaysInSpace { get; set; }
		public int ComplexTasks { get; set; }
        public int Answer { get; set; }

        public CrewRequirements(int daysInSpace, int complexTasks)
        {
            this.DaysInSpace = daysInSpace;
            this.ComplexTasks = complexTasks;
        }

        public int RequiredAstronauts() 
        {
            

            //double baseNum = 1.2;
            //double yNum = ComplexTasks / (176 * DaysInSpace);

            //double rawAstronauts = Math.Log(yNum, baseNum) + 1;

            //int totalAstronauts = (int)Math.Ceiling(rawAstronauts);

            //return totalAstronauts;


			double hoursPerDay = 16;
			double tasksPerHour = 11;
            double efficiency = 0;
            bool keepGoing = true;
            int astronauts = 1;

            do
            {
                double totalTasksCanDo = ((tasksPerHour * (1 + (0.2 * efficiency))) * hoursPerDay * (1 + efficiency));
                Console.WriteLine(totalTasksCanDo);
                double daysItWillTake = Math.Ceiling((ComplexTasks / totalTasksCanDo));
                Console.WriteLine(daysItWillTake);
                if (daysItWillTake <= DaysInSpace)
                {
                    keepGoing = false;
                    astronauts = (int)efficiency + 1;
                }
                else {
                    efficiency += 1;
                }
            } while (keepGoing);

            return astronauts;
		}
    } 
}
