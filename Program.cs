
Console.WriteLine("Tipos de metodo!");

//      Sintaxis de un método
//Los metodos contienen un tipo de valor, nombre del metodo y en caso de q asi lo necesiten parametros

//Tipo, nombre, parametros y Cuerpo
void    miMetodo ()         { }



//      Métodos sin parámetros, ni tipo

void ImprimirNombre()
{
    Console.WriteLine("Este metodo solo imprime un texto");
}

//      Invocación de un método sin parámetros, ni tipo
//      Solo se invoca colocando el nombre, seguido de parentesis y con ; al final
ImprimirNombre();










Console.Clear();
//      Métodos que devuelven un tipo

String EsteMetodoDevelveUnString
(
    //  No recibe parametros
)
{
    return "Texto devuelto";
}

Console.WriteLine(EsteMetodoDevelveUnString() + "\n\n\n\n\n");

//      Invocación de un método que devuelve un tipo
//      La invocacion se puede hacer directa o asignando el valor a una variable

String texto = EsteMetodoDevelveUnString() + "\n\n\n\n\n";

Console.WriteLine(texto);

//      Métodos que contienen parámetros, los parametros van dentro de los parentesis
//      Los tipos de datos q recibe el metodo puede ser de todos tipo

void ParametrosDeEsteMetodo
(
    int numero,
    String parametro
)
{
    Console.WriteLine($"Imprime las variables: {numero} y {parametro}");
}

Console.Clear();

//      Invocación de un método con parámetros

ParametrosDeEsteMetodo(45, "Mi nombre es Alex");


Console.Clear();

//      Métodos con parámetros que devuelven un tipo

bool MiMetodoDevuelveUnBoleano(int numero)
{
    return numero > 100;
}

Console.WriteLine(MiMetodoDevuelveUnBoleano(99));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(MiMetodoDevuelveUnBoleano(101));

//      Optimizando con métodos, se pueden utilizar para reducir tareas repetidas o ejecutar
//      accesiones, por ejemplo para mandar mensajes personalizados donde solo cambie el nombre
Console.Clear();
List<String> nombres = new List<String>
{
    "Carla","Marlin","Dana","Dan","Alex","Marco","Benji","Juan","Darla"
};

void MandarAImprimirnombres(List<String> names)
{
    foreach (var nombre in names)
    {
        Console.WriteLine($"Hola como estas {nombre}, bienvenido!!!");
    }
}

MandarAImprimirnombres(nombres);






Console.Clear();

//      Pasar por referencia vs. pasar por valor

int edad = 45;
String nuevovalor = "Darlin";

void MetodoValidaParametroPorValorYPorReferencia(int valor, ref String nuevovalor)
{
    valor = 55;
    nuevovalor = "Merlin";
    Console.WriteLine($"Cambiar valor {valor}, Camiar nuevovalor {nuevovalor}");
}
//El valor q debe cambiar despues de invocar la funcion es nuevovalor, edad no debe cambiar

MetodoValidaParametroPorValorYPorReferencia(edad, ref nuevovalor);

Console.WriteLine($"Cambiar valor {edad}, Camiar nuevovalor {nuevovalor}");
































