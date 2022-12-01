using Vehicles;

internal class Program
{





    public static void Main(string[] args)
    {
        //List of people registered
        List<Person> register;
        register = new List<Person>();

        //FIRST PERSON REGISTERED
        Person p0 = new Person();

        //We add the attributes to the person through a method
        //in the class Person for avoiding repetition

        //In this first case, this person is not going to be added since it is over 90 years old
        p0.checkPerson(p0, 1, "Fernanda", "Solís", 90, "FEMALE");

        //This one is going to be added
        p0.checkPerson(p0, 1, "Mariana", "Castillo", 25, "FEMALE");

        //Then we add that person to the register
        register.Add(p0);


        //After that, we can continue adding new vehicles and licenses just if the conditions are aproved
        p0.addVehicle(p0, 'A', "2022", "DODGE", "Good car", "Big black", "BLACK");



        //SECOND PERSON REGISTERED
        Person p1 = new Person();
        p1.checkPerson(p1, 2, "Yahir", "Castro", 30, "MALE");
        register.Add(p1);


        //Here we call a method for adding a new license
        p1.createLicense(p1, new DateTime(2011, 2, 19), new DateTime(2022, 9, 21), 'A');

        //This license is not going to be created since there is an existing one than has not expired yet
        p1.createLicense(p1, new DateTime(2022, 9, 19), new DateTime(2024, 9, 16), 'A');

        p1.createLicense(p1, new DateTime(2021, 11, 22), new DateTime(2024, 11, 22), 'B');


        //Here we call a method for adding a new vehicle
        p1.addVehicle(p1, 'A', "2022", "TOYOTA", "Good car", "Big black", "BLACK");
        p1.addVehicle(p1, 'B', "2022", "FORD", "Good Motocycle", "Big black", "GREEN");
        p1.addVehicle(p1, 'C', "2022", "FORD", "Good Bus", "Big black", "BLUE");
        p1.addVehicle(p1, 'C', "2020", "TOYOTA", "Good Bus", "Big red", "RED");
        p1.addVehicle(p1, 'C', "2018", "FORD", "Good Bus", "Big purple", "PURPLE");
        p1.addVehicle(p1, 'B', "2020", "FORD", "Good Bus", "Big yellow", "YELLOW");

        //This vehicle is not going to be added since it is a different brand than Toyota and Ford
        p1.addVehicle(p1, 'C', "2022", "KIA", "Good car", "Big black", "BLUE");


        //This vehicle is not going to be deleted since the person doesn't have a license with the 'C' type
        p1.deleteVehicle(p1, register[1].vehicles[2]);

        //We also have the possibility to delete a vehicle
        p1.deleteVehicle(p1, register[1].vehicles[1]);




        //Console.WriteLine(register[0].name);
        //Console.WriteLine(register[0].licenses[0].type);
        ////Console.WriteLine(register[0].vehicles[0].brand);
        //Console.WriteLine(register[1].name);
        //Console.WriteLine(register[1].licenses[0].type);
        //Console.WriteLine(register[1].vehicles[0].color);
        //Console.WriteLine(register[1].vehicles.Count);
        //Console.WriteLine(register[1].licenses[0].exp_Date.ToString("dd/MM/yyyy"));
        //Console.WriteLine(register[1].susp_Fraud);


    }





    //public void checkPerson(int keyC, string nam, string surn, int age, string gen)
    //{
    //    for (int i = 0; i < register.Count; i++)
    //    {
    //        if (register[i].keyCode == keyC)
    //        {
    //            Console.WriteLine("There's an existent user with that keyCode");
    //            return;
    //        }
    //    }
    //    Person person = new Person();
    //    person.keyCode = keyC;
    //    person.name = nam;
    //    person.surname = surn;
    //    person.age = age;
    //    person.genre = gen;
    //    register.Add(person);
    //}
}