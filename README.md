<img align="center" src="https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Flag_of_the_United_Kingdom_%283-5%29.svg/240px-Flag_of_the_United_Kingdom_%283-5%29.svg.png" alt="EN" height="15" width="25"/>&nbsp;<img align="center" src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/Flag_of_the_United_States.svg/300px-Flag_of_the_United_States.svg.png" alt="US" height="15" width="25"/>
# Gas Station - Technical Test 

A technical test of the operation of Pumps on the Track for a Gas Station, consisting of a simple implementation of a track that can manage the pumps located within it.



## Use of SOLID Principles

**S (Single Responsibility Principle)**: *Each class and interface has a single responsibility (managing pumps or the station).*

**O (Open/Closed Principle)**: *Classes can be extended without modifying their base code, facilitated by the use of interfaces.*

**L (Liskov Substitution Principle)**: *Derived classes (such as those implementing interfaces) can be used without altering the expected functionality.*

**I (Interface Segregation Principle)**: *Interfaces are divided according to the specific responsibilities of each entity.*

**D (Dependency Inversion Principle)**: *Dependency is on abstractions (interfaces) rather than concrete implementations.*



## Application Functionalities

**FreePump** - *Frees a pump, allowing fuel supply without restrictions.*

**SetPumpLimit** - *Sets a limit amount for the supply on a pump.*

**BlockPump** - *Blocks a pump, preventing its use.*

**GetAllPumps** - *Returns a list of all pumps.*

**GetPump** - *Returns a specific pump by its ID.*

**RecordSupply** - *Records a supply in the history.*

**GetSupplyHistory** - *Returns the supply history, ordered by amount and date.*



## Test Methods

**Pump_ShouldBeBlockedInitially** - *Verifies that all pumps are blocked initially.*

**FreePump_ShouldSetPumpToFreeState** - *Tests that a pump changes to free state when released.*

**BlockPump_ShouldBlockThePump** - *Verifies that a pump is correctly blocked.*

**SetPumpLimit_ShouldSetTheLimitOnThePump** - *Ensures that a limit can be set on a free pump.*

**Dispense_ShouldRecordSupplyAndBlockPump** - *Checks that a supply is recorded and the pump is blocked afterward.*

**GetSupplyHistory_ShouldReturnSuppliesOrderedByAmountAndDate** - *Verifies that the supply history is correctly ordered by amount and date.*







<img align="center" src="https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Bandera_de_Espa%C3%B1a.svg/300px-Bandera_de_Espa%C3%B1a.svg.png" alt="ES" height="15" width="25"/>&nbsp; 
# Estación de Servicio - Prueba Técnica

Prueba técnica del funcionamiento de los Surtidores en Pista para una Estación de Servicio que consiste en realizar una implementación sencilla de una pista que sea capaz de gobernar los surtidores que en ella se encuentran.



## Uso de principios SOLID.

**S (Single Responsibility Principle)**: *Cada clase e interfaz tiene una única responsabilidad (gestionar surtidores o la pista).*

**O (Open/Closed Principle)**: *Las clases pueden extenderse sin modificar su código base, lo cual se facilita con el uso de interfaces.*

**L (Liskov Substitution Principle)**: *Las clases derivadas (como las que implementan interfaces) pueden ser utilizadas sin alterar la funcionalidad esperada.*

**I (Interface Segregation Principle)**: *Las interfaces están divididas según las responsabilidades específicas de cada entidad.*

**D (Dependency Inversion Principle)**: *Se depende de abstracciones (interfaces) en lugar de implementaciones concretas.*



## Funcionalidades de la Aplicación

**FreePump** - *Libera un surtidor, permitiendo suministrar combustible sin restricciones.*

**SetPumpLimit** - *Prefija un límite de importe para el suministro en un surtidor.*

**BlockPump** - *Bloquea un surtidor, impidiendo su uso.*

**GetAllPumps** - *Devuelve una lista con todos los surtidores.*

**GetPump** - *Devuelve un surtidor específico según su ID.*

**RecordSupply** - *Registra un suministro en el historial.*

**GetSupplyHistory** - *Devuelve el historial de suministros, ordenados por importe y fecha.*



## Métodos de Pruebas

**Pump_ShouldBeBlockedInitially** - *Verifica que todos los surtidores están bloqueados al inicio.*

***FreePump_ShouldSetPumpToFreeState** - *Prueba que un surtidor pasa al estado libre cuando se libera.*

**BlockPump_ShouldBlockThePump** - *Verifica que un surtidor se bloquea correctamente.*

**SetPumpLimit_ShouldSetTheLimitOnThePump** - *Asegura que se puede establecer un límite en un surtidor libre.*

**Dispense_ShouldRecordSupplyAndBlockPump** - *Comprueba que se registra un suministro y el surtidor se bloquea después.*

**GetSupplyHistory_ShouldReturnSuppliesOrderedByAmountAndDate** - *Verifica que el historial de suministros se ordena correctamente por importe y fecha.*
