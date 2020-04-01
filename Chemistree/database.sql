CREATE TABLE IF NOT EXISTS elements (
    id					INT(4)		NOT NULL	AUTO_INCREMENT,
    name				VARCHAR(30)	NOT NULL,
    abbreviation		VARCHAR(4)	NOT NULL,
    atomicNumber		INT(3)		NOT NULL,
    periodicGroup       INT(3)      NOT NULL,
    periodicPeriod      INT(3)      NOT NULL,
    PRIMARY KEY(id)
    );