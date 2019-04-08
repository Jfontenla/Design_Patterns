# Patrón de diseño: PROTOTYPE

## DEFINICIÓN
Es un **patrón creacional** con el objetivo de crear nuevos objetos mediante la duplicación de objetos existentes llamados prototipos que disponen de la capacidad de clonación

## ¿Cuando usar el patrón Prototype?
* Un sistema de objetos debe crear instancias sin conocer la jerarquía de clases que las describe.
* un sistema de objetos debe crear instancias de clases dinámicamente.
* el sistema de objetos debe permanecer simple y no incluir una jerarquía paralela de clases de fabricacion.

## Estructura y diagramas de clases

![PROTOTYPE](https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/ProtipoEstructura.png/600px-ProtipoEstructura.png)

## Participantes 
* **Cliente :** es una clase compuesta por un conjunto de objetos llados prototipos, instancias de la clase abstracta Prototype.La clase cliente necesita duplicar estos prototipos sin tener por qué conocer ni la estructura interna del prototype ni su jerarquia de subclases.
* **Prototype:** es una clase abstracta de objetos capaces de duplicarse a sí mismos. Incluye la firma del método "duplica".
* **Prototype Concreto:** son las sublcases concretas de Prototype que definen completamente un prototipop e implementan el método duplica.

## Ventajas e desventajas
### Ventajas

### Desventajas