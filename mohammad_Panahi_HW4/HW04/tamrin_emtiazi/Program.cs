Console.WriteLine("what kind of massege do u want to send?\n" +
                  "1.email\n2.sms");
var kind=Convert.ToInt16(Console.ReadLine());
if(kind == 1) { ISendMessage m = new SendEmail();  m.sendMessage();   } //call IEmailSending
else if(kind == 2) { ISendMessage m = new SendSMS(); m.sendMessage(); } //call ISMSSending
