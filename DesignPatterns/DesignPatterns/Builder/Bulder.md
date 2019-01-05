# PATRÓN DE DISEÑO: BUILDER

## ¿QUE ES EL PATRON BUILDER?
Es un **patrón creacional** que propone separar la **creación** de la **representación** de un objeto complejo. Realizando esta separación el proceso de construcción puede crear diferentes representaciones.

## ¿Cuando usar el patron builder?
Cuando necesitemos construir un mismo objeto complejo muchas veces y además con diferentes configuraciones.

**Dudas de cuando usar el patrón builder**
>**Truco** Fijarnos en el numero de parametros que se necesitan. Si son cuatro o más podría ser interesante

## Estructura y diagrama de clases
![BUILDER](https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Builder_UML_class_diagram.svg/1280px-Builder_UML_class_diagram.svg.png)

## Participantes

* **Builder**
  * Clase abstracta para crear los objetos finales producto
* **Builder concreto** 
  * Selecciona un nombre que defina la representacion del objeto a crear
  * Implementa una clase abastracta Builder
  * Construye y ensambla las partes del producto
* **Directior** 
  * Construye un objeto pasando por la clase Builder
* **Producto**
  * Representa el objeto complejo en construcción. El Constructor concreto construye la representacion interna del producto y define el processo de ensamblaje
  * Incluye las clases que definen sus partes constituyentes, incluyendo interfaces para ensamblar partes en el resultado final

## Ventajas e inconvenientes 
### Ventajas
* **Permite variar la representacion interna de un producto** 
* **Encapsula el código e¡de construcción y representación**
* **Proporciona un control más explícito sobre el proceso de construccion**
* **El código es mas mantenible si el número de parametros para crear es mayor de 4**

### Desventajas
* Hay que crear un BuilderConcreto para cada representacion de un producto,**lo que puede acabar con multitud de clases**
* **Las clases productos que construye el Builder deben ser mutables**
* **No garantiza que los campos de la clase producto estén inicializados** ya que los builder de los productos son mutables, se necesita un constructor vacío, y eso hace que no tengan por que estar inicializadas las propiedades del producto(solucionar con excepciones)
* **No es muy compatible con la inyeccion de dependencias**. _OJO ESTO NO TIENE POR QUE SER ASI_
* **Requiere emplear mas codigo de lo que sería deseable** Se dará el caso si el Producto final tiene muchas propiedades, es posible que acabes duplicando parte del código. No todos los builders necesitarán aplicar cada uno de los pasos.
* **Aplicado al pie de la letra el patron está "acoplado temporalmente"**
