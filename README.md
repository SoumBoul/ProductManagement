# Product Management

Application desktop de gestion commerciale developpee en C# Windows Forms. Le projet permet de gerer les produits, categories, clients, utilisateurs et ventes avec une architecture simple en couches.

## Fonctionnalites

- Gestion des produits
- Gestion des categories
- Gestion des clients
- Gestion des utilisateurs
- Gestion des commandes et details de commandes
- Authentification des utilisateurs
- Sauvegarde et restauration de la base de donnees
- Impression et affichage de documents
- Interface Windows Forms

## Technologies utilisees

- C#
- .NET Framework 4.7.2
- Windows Forms
- SQL Server
- ADO.NET
- Crystal Reports
- Visual Studio

## Structure du projet

```text
Projet Product Management/
├── BL/                    # Business Layer: logique metier
├── DAL/                   # Data Access Layer: acces a la base de donnees
├── PresentationLayer/     # Interfaces Windows Forms
├── Properties/            # Parametres et ressources du projet
├── Resources/             # Images et ressources graphiques
├── App.config
├── Program.cs
├── Project_Sales_Management.csproj
└── Project_Sales_Management.sln
```

## Prerequis

Avant de lancer le projet, installez :

- Visual Studio avec le support .NET Framework
- .NET Framework 4.7.2
- SQL Server
- Crystal Reports Runtime si necessaire

## Configuration de la base de donnees

Le projet utilise une base de donnees SQL Server nommee `Product_DB`.

La connexion se trouve dans :

```text
DAL/DataAccessLayer.cs
```

Si votre configuration SQL Server est differente, modifiez la chaine de connexion dans ce fichier pour l'adapter a votre environnement local.

## Lancer le projet

1. Cloner le depot :

```bash
git clone https://github.com/SoumBoul/ProductManagement.git
```

2. Ouvrir la solution dans Visual Studio :

```text
Project_Sales_Management.sln
```

3. Verifier la connexion SQL Server.

4. Compiler et lancer l'application depuis Visual Studio.

## Auteur

Projet developpe par SoumBoul.
