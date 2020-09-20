# NET-Developer-Challenge

#### Responce webservice challenge

|Nuget|Version|
| ------------------- | :------------------: |
|Log4net|2.0.10|
|Newtonsoft.Json| 12.0.3|



#La solution est constituée de trois projets :

<p>1- xxWebservice ASP.NET SOAP WebService : ce projet est subdivisé en trois répertoire  </p>
<p>      - La couche Controllers : Expose les web méthodes Fibonacci et XmlToJson dans deux services asmx.  </p>
<p>      - La couche Services : Core de l'application responsable des traitements et des calculs.  </p>
<p>          On y trouve deux interfaces qui peuvent servir à l'injection des dépendances dans les tests. </p>
<p>      - Models : Contient l'objet, Dto, utilisé pour encapsuler le string XML.  </p>
<p>                 Cela pour éviter l'erreur de sécurité IIS. </p>

<p>J'ai fixé l'Url du projet dans IIS Express à cette adresse : http://localhost:8089/ </p>

<p>2- ConsumerApp WinForm Application : L'application cliente qui consomme les deux services en mode asynchrone. </p>

<p>3- xxWebserviceTest Test Application : Projet de test unitaire. Ou j'appelle directement la couche service pour tester mes web méthodes. </p>
 
<p align="center">
  <img src="https://i.imgur.com/eKEJk9J.png" alt="badges" style="margin:auto">
</p>
