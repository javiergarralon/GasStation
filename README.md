
<img target="blank"><img align="center" src="https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Bandera_de_Espa%C3%B1a.svg/300px-Bandera_de_Espa%C3%B1a.svg.png" alt="Español" height="15" width="30"/>&nbsp; # Estación de Servicio - Prueba Técnica

Prueba técnica del funcionamiento de los Surtidores en Pista para una Estación de Servicio que consiste en realizar una implementación sencilla de una pista que sea capaz de gobernar los surtidores que en ella se encuentran.


## Uso de principios ### SOLID.

### S *(Single Responsibility Principle): Cada clase e interfaz tiene una única responsabilidad (gestionar surtidores o la pista).*
### O *(Open/Closed Principle): Las clases pueden extenderse sin modificar su código base, lo cual se facilita con el uso de interfaces.*
### L *(Liskov Substitution Principle): Las clases derivadas (como las que implementan interfaces) pueden ser utilizadas sin alterar la funcionalidad esperada.*
### I *(Interface Segregation Principle): Las interfaces están divididas según las responsabilidades específicas de cada entidad.*
### D *(Dependency Inversion Principle): Se depende de abstracciones (interfaces) en lugar de implementaciones concretas.*


## Funcionalidades de la Aplicación

***FreePump - Libera un surtidor, permitiendo suministrar combustible sin restricciones.***
***SetPumpLimit - Prefija un límite de importe para el suministro en un surtidor.***
***BlockPump - Bloquea un surtidor, impidiendo su uso.***
***GetAllPumps - Devuelve una lista con todos los surtidores.***
***GetPump - Devuelve un surtidor específico según su ID.***
***RecordSupply - Registra un suministro en el historial.***
***GetSupplyHistory - Devuelve el historial de suministros, ordenados por importe y fecha.***


## Métodos de Pruebas

Pump_ShouldBeBlockedInitially - Verifica que todos los surtidores están bloqueados al inicio.
FreePump_ShouldSetPumpToFreeState - Prueba que un surtidor pasa al estado libre cuando se libera.
BlockPump_ShouldBlockThePump - Verifica que un surtidor se bloquea correctamente.
SetPumpLimit_ShouldSetTheLimitOnThePump - Asegura que se puede establecer un límite en un surtidor libre.
Dispense_ShouldRecordSupplyAndBlockPump - Comprueba que se registra un suministro y el surtidor se bloquea después.
GetSupplyHistory_ShouldReturnSuppliesOrderedByAmountAndDate - Verifica que el historial de suministros se ordena correctamente por importe y fecha.
