# PATRON SINGLETON
Asegura que, en cualquier momento dado, solo una instancia de un objeto está viva y admite la inicializacion perezosa.
## USOS DEL PATRÓN SINGLETON
* Cuando hay que preservar un estado global de un tipo(posibilidad de utilizar variables globales).
* Para compartir datos comunes a traves de la aplicación.
* Para reducir la sobrecarga de instanciar un objeto pesado una y otra vez.
* Adecuado para fachadas y proxies de servicio.
* para almacenar objetos en memoria caché y reutilizarlos en toda la aplicación.
## VENTAJAS Y DESVENTAJAS
### Ventajas
* El patron Singleton se puede implementar interfaces.
* Tambíen puede ser heredado de otras clases.
* Puede usarse la carga perezosa.
* Se puede extender en un patrón de fábrica.
* Ayuda a ocultar dependencias.
* Proporcina un punto único de acceso a una instancia particular, por lo que es mas fácil de mantener.
### Desventajas
* La prueba unitaria es más dificil de comprobar (porque introduce un estado global en una aplicación)
* Este patron reduce el potencial paralelismo dentro de un programa porque para poder acceder al singleton en un sistema de subprocesos múltiples un objeto debe ser serializado(mediante bloqueo)

## PATRÓN SINGLETON VS STATICS METHODS
* Una clase estática no puede extenderse, mientras que una clase singleton puede extenderse.
* Una clase estatíca puede tener instancias (instancias no deseadas) mientras que la singleton lo impide.
* Una clase estática no puede iniciarse con un ESTADO(parámetro), mientras que una clase singleton puede ser inicializada.
* CLR carga automáticamente una clase estática cuando se carga el programa o espacio de nombres que contiene la clase.

## Imagen de ejemplo :
![Sinleton](https://www.tutorialspoint.com/design_pattern/images/singleton_pattern_uml_diagram.jpg)
## PARTICIPANTES
El constructor se tiene que crear privado,y dentro de la clase tiene que haber algun metodo o propiedad pública, desde la que tener acceso desde fuera.
## Ejemplos donde se puede usar el patrón singleton
* **PROXIES DE SERVICIO :**  en una aplicación, invocar un servicio también conocido como API es una operación extensa. Y creando un proceso de cliente en sí mismo que consume mucho tiempo. Al tener un proxy de servicio como Singleton, se puede reducir esta sobrecarga.
* **FACHADAS :** Las conexiones de base de datos son otro ejemplo en el que SINGLETON se puede utilizar para producir un mejor rendimiento y sincronizacización.
* **Registros :**  La E/S es una operacion más pesada, al tener una sola instancia de un registrador, la información requerida se puede escribir en el mismo archivo que los registros.
* **Uso compartido de datos :** los valores de configuracion y cualquier valor constante se pueden mantener en Singleton para que otros componentes de la aplicacion puedan leerlos.
* **Almacenamiento en caché :** la obtención de datos es un proceso que toma tiempo, mientras que el almacenamiento en caché de los datos requeridos en la memoria de la aplicación evita las llamadas de base de datos, 
* y Singleton puede usarse aquí para manejar el almacenamiento caché con sincronizacion de subprocesos de una manera eficiente en comparación con el tipo estático.

## OTRAS FORMAS DE HACER UN SINGLETON
**NOTA**
> hay varios tipos de construcion de singleton, los dejaré por aquí anotados

> Hay muchas formas de implementar un patrón Singleton en C #.
No hay hilo seguro Singleton.
Hilo de seguridad Singleton.
Hilo de seguridad Singleton utilizando doble comprobación de bloqueo.
Singleton seguro para subprocesos sin utilizar bloqueos y sin instanciación perezosa.
Totalización perezosa de la instanciación.
Usando el tipo perezoso <T> de .NET 4.

[C# corner](https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/)
## Ejercicios :

