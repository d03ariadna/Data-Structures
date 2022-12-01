using System;

namespace Vehicles
{
    internal class Person
    {
        public int keyCode { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string genre { get; set; }
        public Boolean susp_Fraud { get; set; }

        public List<License> licenses;

        public List<Vehicles> vehicles;

        public Person()
        {
            this.licenses = new List<License>();
            this.vehicles = new List<Vehicles>();
            this.keyCode = 0;
            this.name = "";
            this.surname = "";
            this.age = 0;
            this.genre = "";
            this.susp_Fraud = false;
        }

        //Method for adding a new person
        public void checkPerson(Person person, int keyC, string nam, string surn, int ag, string gen)
        {

            person.keyCode = keyC;
            person.name = nam;
            person.surname = surn;
            person.age = ag;
            person.genre = gen;
        }

        //Method for creating a new license
        public void createLicense(Person person, DateTime ini_D, DateTime exp_D, char typ)
        {
            if (person.age > 90)
            {
                Console.WriteLine("Invalid Age");
                return;
            }
            for (int i = 0; i < person.licenses.Count; i++)
            {
                if (person.licenses[i].type == typ)
                {
                    if (person.licenses[i].exp_Date > DateTime.Now)
                    {
                        Console.WriteLine("You already have a valid license");
                        return;
                    }
                    //In case the license is in fact expired, then we just
                    //modify the initial_Date and expiration_Date of the existing one
                    else
                    {
                        person.licenses[i].ini_Date = ini_D;
                        person.licenses[i].exp_Date = exp_D;
                        return;
                    }
                }
            }

            //If none of the previous conditions are true,
            //that means we can create a new license: 
            License license = new License();
            license.keyCode = person.keyCode;
            license.ini_Date = ini_D;
            license.exp_Date = exp_D;
            license.status = false;
            license.type = typ;
            person.licenses.Add(license);
        }




        //Method for adding a new vehicle
        public void addVehicle(Person person, char typ, string year, string bran, string desc, string whee, string col)
        {
            //Condition for females
            if (person.genre == "FEMALE")
            {
                if (col != "RED")
                {
                    Console.WriteLine("ERROR at adding a vehicle for " + person.name + ".\nYou can not add another COLOR but red to a woman");
                    return;
                }
            }
            //Condition for Males
            else
            {
                if (person.genre == "MALE")
                {
                    if ((bran != "FORD") && (bran != "TOYOTA"))
                    {
                        Console.WriteLine("ERROR at adding a vehicle for " + person.name + ".\n You can not add another BRAND but Toyota or Ford to a man");
                        return;
                    }
                }
            }

            Vehicles vehicle = new Vehicles();
            vehicle.type = typ;
            vehicle.year = year;
            vehicle.brand = bran;
            vehicle.description = desc;
            vehicle.wheels = whee;
            vehicle.color = col;
            person.vehicles.Add(vehicle);

            if (vehicles.Count > 5)
            {
                person.susp_Fraud = true;
            }
            else
            {
                person.susp_Fraud = false;
            }
        }


        
        //Method for deleting a vehicle
        public void deleteVehicle(Person person, Vehicles vehicle)
        {
            for( int i = 0; i < licenses.Count; i++)
            {
                if (licenses[i].type == vehicle.type)
                {
                    licenses.RemoveAt(i);
                    vehicles.RemoveAt(i);
                    Console.WriteLine("Vehicle succesfully deleted");
                    if (vehicles.Count < 5)
                    {
                        person.susp_Fraud = false;
                    }
                    return;
                }
            }
            Console.WriteLine("You don't have a valid license for this vehicle:(");
        }




    }
}
