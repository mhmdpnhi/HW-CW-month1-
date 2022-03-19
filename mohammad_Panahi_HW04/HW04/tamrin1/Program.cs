bool flag = true; int counter = 1;
while (flag)
{
    Console.WriteLine("what do u want to do?\n" +
                      "1. add person...\n" +
                      "2. see list of persons\n" +
                      "3. close the program and erase informations");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (k)
    {
        case 1:
            bool flag2 = true;
            while (flag2)
            {
                Console.WriteLine($"person number {counter} ==>");
                counter++;
                Console.WriteLine("enter first name : ");
                var fName = Console.ReadLine();
                Console.WriteLine("enter last name : ");
                var lName= Console.ReadLine();
                Console.WriteLine("enter mobile number : ");
                var MobileNumber= Console.ReadLine();
                Console.WriteLine("enter height (free to enter) :");
                double? height =Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter weight (free to enter) :");
                double? weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter fathers name (free to enter) :");
                string? fathersName = Console.ReadLine();
                Console.WriteLine("enter birth day date (free to enter) : ");
                string? bDay=Console.ReadLine();
                Console.WriteLine("enter address (free to enter) : ");
                string? addres = Console.ReadLine();
                Person p=new Person(fName, lName, MobileNumber, height, weight, fathersName, bDay, addres);
                SaveInformation.addPerson(p);

                Console.WriteLine("Do u want to add person again? (Y/N)");
                var check=Convert.ToChar(Console.ReadLine());
                if (check == 'Y' || check == 'y') flag2 = true;
                else flag2 = false;
            }
            break;
       
        case 2:
            var inf = SaveInformation.getInformation();
            foreach (var item in inf)
            {
                Console.WriteLine(item);
            }
            break;
        
        case 3:
            flag = false;
            SaveInformation.eraseInformation();
            break;

    }
}