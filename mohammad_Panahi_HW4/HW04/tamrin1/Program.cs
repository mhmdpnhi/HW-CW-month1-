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
                var p = new Person();
                Console.WriteLine("enter first name : ");                     p.FName = Console.ReadLine();
                Console.WriteLine("enter last name : ");                      p.LName = Console.ReadLine();
                Console.WriteLine("enter mobile number : ");                  p.MobileNumber = Console.ReadLine();                
                Console.WriteLine("enter height (free to enter) :");          p.Height = Convert.ToDouble(Console.ReadLine());              
                Console.WriteLine("enter weight (free to enter) :");          p.Weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter fathers name (free to enter) :");    p.FName = Console.ReadLine();           
                Console.WriteLine("enter birth day date (free to enter) : "); p.BirthDay = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("enter address (free to enter) : ");        p.Address = Console.ReadLine();               
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