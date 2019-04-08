# PATRÓN DE DISEÑO : FACTORY METHOD

## ¿QUE ES EL PATRÓN FACTORY METHOD?
Es un **patrón creacional** cuyo objetivo es proveer un método abstracto de creación de un objeto delegando en las subclases su creación efectiva.

## ¿Cuando usar el partrón factory method?
*	Una clase solo conoce los objetos con los que tiene relaciones
*	Una clase quiere transmitir a sus subclases las elecciones de instanciación aprovechando un mecanismo de polimorfismo.

## Estructura y diagrama de clases
![FACTORY METHOD](https://upload.wikimedia.org/wikipedia/commons/thumb/8/8e/Factory_Method_UML_class_diagram.svg/800px-Factory_Method_UML_class_diagram.svg.png)

## Participantes
*	**Creador abstracto :** es una clase absracta que implemena la firma del meodo de fabricación y los métodos que invocan al método de fabricación.
*	**Creador concreto :** es una clase concreta que implemena el método de fabricación. Pueden existir varios creadores concretos.
*	**Producto abstracto :** es una clase abstracta que dscribe las propiedades comunes de los productos.
*	**Producto concreto :** es una clase concreta que describe completamente un producto.

## Ventajas e inconvenientes
### Ventajas

### Desventajas