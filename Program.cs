using AbstractFactory.Factory;

Console.WriteLine("Hello  please Choose your Bannk A Or B : ");
Console.WriteLine("1 =======> A: ");
Console.WriteLine("2 =======> B: ");
var test = Console.ReadLine();

IBankFactory bankFactory = new BankFactory();
var bank = bankFactory.CreateBank(test);


//if (test == "1")
//{
    //BankA bank = new BankA();
    Console.WriteLine(bank.GetName());
        var PymentMthod = bank.PaymentCardName("Paypal");
        Console.WriteLine(PymentMthod.PaymentCardName());

//}
//if (test == "2")
//{
//BankB bank = new BankB();
//Console.WriteLine(bank.GetName());
// PymentMthod = bank.PaymentCardName("visacard");
//    Console.WriteLine(PymentMthod.PaymentCardName());

//}

//if (test == "2")
//{
//BankB bank = new BankB();
//Console.WriteLine(bank.GetName());
// PymentMthod = bank.PaymentCardName("visacard");
//    Console.WriteLine(PymentMthod.PaymentCardName());

//}
