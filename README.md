# NET-Developer-Challenge

#### Responce lemonway webservice challenge
## Platform Support

|Nuget|Packages|
| ------------------- | :------------------: |
|Log4net 2.0.10|
|Newtonsoft.Json 12.0.3|


<p align="center">
La solution est constitué de trois projets : 
  - LemonwayWebservice ASP.NET SOAP WebService : ce projet est subdivisé en trois répertoire 
       1- La couche Controllers : Expose les web methodes Fibonacci et XmlToJson dans deux services asmx.
       2- La couche Services : Core de l'application résponsable des traitement et das calculs. On y trouve deux interfaces qui peuvent servir à l'injection des dependances dans les tests.   
       3- Models : Contient l'objet, Dto, utilisé pour encapsuler le string XML. cela pour éviter l'erreur 	de sécurité IIS. 

j'ai fixé l'Url du projet dans IIS Express à cette adresse : http://localhost:8089/

      

  - ConsumerApp WinForm Application : L'application cliente qui consome les deux services en mode 		asyncrone.

  - LemonwayWebserviceTest Test Application : Projet de test unitaire. Ou j'appelle dirrectement la couche service pour tester mes web methodes.
   
</p>
