# PATRONES DE DISEÑO : ABSTRACT FACTORY

Nos permite crear, mediante una interfaz, conjuntos o familias de objetos que dependen mutuamente y todo esto sin especificar cual es el objeto en concreto.

## USOS DEL PATRÓN ABSTRACT FACTORY
Este patrón se puede aplicar cuando:
 * Un sistema debe ser independiente de como sus objetos son creados
 * Un sistema debe ser  'configurado' con una cierta familia de productos
 * Se necesita reforzar la noción de dependencia mutua entre ciertos objetos
 * Se quiere proporcionar una biblioteca de clases de productos y sólo se quiere revelar sus interfaces, no sus implementaciones

## VENTAJAS Y DESVENTAJAS
* '+' Brinda flexibilidad al aislar a las clases concretas
* '+' Facilita cambiar las familias de productos
* '+' Promueve la consistencia entre productos
* '-' Para agregar nuevos productos se deben modificar tanto las fabricas abstractas como las concretas

## Imagen de ejemplo :
![Abstract Factory](https://juanlucodingbinding.files.wordpress.com/2017/09/fm61.jpg)

Ejemplo sacado de [Juanlu Coding and Binding](https://juanlucodingbinding.wordpress.com/2017/09/11/abstract-factory-vs-factory-method-c/)

## Ejemplo de un patrón Abstract Factory
Teniendo en cuenta la siguiente jerarquía de clases, la cual trata de representar muy por arriba dos familias de productos (Coche Electrico, Coche Combustible(gasolina y diesel), Coche a Gas)

