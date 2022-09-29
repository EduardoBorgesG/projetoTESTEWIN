# projetoTESTEWIN
Projeto para o teste ao dpt de desenvolvimento



Segue abaixo os scripts para criação das tabelas no banco de dados:



CREATE TABLE nascimento (id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
                         nomeR VARCHAR(60),
                         dataNRda date NOT NULL,
                         nomeM VARCHAR(60) NOT NULL,
                         dataNM date NOT NULL,
                         cpfM VARCHAR(15) NOT NULL,
                         nomeP VARCHAR(60) NOT NULL,
                         dataNP date NOT NULL,
                         cpfP VARCHAR(15) NOT NULL,
                         dataR date NOT NULL);
                         
                         
CREATE TABLE casamento (id int AUTO_INCREMENT PRIMARY KEY,
  nomeC1 varchar(60) NOT NULL,
  dataC1 date NOT NULL,
  cpfC1 varchar(15) NOT NULL,
  nomePC1 varchar(60) NOT NULL,
  dataPC1 date NOT NULL,
  cpfPC1 varchar(15) NOT NULL,
  nomeMC1 varchar(60) NOT NULL,
  dataMC1 date NOT NULL,
  cpfMC1 varchar(15) NOT NULL,
  nomeC2 varchar(60) NOT NULL,
  dataC2 date NOT NULL,
  cpfC2 varchar(15) NOT NULL,
  nomePC2 varchar(60) NOT NULL,
  dataPC2 date NOT NULL,
  cpfPC2 varchar(15) NOT NULL,
  nomeMC2 varchar(60) NOT NULL,
  dataMC2 date NOT NULL,
  cpfMC2 varchar(15) NOT NULL,
  dataR date NOT NULL,
  dataC date NOT NULL)



CREATE TABLE obito (id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
  nomeF VARCHAR(60) NOT NULL,
  dataNF date NOT NULL,
  nomeM VARCHAR(60) NOT NULL,
  dataM date NOT NULL,
  nomeP VARCHAR(60) NOT NULL,
  dataP date NOT NULL,
  dataO date NOT NULL,
  dataR date NOT NULL)
