# NET-Developer-Challenge

#### Responce lemonway webservice challenge
## Platform Support

|Nuget|Packages|
| ------------------- | :------------------: |
|Log4net 2.0.10|
|Newtonsoft.Json 12.0.3|


<p>
La solution est constituée de trois projets : 
1- Lemonway Webservice ASP.NET SOAP WebService : ce projet est subdivisé en trois répertoire  
      - La couche Controllers : Expose les web méthodes Fibonacci et XmlToJson dans deux services asmx.  
      - La couche Services : Core de l'application responsable des traitements et des calculs.  
          On y trouve deux interfaces qui peuvent servir à l'injection des dépendances dans les tests. 
      - Models : Contient l'objet, Dto, utilisé pour encapsuler le string XML.  
                 Cela pour éviter l'erreur de sécurité IIS. 

J'ai fixé l'Url du projet dans IIS Express à cette adresse : http://localhost:8089/ 

2- ConsumerApp WinForm Application : L'application cliente qui consomme les deux services en mode asynchrone. 

3- LemonwayWebserviceTest Test Application : Projet de test unitaire. Ou j'appelle directement la couche service pour tester mes web méthodes. 
 
</p>
