# PATRÓN ESTRATEGIA

## ¿QUE ES EL PATRON ESTRATEGIA?
Es un patrón clasificado como patrón de comportamiento. El objetivo de este patron es definir una familia de algoritmos, encapsular cada uno de elos y hacerlos intercambiables. Estrategia permite cambiar el algoritmo independientemente de los clientes que lo utilicen.

Este patrón encapsula un algoritmo completo ignorando los detalles de su implementación, permitiendo intercambiarlo en tiempo de ejecucion para permitir ctuar a la clase cliente con un comportamiento distinto. 
## ¿Cuando usar el patron estrategia?
Cuando un servicio o funcion determinada puede ser realizada de varias maneras, es candidato de utilizar el patrón estrategia

Si dentro de tu clase haces uso intensivo de las condiciones *if,else,switch,case* eso quiere decir que tu clase tiene asignado muchos comportamientos y/o responsabilidades, lo cual suele ser un indicador de la necesidad de aplicar el patrón Estrategia, para poder encapsular estos comportamientos y delegarlos a otra clase u objeto.

Este patrón también es una alternativa a la herencia, si estás pensando usar la herencia para poder agregar nuevos comportamientos a tus objetosmsería conveniente usar este patrón.

## Estructura y diagrama de clases
![ESTRATEGIA](http://codigolinea.com/wp-content/uploads/2015/03/strategy-uml.png)

## Participantes
* **Estrategia**
	* Declara una interfaz común para todos los algoritmos compatibles. El **CONTEXT** utiliza esta interfaz para llamar al algoritmo definiddo por un **ConcreteStrategy**
* **ConcreteStrategy**
	* Implementa el algoritmo utilizando la interfaz de Strategy
* **Context**
	* Está configurado con un objeto **ConcreteStrategy**
	* Mantiene una referencia a un objeto **Strategy**
	* Puede definir una interfaz que le permita acceder a sus datos **Strategy**

## Ventajas y desventajas
### Ventajas
* Usando la encapsulacion de los algoritmos por separado, los nuevos algoritmos se introducen con facilidad usando la misma interfaz.
* Aplicando el patron estrategia podemos elegir las estrategias en tiempo de ejecución
* Facilitar estrategias a los clientes para elegir el algoritmo requerido, sin usar sentencias *switch* o una serie de sentencias *if...else*.
* La estructura de datos usada para implementar el algoritmo está completamente encapsulado en la clase strategy. Por eso, la implemetación de un algoritmo se puede intercambiar sin afectar a la clase Contexto.
* El mismo objeto estrategia puede ser estrategicamente compartida junto con diferentes objetos contexto. Sin embargo, el objeo estrategiacompartido no debería mantener estados a través de las invocaciones.

### Desventajas
* La aplicacion tiene que ser consciente de todas las estrategias para seleccionar la estrategia concreta para la situación correcta.
* Las clases estrategía y contexto, quizá están estrechamente acopladas. El contexto debe proporcionar los datos relevantes a la estrategia para implementar el algoritmo, y a veces todos los datos que pasan el contexto pueden no ser relevantes para todas las estrategias concretas.
* Las clases Context y las estrategias normalmente se comunican mediante una interfaz especifica, que es una clase base abstracta. La estrategia base debe exponer una interfaz para todos los comportamientos requeridos, que algunas clases estrategia podrían no implementar
* La aplicacion configura el contexto con el objeto de una estrategia requerida. Por lo tanto, la aplicacion necesita para crear y mantener dos objetos en lugar de uno.
* Entonces, el objeto Estrategia es creado por la aplicación en la mayoria de los casos, el contexto no tiene control sobre la vida util del objeto Estrategia. Sin embargo, el contexto puede hacer una copia local del objeto estrategia.Pero, esto aumenta el requisito de memoria y tiene un impacto seguro en el rendimiento


## Conlcusiones 

Al usar este patrón estaremos cumpliendo 2 principios de SOLID que son: el principio de Responsabilidad única y el principio de Abierto y Cerrado, lo cual nos ayudará mucho cuando deseamos extender y/o añadir nuevas funcionalidades a nuestras clases sin mayores dolores de cabeza

## Ejercicio de ejemplo
Imaginemos que tenemos una pequeña tienda virtual permite que nuestros clientes paguen con tarjeta de credito, pero como el negocio va creciendo tenemos que adaptarnos al entorno, así que tenemos que implementar otras formas adicionales de pagos como : deposito en cuenta, pago a traves de telefonos moviles, pago contra entrega, cheque.


**Nota**
> Saber la diferencia entre aplicarlo con métodos abstractos ( y la clase también) o interfaces. También mirar el enlace que me paso Pau.