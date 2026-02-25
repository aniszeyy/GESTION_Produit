CREATE DATABASE GestProduit;
GO

USE GestProduit;
GO
--si il t'affiche une error de la non existance de la BDD depuis cette ligne tu n'a qu'a create la database puis la use dans MSSQL puis tu créer les table
CREATE TABLE Categorie (
    idCategorie INT IDENTITY(1,1) PRIMARY KEY,
    nom VARCHAR(50) NOT NULL
);

CREATE TABLE Produit (
    reference VARCHAR(50) PRIMARY KEY,
    designation VARCHAR(100) NOT NULL,
    quantite INT NOT NULL DEFAULT 0,
    idCategorie INT,
    FOREIGN KEY (idCategorie) REFERENCES Categorie(idCategorie)
);

-- Données de test
INSERT INTO Categorie (nom) VALUES 
('Électronique'), ('Alimentaire'), ('Textile'), ('Meubles');

INSERT INTO Produit (reference, designation, quantite, idCategorie) VALUES
('PROD001', 'Ordinateur Portable', 15, 1),
('PROD002', 'Smartphone', 30, 1),
('PROD003', 'Riz 5kg', 100, 2);
