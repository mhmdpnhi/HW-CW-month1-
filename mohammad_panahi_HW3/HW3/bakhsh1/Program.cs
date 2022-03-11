//part 4 convert enums member to String
ContactTypeEnum kindOfContact = ContactTypeEnum.SMS;
ContactTypeEnum kindOfContact2 = ContactTypeEnum.Email;
Console.WriteLine("first type of contact is: "+kindOfContact.ToString()+"\n"+
                  "seconed type of contact is: "+kindOfContact2.ToString());
Console.WriteLine("----------------------");


//part 5 & 7 : declare enum arr & print integers which are Equivalent to enums member 
ContactTypeEnum[] enumArr = new ContactTypeEnum[2];
enumArr[0] = kindOfContact; enumArr[1] = kindOfContact2;
Console.WriteLine("Convert SMS to integer(as enums's declaring): " + (int)enumArr[0] + "\n" +
                  "Convert Emali to integer(as enums's declaring): " + (int)enumArr[1]);
Console.WriteLine("----------------------");


//part 6 : cast integer to enum number
int forCast = 2;
Console.WriteLine("Convert 2 (as integer) to ContactType is: "+(ContactTypeEnum)forCast);
Console.WriteLine("----------------------");


//part 8 : Convert String to enum's member   !!!
var forAddToEnumClass = "Email";
var answer=Enum.IsDefined(typeof(ContactTypeEnum), forAddToEnumClass);
Console.WriteLine("is there " + forAddToEnumClass + " in the enums: "+answer);
Console.WriteLine("----------------------");

//part 9 : switch 
Console.Write("enter a number for choose ur Contact type:(1/2) ");
var forSwitch=Convert.ToInt32(Console.ReadLine());
switch (forSwitch)
{
    case (int)ContactTypeEnum.Email:
        Console.WriteLine("ur number is equvalince to Email.");
        break;
    case (int)ContactTypeEnum.SMS:
        Console.WriteLine("ur number is equvalince to SMS.");
        break;
}



