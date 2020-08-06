# The National Bank

## LAYER ARCHITECTURE

## Project name : prjWin_MVC_NationalBank_SqlServer_Rm

Winter - 2017


## Description

In this project we will develop a Bank Application able to make Deposit, Withdraw and Consult. The app will be handle by an admin to administrate directors, agencies, customers, the diferent accounts and reports. The app will includ concepts of Object Oriented Programming, concepts of layer architecture, database with Sql Server and relationship between classes in C # .NET.


### This project focuses on layer architecture.

![Layers Entity](/img/layersEntity.JPG "Layers Entity")


### Problem

A bank has several agencies spread over the Quebec territory. A bank is characterized by the name of its director, 
its global capital, its own name and the address of its head office.


### Class Diagram Developed:

With C# and Visual Studio the class diagram is implemented.

![Class Diagram Developed](/img/Class_Diagram_StrategyPattern.jpg "Class Diagram Developed")


### Prerequisites

 * Microsoft Visual Studio Community 2015 Version 14.0.25425.01 Update 3
 * Programming language : C#.
 * Object Oriented Programming.
 * SQL server Management Studio v17.9.
 * Programming language : SQL Server.
 * MVC Concepts.
 
 
#### Videos
 
 * [C5/ Arquitectura en Capas/ Análisis completo (conceptos,principios,modelos,...)/Ejemplo C#- DIP-DDD](https://www.youtube.com/watch?v=SGXR0pDCP38&t=2464s)
 * [Dashboard / Sumario - NCapas SQL C# (POO)](https://www.youtube.com/watch?v=PmgSBN7xnzM&list=PLqjdFmR_HdQQaB7W6NWj9Mtdl3QvQn2oA)
 * [SQL Server connection](https://www.youtube.com/watch?v=OdDkFPO_nto)
 * [Curso de Git y Github : 1 - 15](https://www.youtube.com/watch?v=j8CSUPIB8mA)
 
 
## Installation

### Download and install. 

 * [Install Visual Studio](https://visualstudio.microsoft.com/)
 * [Install SQL Server](https://www.microsoft.com/en-ca/sql-server/sql-server-downloads)
 * [Dowland the Layer Architecture NationalBank SqlServer project](https://github.com/RicardoAMendoza/LayerArchitecture_Cs_NationalBank_SqlServer)
 
 
### Create the database with SQl server. 

1.- Create the data base : open SQL Server Management Studio, open a new query and run SqlServer/1_init_DataBase.sql

[LayerArchitecture_Cs_NationalBank_SqlServer/SqlServer/1_init_DataBase.sql](https://github.com/RicardoAMendoza/LayerArchitecture_Cs_NationalBank_SqlServer/blob/master/SqlServer/1_init_DataBase.sql)

2.- Create the Stored Procedures : run SqlServer/2_create_StoredProcedures.sql

[LayerArchitecture_Cs_NationalBank_SqlServer/SqlServer/2_create_StoredProcedures.sql](https://github.com/RicardoAMendoza/LayerArchitecture_Cs_NationalBank_SqlServer/blob/master/SqlServer/2_create_StoredProcedures.sql)

3.- Fill up the tables : run SqlServer/3_fill_Tables.sql

[LayerArchitecture_Cs_NationalBank_SqlServer/SqlServer/3_fill_Tables.sql](https://github.com/RicardoAMendoza/LayerArchitecture_Cs_NationalBank_SqlServer/blob/master/SqlServer/3_fill_Tables.sql)

4.- Create Views : run SqlServer/4_create_Views.sql

[LayerArchitecture_Cs_NationalBank_SqlServer/SqlServer/4_create_Views.sql](https://github.com/RicardoAMendoza/LayerArchitecture_Cs_NationalBank_SqlServer/blob/master/SqlServer/4_create_Views.sql)

5.- The class clsConnection connects the SQL Server and the Visual Studio.

```
static private string stringConnection = "Data Source = .; DataBase = bd_NationalBank; Integrated Security = true";
```


### Data Base Diagram.

![DataBaseDiagram](/img/databaseDiagrame.jpg "DataBaseDiagram")


## Author

* **Ricardo Mendoza -  Programmer Analyst**
 
 
## Running the tests
 
 
## Built With

* [Microsoft Visual Studio Community 2015 Version 14.0.25425.01 Update 3](https://visualstudio.microsoft.com/)
* [SQL server Management Studio v17.9.](https://www.microsoft.com/en-ca/sql-server/sql-server-downloads)


## Versions and source manager. 

This project uses GitHub.com as source manager in the following repository:

https://github.com/RicardoAMendoza/The_NationalBank_Rm


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

- Copyright Ricardo Mendoza
- the MIT License (MIT)


## Acknowledgments

* [Andy Del Risco](https://www.linkedin.com/in/andydelriscomanzanares/) - MENTOR, *Technicien Informatique Cl. Principale* [École des métiers de l’aérospatiale de Montréal](http://ecole-metiers-aerospatiale.csdm.ca/)
* [Fernand Tonye](https://www.linkedin.com/in/fernand-tonye-6a46532b/) - MENTOR, *Chief d'Equipe Informatique pour les enseignants* [Institut Teccart](http://www.teccart.qc.ca/)
* [Charles Vilaisak](https://www.linkedin.com/in/cvilaisak/) - MENTOR, *Registraire à l'École nationale de cirque* [École nationale de cirque](https://www.linkedin.com/school/-cole-nationale-de-cirque/)
* RJ Code Advance - Arquitectura en Capas
* Derek Banas - SQL Server and Visual Studio Installation
* [Institut Teccart](http://www.teccart.qc.ca/)



## Concepts.

## 002 WCF.

### Internet

### Types de contrat utilisés par des services WCF  =  Windows Communication Foundation. 
 
* [What Is Windows Communication Foundation](https://docs.microsoft.com/en-us/dotnet/framework/wcf/whats-wcf)
* [Designing Service Contracts](https://docs.microsoft.com/en-us/dotnet/framework/wcf/designing-service-contracts)
* [Contracts](https://docs.microsoft.com/en-us/dotnet/framework/wcf/feature-details/contracts)


#### 1- défini chaque opération: une méthode |attribut =  OperationContractAttribute

* [OperationContractAttribute Class](https://docs.microsoft.com/en-us/dotnet/api/system.servicemodel.operationcontractattribute?view=dotnet-plat-ext-3.1)


#### 2- créer un contrat de service en groupant les opérations: une interface ou une classe| attribut = ServiceContractAttribute
#### interface recommandée car 
#####	- elles modèlent directement des contrats de service
#####	- peuvent étendre d'autres interfaces de contrats de service
#####	- les classes managées –> non l'héritage multiple –> 1 contrat à la fois
	
* [ServiceContractAttribute Class](https://docs.microsoft.com/en-us/dotnet/api/system.servicemodel.servicecontractattribute?view=dotnet-plat-ext-3.1)


### Paramètres et valeurs de retour.
#### chaque opération a 1 paramètre + valeur de retour , même un void
#### les objets ne sont pas passés par références –> passés par copies
#### chaque type utilisé dans 1 paramètre ou valeur de retour doit être sérialisable
#### sérialisable –> objet convertible en un flux d'octets et vice versa


### Contrat de données
#### décrit les données échangées par les opérations de service
#### Conception faite pour interagir avec le plus grand nb possible d'applications client
#### attributs: DataContractAttribute et DataMemberAttribute
#### a un style abonnement
##### aucun type ou membre de données est sérialisé
##### sauf si ses attributs sont explicitement appliqués
#### autres attributs possibles
##### utilise des messages SOAP pour transporter les données d'une apps à une autre
##### ISerializable | SerializableAttribute | IXmlSerializable


### Mappage des paramètres et des valeurs de retour aux échanges de messages.
#### utilise des messages SOAP.
#### 3 modèles possibles.
##### demande/réponse: échange de message par défaut | string Hello(string greeting)
##### unidirectionnel:  n'attend pas que l'opération se termine | void Hello( string X )
##### duplex
###### - service et client s'envoient des messages l'un à l'autre
###### - bidirectionnelle et asynchrone | CallbackContract


### Paramètres in |Out | Ref.
#### in.
#### Out et Ref -> données retournées à partir d'une opération.
* [Passing an argument by reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref)
* [Variables por valor o por referencia](https://csharp.com.es/variables-por-valor-o-por-referencia/)


### Niveau de protection des messages sur un contrat
#### valeurs possibles spécifiant si les messages sont
##### signés 
##### signés et chiffrés | GetString | GetGuide | valeurs par défaut des messages
##### sans signature ou chiffrement | GetInt
#### Ex: Public Interface IExplicitProtectionLevelSampleService


### Résumée
#### Service Contract | Data Contract | Message Contract | Fault Contract




* [Liens utiles :](http://www.indiabix.com/technical/dotnet/)

* [TODO :  WCF](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/ )










