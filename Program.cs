// See https://aka.ms/new-console-template for more information
string operacion= "operacion";

var valor1 =1.1;
var valor2 =1.1;
var resultado =1.1;



Console.WriteLine("Hola humano en que puedo ayudarte¡");
Console.WriteLine("Quisieres hacer una suma, una resta o una multiplicacion?");
operacion = Console.ReadLine();

if(operacion == "suma"){
    Console.WriteLine("Dame el primer valor");
    valor1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Dame el segundo valor");
    valor2 = Convert.ToDouble(Console.ReadLine());  

    resultado = valor1+valor2;
    Console.WriteLine("el resultado de tu"+operacion+":"+resultado);
}
if(operacion == "resta"){
    Console.WriteLine("Dame el primer valor");
    valor1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Dame el segundo valor");
    valor2 = Convert.ToDouble(Console.ReadLine()); 

    resultado = valor1-valor2;
    Console.WriteLine("el resultado de tu"+operacion+":"+resultado);
}
if(operacion == "multiplicacion"){
    Console.WriteLine("Dame el primer valor");
    valor1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Dame el segundo valor");
    valor2 = Convert.ToDouble(Console.ReadLine()); 

    resultado = valor1*valor2;
    Console.WriteLine("el resultado de tu"+operacion+":"+resultado);
}
