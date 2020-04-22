CREATE TABLE IF NOT EXISTS elements (
    abbreviation            VARCHAR(4)  NOT NULL,
    name				    VARCHAR(30)	NOT NULL,
    atomicNumber		    INT(3)		NOT NULL,
    periodicGroup           INT(3)      NOT NULL,
    periodicPeriod          INT(3)      NOT NULL,
    electronConfiguration   VARCHAR(30) NOT NULL,
    PRIMARY KEY(abbreviation)
    );

CREATE TABLE IF NOT EXISTS ions (
    id              INT         NOT NULL    AUTO_INCREMENT,
    abbreviation    VARCHAR(30) NOT NULL,
    name            VARCHAR(30) NOT NULL,
    charge          INT         NOT NULL,
    type            ENUM('anion', 'cation'),
    PRIMARY KEY(