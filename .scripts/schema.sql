CREATE DATABASE RosterSynopsisDB;

CREATE TABLE Artists
(
    ArtistId INT identity PRIMARY KEY NOT NULL,
    ArtistName VARCHAR(500) NOT NULL
)

CREATE TABLE Rates
(
    RateId INT identity PRIMARY KEY NOT NULL,
    RateAmount FLOAT(53) NOT NULL,
    ArtistId INT NOT NULL,
    FOREIGN KEY (ArtistId) REFERENCES Artists(ArtistId)
)

CREATE TABLE Streams
(
    RateId INT PRIMARY KEY NOT NULL,
    StreamCount BIGINT NOT NULL DEFAULT(0)
    FOREIGN KEY (RateId) REFERENCES Rates(RateId)
)