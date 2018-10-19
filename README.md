# ExamenObjetos
## Examen orientacion a objetos
Andrea García Bravo  
19/10/2018

url: https://github.com/Andrea-Miin/ExamenObjetos

## 1.
Para poder interactual con la clase abstracta Foo sin modificarla, hacemos otra clase que herede de Foo.  
Una vez hecho, ya se puede usar Name de Foo.  
Creamos una variable foo y le decimos que mientras el dato que recoja por pantalla no sea exit, permita introducir un nuevo nombre y muestra el anterior.

## 2.
Creo un enumerado para guardar los colores.  
Luego, creo un clase Figura que tiene Name y Color. Color lo recoge del enumerable.  
Por ultimo, tres clases (Rectangulo, Circulo y Flecha) que heredan de Figura.

## 3.
Ya tengo creadas las clases del ejercicio anterior.  
Creo una interfaz IShape con un metodo Draw, con el que a traves de un delegado escribe en consola la figura y su color.  
En la clase Figura se le agrega herencia de IShape para poder coger y heredar Draw.  
En la parte principal del programa, creo una lista con los objetos que quiero imprimir.  
Para terminar, con un foreach recorre la lista y escribe por pantalla el texto de Draw.
### ¿Qué técnica de la orientación a objetos crees que estás utilizando?
Al crear una entidad, que hereda de una interfaz, y que es heredada de varias clases, estoy usando polimorfismo.

## 4.
Para poder liberar recursos debo hacer que la clase Figura herede de IDisposable, y asi poder usar el metodo Dispose().

## 5.
Cumple el principio I: Principio de segregación de la interfaz.  
Que dice "muchas interfaces clientes especificas son mejores que una interfaz de proposito general".    
No incumple ninguna.

