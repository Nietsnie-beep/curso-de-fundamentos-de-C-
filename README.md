# c#

#### Tags

#### Curso y anotaciones del curso de c#

## Primer Programa

```
using System;
namespace HelloWorldPlatzi
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Hello Platzi! :P");
}
}
}
```
#### ¿Cómo funcionan los Namespaces en C#?

#### Namespace : Tiene que representar algo significativo para el programa, con un

#### nombre único. Cada Namespace puede tener diferentes clases, tantas como

#### requiera el programa.

#### Clases : Las clases son plantillas para crear entidades, tantas como se requiera.

#### Cada clase puede tener diferentes métodos.

#### Métodos : La forma o manera de ejecutar funcionalidades del programa.



## Variables y conversiones

## 🔐

#### var no define el tipo de dato

```
Console.WriteLine("What your name!");
//var fullUserName = Console.ReadLine();
string fullUserName = Console.ReadLine();
Console.WriteLine("hello " + fullUserName + " Welcome to Home");
int number1;
int number2;
//flotantes
```

```
float sideA = 10.2f;
Console.WriteLine("Input the first number");
number1 = Convert.ToInt32(Console.ReadLine()); //convierte el string a int
Console.WriteLine("Input the second number");
number2 = Convert.ToInt32(Console.ReadLine()); //convierte el string a int
int result = number1 * number2;
Console.WriteLine("The Result Is: " + result);
```
## Operadores logicos

```
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores Logicos");
bool value1 = true;
bool value2 = true;
bool value3 = false;
bool result = value1 && value2 && value3;
Console.WriteLine("The result of logical AND is: " + result);
bool result2 = value1 || value2 || value3;
Console.WriteLine("The result of logical OR is: " + result2);
bool result3 = !value1; //es verdadero?
Console.WriteLine("The result of logical! is: " + result3);
```
## Inputs

```
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Interactivo");
Console.WriteLine("Ingresa un numero");
float sideA = float.Parse(Console.ReadLine());
float b = 2;
Console.WriteLine(sideA + b);
```

## Métodos o funciones en c#

#### Un  método  es un bloque de código que contiene varias instrucciones que podemos

#### ejecutar las veces que necesitemos. Son de gran ayuda cuando tienes que hacer lo

#### mismo varias veces en un mismo programa para no repetir el mismo código una y otra

#### vez.

## Métodos de strings

```
using System;
publicclassProgram
{
publicstaticvoidMain()
{
string ClassTopic = "Métodos de strings";
string School = "Platzi";
Console.WriteLine("Estoy aprendiendo de "+ ClassTopic + " en " + School + ".");
}
}
```
#### En la pieza de código anterior puedes ver un pequeño programa con dos variables tipo

#### string y su impresión. Para este tipo de variables podemos usar una gran cantidad de

#### métodos predefinidos dentro de la biblioteca estándar de C#.

#### Utilicemos estas dos variables strings para conocer algunos de ellos.

### Clone()

```
stringSchoolClone=School.Clone().ToString();
Console.WriteLine(SchoolClone);
```

#### El método Clone() crea un clon exacto de un string en una variable de tipo objeto. Por

#### ello es necesario convertirlo a string utilizando ToString().

### CompareTo()

```
Console.WriteLine(ClassTopic.CompareTo(School));
Console.WriteLine(School.CompareTo(SchoolClone));
```
#### Sirve para comparar el contenido de dos strings. Si son iguales devuelve 0 para true y

#### si son diferentes retorna 1 para false. En este caso como School y SchoolClone son

#### strings idénticos devolverá un 0. ¿Qué crees que se imprima en la primera línea?

### Contains()

```
Console.WriteLine(School.Contains("Pla"));
```
#### Retorna True si el string contiene los caracteres que se pongan en los argumentos del

#### método.

### EndsWith()

```
Console.WriteLine(School.EndsWith("zi"));
```
#### Similar a Contains(), pero para comparar si los caracteres están al final del string.

### StartsWith()

```
Console.WriteLine(School.StartsWith("Pl"));
```
#### Funciona de la misma manera que EndsWith(), pero en este caso comprueba si

#### empieza con una serie de caracteres indicados.

### Equals()

```
Console.WriteLine(School.Equals(SchoolClone));
```

#### Funciona de forma parecida a CompareTo(), pero para indicar si el contenido de ambos

#### strings retorna True o False.

### IndexOf()

```
Console.WriteLine(School.IndexOf("a"));
```
#### Regresa la posición dentro del string del carácter indicado en el argumento.

### ToLower() y ToUpper()

```
Console.WriteLine(ClassTopic.ToLower());
Console.WriteLine(ClassTopic.ToUpper());
```
#### Convierten el string en todas letras minúsculas o mayúsculas.

### Insert()

```
Console.WriteLine(School.Insert(6," es educación online efectiva"));
```
#### Inserta un nuevo string dentro de otro en la posición indicada dentro de los argumentos.

#### En este caso es en 6 que es la posición después de la última letra de “Platzi”.

### LastIndexOf()

```
Console.WriteLine(ClassTopic.LastIndexOf("s"));
```
#### Regresa la posición de la última vez que aparece el carácter. En este caso la letra “s”

#### aparece varias veces en el string y así podemos notar cómo devuelve la última posición

#### en la que aparece.

### Remove()


```
Console.WriteLine(ClassTopic.Remove(6));
```
#### Elimina los caracteres del string a partir de la posición que le indiquemos hasta el final.

### Replace()

```
Console.WriteLine(ClassTopic.Replace("s", "z"));
```
#### Reemplaza todos los caracteres por otro indicado. En este caso todas las “s” serán

#### cambiadas por “z”.

### Split()

```
string[]split = ClassTopic.Split(new char[] { 's' });
Console.WriteLine(split[0]);
Console.WriteLine(split[1]);
Console.WriteLine(split[2]);
```
#### Este es un caso especial donde creamos un nuevo string donde guardamos el string

#### separado en trozos por la letra indicada en los argumentos del método. Para este caso

#### se separa por la letra “s” en 3 trozos que son los que imprimimos.

### Substring()

```
Console.WriteLine(ClassTopic.Substring(2,10));
```
#### Devuelve un substring o trozo de string de acuerdo a las posiciones indicadas en los

#### argumentos.

### ToCharArray()

```
School.ToCharArray();
```
#### Convierte el string en un arreglo de caracteres.


### Trim()

```
string TextWithSpaces = " hola, había espacios al principio y al final ";
Console.WriteLine(TextWithSpaces.Trim());
```
#### Elimina espacios al principio y al final de un string.


