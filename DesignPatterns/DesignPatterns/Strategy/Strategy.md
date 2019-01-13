# PATRÓN ESTRATEGIA

## ¿QUE ES EL PATRON ESTRATEGIA?
	Es un patrón clasificado como patrón de comportamiento. El objetivo de este patron es definir una familia de algoritmos, encapsular cada uno de elos y hacerlos intercambiables. Estrategia permite cambiar el algoritmo independientemente de los clientes que lo utilicen.
	Este patrón encapsula un algoritmo completo ignorando los detalles de su implementación, permitiendo intercambiarlo en tiempo de ejecucion para permitir ctuar a la clase cliente con un comportamiento distinto. 
## ¿Cuando usar el patron estrategi?
	Cuando un servicio o funcion determinada puede ser realizada de varias maneras, es candidato de utilizar el patrón estrategia

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