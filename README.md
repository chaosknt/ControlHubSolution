# ControlHubSolution

## Requerimientos:

Fibonacci Rest API
Scenario: There is a need for a Rest (or Rest-like) API that can receive an index "n" and returns the Fibonacci value that corresponds to the given index, and you have been tasked with implementing the first version of this API.

Examples: the first values of the Fibonacci sequence are 0, 1, 1, 2, 3, 5, 8, 13, ..., so, if we were to give the API the index n=3, we should get the response value "2", and if we request n=6, we should get "8" as the response, and so on.

Please deliver to us your API as a link to a repo (Gitlab, Github, etc...) with your code and a README file (plaintext or markdown).

The code project can be developed in the programming language of your choice.

The README file is for you to describe your thought process. You can document: technical decisions that you made, what optimizations you could add in the future to improve upon your initial solution, and anything else you would like to add for us to get a better understanding of your engineering thinking.


## A cerca del proyecto

El proyecto se desarrolló utilizando .NET Core v5.1 y sigue una arquitectura orientada a servicios (SOA), que consta de las siguientes capas:

<ol>
  <li>Presentation: REST API</li>
  <li>Aplication: Casos de usos</li>
  <li>Entities: Capa en donde se guardan las entidades y dtos del sistema,en este caso dto para el request</li>
  <li>Testing: Capa en donde se testean los casos de uso</li>
</ol>

Esta estructura de capas sigue una arquitectura bien organizada que promueve la separación de preocupaciones y la escalabilidad del proyecto. Cada capa tiene su responsabilidad específica, lo que facilita el desarrollo, la depuración y el mantenimiento del software.

Aunque el requisito es bastante simple, opté por organizarlo en capas para mantener un mayor orden y control en el proyecto, siguiendo los principios SOLID de diseño de software. Para abordar el caso de uso de Fibonacci, creé una interfaz que configuré como Scoped en el archivo Startup, y luego la inyecté a través de la inyección de dependencias en el controlador encargado de manejar la solicitud. Esta decisión se tomó con el objetivo de reducir el acoplamiento entre clases y facilitar la mantenibilidad del código, siguiendo el principio de Responsabilidad Única (Single Responsibility Principle) al separar las responsabilidades de cálculo de Fibonacci y controlador de API.

Actualmente, estoy versionando tanto la API como los DTOs utilizados en caso de que en el futuro se necesite realizar cambios críticos, siguiendo el principio de Abierto/Cerrado (Open/Closed Principle) al permitir extensiones sin modificar el código existente. Cualquier modificación se implementaría en una versión 2, dejando la versión 1 intacta, para seguir el principio de Interfaz Segregación (Interface Segregation Principle) y no forzar a los consumidores de la API a depender de funcionalidades innecesarias.

Si el proyecto continúa creciendo y se vuelve más complejo, consideraría la implementación del patrón Mediator a través de la interfaz IMediator, lo que seguiría el principio de Inversión de Dependencia (Dependency Inversion Principle) al reducir las dependencias directas entre componentes del sistema. En caso de que sea necesario acceder a una base de datos, también evaluaría la implementación del patrón CQRS para ese propósito, lo que seguiría los principios SOLID al separar las operaciones de lectura y escritura de manera eficiente.

Además, en el futuro, consideraría la implementación de Elasticsearch junto con Kibana en el ecosistema del proyecto. Esto podría ser especialmente valioso en casos donde se espera un crecimiento significativo de datos o cuando se necesita una búsqueda y análisis avanzados de registros de registros y eventos

Por último, es importante considerar que si el proyecto experimenta un crecimiento considerable, puede ser valioso evaluar la migración hacia una arquitectura basada en microservicios. Esta decisión podría aportar numerosos beneficios para la escalabilidad y la administración del sistema.

## Manejo de ramas

Debido a la simplicidad del requisito, opté por trabajar directamente en la rama principal (main). Sin embargo, en entornos de trabajo colaborativo, mi enfoque habitual es crear una nueva rama a partir de la rama principal (ya sea "master" o "development", según corresponda), realizar el trabajo en esa rama y luego efectuar el commit. En este proceso, suelo seguir la metodología de "conventional commits" para mantener un registro claro y estructurado de los cambios realizados.
