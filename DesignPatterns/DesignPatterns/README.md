# PATRONES DE DISEÑO

Este proyecto solo consiste en una serie de ejemplos agrupados por carpetas para entender como fuciona cada patron de diseño \n

Cada ejemplo de cada patrón se pondrá en distintas carpetas.
> Dentro de cada carpeta puede haber un archivo .md explicando un poco el ejemplo y en que consiste y por que se llega a cada una de las soluciones



> Mientras que el archivo Readme o otro que este en la carpeta raíz nos valdrá para hacer un resumen de cada uno de los patrones

## PRINCIPIOS DE LOS PATRONES DE DISEÑO
> REPASAR LOS APUNTES DE LA CARRERA

## ¿Qué son los patrones de diseño?

**Un patrón de diseño es una forma reutilizable de resolver un problema común**

_Por muy específico que sea un problema al que estés enfrentando durante el desarrollo de software, __seguramente alguien se ha enfrentado a un problema similar___

### ¿Por que son útiles los patrones de diseño?

* **TE AHORRAN TIEMPO** : El desarrollo de software es un proceso casi artístico, un reto mental que revierte una satisfacción personal enorme una vez que consigues un buen resultado. Buscar siempre una nueva solución a los mismos problemas **REDUCE TU EFICIENCIA** como desarrollador, por que estamos perdiendo mucho tiempo en el proceso. El desarrollo de software es una ingeniería, y como tal en muchas ocasiones habrá reglas comunes para solucionar problemas comunes. **Los patrones de diseño son "trucos" que te permitirán solucionar la mayor parte de tus problemas de forma directa**
* **AYUDAN A ESTAR SEGUROS DE LA VALIDEZ DEL CÓDIGO** : **Los patrones de diseño son estructuras probadas por millones de desarrolladores a lo largo de muchos años**, por lo que si eliges bien el patrón adecuado para modelar el problema adecuado, puedes estar seguro de que va a ser una de las soluciones más validadas (si no la que más) que puedas encontrar.
* **ESTABLECEN UN LENGUAJE COMÚN** : Modelar tu código mediante patrones **te ayudará a explicar a otras personas a entender como has atajado el problema**. Además ayudan a otros desarrolladores a comprender lo que has implementado, cómo y por qué y además a descrubir rápidamente si esa era la mejor solución o no.**Los patrones de diseño ayuda a los equipos a avanzar mucho más rápido, con un código más fácil de entender para todos y mucho mas robusto.**
### ¿Como identificamos que un patrón encaja?
**SE APRENDE PRACTICANDO**. Necesitarás conocer que tipo de problemas soluciona cada uno y descubrir cómo aplicarlo a casos concretos.

## Clasificación de los patrones de diseño
Los patrones de diseño se pueden dividir en distintos grupos, según el tipo de problemas que resuelven.

### Patrones Creacionales
**Facilita la tarea de creación de nuevos objetos** desacoplandolos de la implementación del resto del sistema

Estos patrones están basados en dos concpetos:
1. Encapsular el conocimiento acerca de los tipos concretos que nuestro sistema utiliza. Estos patrones normalmente trabajan con interfaces, por lo que la implementación concreta que utilicemos queda totalmente aislada.
2. Ocultar como estas implementaciones concretas necesitan ser creadas y cómo se combinan entre si

#### Listado de patrones creacionales (más conocidos):
1. **Abstract Factory**
2. **Factory Method**
3. **Builder**
4. **Fluent Builder**
4. **Singleton**
5. **Prototype**

### Patrones Estructurales
Estos nos facilitan la modelización de softwre, especificando la forma en que unas clases se relacionan con otras.

#### Listado de patrones estructurales (más conocidos):
1. **Adapter**
2. **Bride**
3. **Composite**
4. **Decorator**
5. **Facade**
6. **Flyweight**
7. **Proxy**

## Patrones de Comportamiento
El grupo de patrones de diseño mas grande, en el que se encuentran la mayoria de los patrones que se usan para gestionar algoritmos, relaciones y responsabilidades entre objetos.


#### Listado de patrones de comportamiento (más conocidos):

1.  **Command**
2.  **Chain of responsability**
3.  **Interpreter**
4.  **Iterator**
5.  **Mediator**
6.  **Memento**
7.  **Observer**
8.  **State**
9.  **Strategy**
10. **Template Method**
11. **Visitor** 

> ver donde incluimos el **LAZY LOADING*

> Estudiar los principios DRY,YAGNI Y KISS
 

Dudas consultar [devExperto patrones de diseño](https://devexperto.com/patrones-de-diseno-software/)

## Otros detalles a tener en cuenta
> Este apartado lo creo para ir poniendo otros apartados que si que 
> vendría bien repasar, dejar anotaciones para mirarlas mas adelante o crear una explicación / apartado para entender más rapido lo que se explica aqui

### Moficadores de clase
###  Incluir en cada uno de los patrones un diagrama de secuencia