# GESTION PRODUITS

[![C#](https://img.shields.io/badge/C%23-9.0-blue.svg)](https://docs.microsoft.com/fr-fr/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-6.0-purple.svg)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB-red.svg)](https://www.microsoft.com/fr-fr/sql-server)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop-green.svg)](https://docs.microsoft.com/fr-fr/dotnet/desktop/winforms/)

Application de bureau Windows Forms pour la gestion des produits et des catégories avec base de données SQL Server.

## 🎯 Fonctionnalités

### Gestion des Produits
- ✅ **Ajouter** un nouveau produit (Référence, Désignation, Quantité, Catégorie)
- ✅ **Modifier** les informations d'un produit existant
- ✅ **Supprimer** un produit par sa référence
- ✅ **Afficher** la liste complète des produits dans un DataGridView
- ✅ **Enregistrer** les modifications en base de données

### Gestion des Catégories
- 📂 Affichage des catégories dans une liste déroulante (ComboBox)
- 🔗 Liaison produit-catégorie via clé étrangère

## 🛠️ Technologies Utilisées

| Composant | Technologie |
|-----------|-------------|
| **Langage** | C# 9.0 / .NET 6.0+ |
| **Interface** | Windows Forms |
| **Base de données** | SQL Server (LocalDB) |
| **Accès données** | ADO.NET (SqlConnection, SqlDataAdapter, DataSet) |
| **Pattern** | Déconnecté (DataSet + SqlCommandBuilder) |

## 📋 Prérequis

- Windows 10/11
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) ou supérieur
- [SQL Server Express LocalDB](https://docs.microsoft.com/fr-fr/sql/database-engine/configure-windows/sql-server-express-localdb)
- Visual Studio 2022 (recommandé) ou VS Code

## 🗄️ Structure de la Base de Données

### Base : `GestProduit`

#### Table `Produit`
| Colonne | Type | Description |
|---------|------|-------------|
| `reference` | `VARCHAR(50)` | Clé primaire - Référence produit |
| `designation` | `VARCHAR(100)` | Nom/description du produit |
| `quantite` | `INT` | Quantité en stock |
| `idCategorie` | `INT` | Clé étrangère vers Catégorie |

#### Table `Categorie`
| Colonne | Type | Description |
|---------|------|-------------|
| `idCategorie` | `INT` | Clé primaire auto-incrémentée |
| `nom` | `VARCHAR(50)` | Nom de la catégorie |

### Chaîne de connexion
```csharp
Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestProduit;Integrated Security=True
