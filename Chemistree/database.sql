-- CREATE DATABASE chemistree;
CREATE USER 'mendeleev'@'localhost' IDENTIFIED BY 'periodic';
GRANT ALL ON chemistree.* TO 'mendeleev'@'localhost';

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
    type            ENUM('anion', 'cation', 'zwitterion'),
    PRIMARY KEY(id)
 );

INSERT INTO elements
VALUES
('H', 'Hydrogen', 1, 1, 1, '1s^1'),
('He', 'Helium', 2, 18, 1, '1s^2'),
('Li', 'Lithium', 3, 1, 2, '[He]2s^1'),
('Be', 'Beryllium', 4, 2, 2, '[He]2s^2'),
('B', 'Boron', 5, 13, 2, '[He]2s^2,2p^1'),
('C', 'Carbon', 6, 14, 2, '[He]2s^2,2p^2'),
('N', 'Nitrogen', 7, 15, 2, '[He]2s^2,2p^3'),
('O', 'Oxygen', 8, 16, 2, '[He]2s^2,2p^4'),
('F', 'Fluorine', 9, 17, 2, '[He]2s^2,2p^5'),
('Ne', 'Neon', 10, 18, 2, '[He]2s^2,2p^6'),
('Na', 'Sodium', 11, 1, 3, '[Ne]3s^1'),
('Mg', 'Magnesium', 12, 2, 3, '[Ne]3s^2'),
('Al', 'Aluminium', 13, 13, 3, '[Ne]3s^2,3p^1'),
('Si', 'Silicon', 14, 14, 3, '[Ne]3s^2,3p^2'),
('P', 'Phosphorus', 15, 15, 3, '[Ne]3s^2,3p^3'),
('S', 'Sulfur', 16, 16, 3, '[Ne]3s^2,3p^4'),
('Cl', 'Chlorine', 17, 17, 3, '[Ne]3s^2,3p^5'),
('Ar', 'Argon', 18, 18, 3, '[Ne]3s^2,3p^6'),
('K', 'Potassium', 19, 1, 4, '[Ar]4s^1'),
('Ca', 'Calcium', 20, 2, 4, '[Ar]4s^2'),
('Sc', 'Scandium', 21, 3, 4, '[Ar]3d^1,4s^2'),
('Ti', 'Titanium', 22, 4, 4, '[Ar]3d^2,4s^2'),
('V', 'Vanadium', 23, 5, 4, '[Ar]3d^3,4s^2'),
('Cr', 'Chromium', 24, 6, 4, '[Ar]3d^5,4s^1'),
('Mn', 'Manganese', 25, 7, 4, '[Ar]3d^5,4s^2'),
('Fe', 'Iron', 26, 8, 4, '[Ar]3d^6,4s^2'),
('Co', 'Cobalt', 27, 9, 4, '[Ar]3d^7,4s^2'),
('Ni', 'Nickel', 28, 10, 4, '[Ar]3d^8,4s^2'),
('Cu', 'Copper', 29, 11, 4, '[Ar]3d^10,4s^1'),
('Zn', 'Zinc', 30, 12, 4, '[Ar]3d^10,4s^2'),
('Ga', 'Gallium', 31, 13, 4, '[Ar]3d^10,4s^2,4p^1'),
('Ge', 'Germanium', 32, 14, 4, '[Ar]3d^10,4s^2,4p^2'),
('As', 'Arsenic', 33, 15, 4, '[Ar]3d^10,4s^2,4p^3'),
('Se', 'Selenium', 34, 16, 4, '[Ar]3d^10,4s^2,4p^4'),
('Br', 'Bromine', 35, 17, 4, '[Ar]3d^10,4s^2,4p^5'),
('Kr', 'Krypton', 36, 18, 4, '[Ar]3d^10,4s^2,4p^6'),
('Rb', 'Rubidium', 37, 1, 5, '[Kr]5s^1'),
('Sr', 'Strontium', 38, 2, 5, '[Kr]5s^2'),
('Y', 'Yttrium', 39, 3, 5, '[Kr]4d^1,5s^2'),
('Zr', 'Zirconium', 40, 4, 5, '[Kr]4d^2,5s^2'),
('Nb', 'Niobium', 41, 5, 5, '[Kr]4d^4,5s^1'),
('Mo', 'Molybdenum', 42, 6, 5, '[Kr]4d^5,5s^1'),
('Tc', 'Technetium', 43, 7, 5, '[Kr]4d^5,5s^2'),
('Ru', 'Ruthenium', 44, 8, 5, '[Kr]4d^7,5s^1'),
('Rh', 'Rhodium', 45, 9, 5, '[Kr]4d^8,5s^1'),
('Pd', 'Palladium', 46, 10, 5, '[Kr]4d^10'),
('Ag', 'Silver', 47, 11, 5, '[Kr]4d^10,5s^1'),
('Cd', 'Cadmium', 48, 12, 5, '[Kr]4d^10,5s^2'),
('In', 'Indium', 49, 13, 5, '[Kr]4d^10,5s^2,5p^1'),
('Sn', 'Tin', 50, 14, 5, '[Kr]4d^10,5s^2,5p^2'),
('Sb', 'Antimony', 51, 15, 5, '[Kr]4d^10,5s^2,5p^3'),
('Te', 'Tellurium', 52, 16, 5, '[Kr]4d^10,5s^2,5p^4'),
('I', 'Iodine', 53, 17, 5, '[Kr]4d^10,5s^2,5p^5'),
('Xe', 'Xenon', 54, 18, 5, '[Kr]4d^10,5s^2,5p^6'),
('Cs', 'Caesium', 55, 1, 6, '[Xe]6s^1'),
('Ba', 'Barium', 56, 2, 6, '[Xe]6s^2'),
('La', 'Lanthanum', 57, 3, 6, '[Xe]5d^1,6s^2'),
('Ce', 'Cerium', 58, 33, 6, '[Xe]4f^1,5d^1,6s^2'),
('Pr', 'Praseodymium', 59, 33, 6, '[Xe]4f^3,6s^2'),
('Nd', 'Neodymium', 60, 33, 6, '[Xe]4f^4,6s^2'),
('Pm', 'Promethium', 61, 33, 6, '[Xe]4f^5,6s^2'),
('Sm', 'Samarium', 62, 33, 6, '[Xe]4f^6,6s^2'),
('Eu', 'Europium', 63, 33, 6, '[Xe]4f^7,6s^2'),
('Gd', 'Gadolinium', 64, 33, 6, '[Xe]4f^7,5d^1,6s^2'),
('Tb', 'Terbium', 65, 33, 6, '[Xe]4f^9,6s^2'),
('Dy', 'Dysprosium', 66, 33, 6, '[Xe]4f^10,6s^2'),
('Ho', 'Holmium', 67, 33, 6, '[Xe]4f^11,6s^2'),
('Er', 'Erbium', 68, 33, 6, '[Xe]4f^12,6s^2'),
('Tm', 'Thulium', 69, 33, 6, '[Xe]4f^13,6s^2'),
('Yb', 'Ytterbium', 70, 33, 6, '[Xe]4f^14,6s^2'),
('Lu', 'Lutetium', 71, 33, 6, '[Xe]4f^14,5d^1,6s^2'),
('Hf', 'Hafnium', 72, 4, 6, '[Xe]4f^14,5d^2,6s^2'),
('Ta', 'Tantalum', 73, 5, 6, '[Xe]4f^14,5d^3,6s^2'),
('W', 'Tungsten', 74, 6, 6, '[Xe]4f^14,5d^4,6s^2'),
('Re', 'Rhenium', 75, 7, 6, '[Xe]4f^14,5d^5,6s^2'),
('Os', 'Osmium', 76, 8, 6, '[Xe]4f^14,5d^6,6s^2'),
('Ir', 'Iridium', 77, 9, 6, '[Xe]4f^14,5d^7,6s^2'),
('Pt', 'Platinum', 78, 10, 6, '[Xe]4f^14,5d^9,6s^1'),
('Au', 'Gold', 79, 11, 6, '[Xe]4f^14,5d^10,6s^1'),
('Hg', 'Mercury', 80, 12, 6, '[Xe]4f^14,5d^10,6s^2'),
('Tl', 'Thallium', 81, 13, 6, '[Xe]4f^14,5d^10,6s^2,6p^1'),
('Pb', 'Lead', 82, 14, 6, '[Xe]4f^14,5d^10,6s^2,6p^2'),
('Bi', 'Bismuth', 83, 15, 6, '[Xe]4f^14,5d^10,6s^2,6p^3'),
('Po', 'Polonium', 84, 16, 6, '[Xe]4f^14,5d^10,6s^2,6p^4'),
('At', 'Astatine', 85, 17, 6, '[Xe]4f^14,5d^10,6s^2,6p^5'),
('Rn', 'Radon', 86, 18, 6, '[Xe]4f^14,5d^10,6s^2,6p^6'),
('Fr', 'Francium', 87, 1, 7, '[Rn]7s^1'),
('Ra', 'Radium', 88, 2, 7, '[Rn]7s^2'),
('Ac', 'Actinium', 89, 3, 7, '[Rn]6d^1,7s^2'),
('Th', 'Thorium', 90, 33, 7, '[Rn]6d^2,7s^2'),
('Pa', 'Protactinium', 91, 33, 7, '[Rn]5f^2,6d^1,7s^2'),
('U', 'Uranium', 92, 33, 7, '[Rn]5f^3,6d^1,7s^2'),
('Np', 'Neptunium', 93, 33, 7, '[Rn]5f^4,6d^1,7s^2'),
('Pu', 'Plutonium', 94, 33, 7, '[Rn]5f^6,7s^2'),
('Am', 'Americium', 95, 33, 7, '[Rn]5f^7,7s^2'),
('Cm', 'Curium', 96, 33, 7, '[Rn]5f^7,6d^1,7s^2'),
('Bk', 'Berkelium', 97, 33, 7, '[Rn]5f^9,7s^2'),
('Cf', 'Californium', 98, 33, 7, '[Rn]5f^10,7s^2'),
('Es', 'Einsteinium', 99, 33, 7, '[Rn]5f^11,7s^2'),
('Fm', 'Fermium', 100, 33, 7, '[Rn]5f^12,7s^2'),
('Md', 'Mendelevium', 101, 33, 7, '[Rn]5f^13,7s^2'),
('No', 'Nobelium', 102, 33, 7, '[Rn]5f^14,7s^2'),
('Lr', 'Lawrencium', 103, 33, 7, '[Rn]5f^14,7s^2,7p^1'),
('Rf', 'Rutherfordium', 104, 4, 7, '[Rn]5f^14,6d^2,7s^2'),
('Db', 'Dubnium', 105, 5, 7, '*[Rn]5f^14,6d^3,7s^2'),
('Sg', 'Seaborgium', 106, 6, 7, '*[Rn]5f^14,6d^4,7s^2'),
('Bh', 'Bohrium', 107, 7, 7, '*[Rn]5f^14,6d^5,7s^2'),
('Hs', 'Hassium', 108, 8, 7, '*[Rn]5f^14,6d^6,7s^2'),
('Mt', 'Meitnerium', 109, 9, 7, '*[Rn]5f^14,6d^7,7s^2'),
('Ds', 'Darmstadtium', 110, 10, 7, '*[Rn]5f^14,6d^9,7s^1'),
('Rg', 'Roentgenium', 111, 11, 7, '*[Rn]5f^14,6d^10,7s^1'),
('Cn', 'Copernicium', 112, 12, 7, '*[Rn]5f^14,6d^10,7s^2'),
('Nh', 'Nihonium', 113, 13, 7, '*[Rn]5f^14,6d^10,7s^2,7p^1'),
('Fl', 'Flerovium', 114, 14, 7, '*[Rn]5f^14,6d^10,7s^2,7p^2'),
('Mc', 'Moscovium', 115, 15, 7, '*[Rn]5f^14,6d^10,7s^2,7p^3'),
('Lv', 'Livermorium', 116, 16, 7, '*[Rn]5f^14,6d^10,7s^2,7p^4'),
('Ts', 'Tennessine', 117, 17, 7, '*[Rn]5f^14,6d^10,7s^2,7p^5'),
('Og', 'Oganesson', 118, 18, 7, '*[Rn]5f^14,6d^10,7s^2,7p^6');


INSERT INTO ions (abbreviation, name, charge, type)
VALUES
('Al', 'Aluminium', 3, 'cation'),
('Ba', 'Barium', 2, 'cation'),
('Be', 'Beryllium', 2, 'cation'),
('Ca', 'Calcium', 2, 'cation'),
('Cr', 'Chromium(III)', 3, 'cation'),
('Cu', 'Copper(I)', 1, 'cation'),
('Cu', 'Copper(II)', 2, 'cation'),
('H', 'Hydrogen', 1, 'cation'),
('Fe', 'Iron(II)', 2, 'cation'),
('Fe', 'Iron(III)', 3, 'cation'),
('Pb', 'Lead(II)', 2, 'cation'),
('Pb', 'Lead(IV)', 4, 'cation'),
('Li', 'Lithium', 1, 'cation'),
('Mg', 'Magnesium', 2, 'cation'),
('Mn', 'Manganese(II)', 2, 'cation'),
('Mn', 'Manganese(III)', 3, 'cation'),
('Mn', 'Manganese(IV)', 4, 'cation'),
('Hg', 'Mercury(II)', 2, 'cation'),
('K', 'Potassium', 1, 'cation'),
('Ag', 'Silver', 1, 'cation'),
('Na', 'Sodium', 1, 'cation'),
('Sr', 'Strontium', 2, 'cation'),
('Sn', 'Tin(II)', 2, 'cation'),
('Sn', 'Tin(IV)', 4, 'cation'),
('Br', 'Bromide', -1, 'anion'),
('Cl', 'Chloride', -1, 'anion'),
('F', 'Fluoride', -1, 'anion'),
('H', 'Hydride', -1, 'anion'),
('I', 'Iodide', -1, 'anion'),
('N', 'Nitride', -3, 'anion'),
('P', 'Phosphide', -3, 'anion'),
('O', 'Oxide', -2, 'anion'),
('S', 'Sulfide', -2, 'anion'),
('Se', 'Selenide', -2, 'anion'),
('NH4', 'Ammonium', 1, 'cation'),
('H3O', 'Hydronium', 1, 'cation'),
('Hg2', 'Mercury(I)', 2, 'cation'),
('CH3COO', 'Acetate', -1, 'anion'),
('N3', 'Azide', -1, 'anion'),
('HCOO', 'Formate', -1, 'anion'),
('C2O4', 'Oxalate', -2, 'anion'),
('CN', 'Cyanide', -1, 'anion'),
('CO3', 'Carbonate', -2, 'anion'),
('CIO3', 'Chlorate', -1, 'anion'),
('CrO4', 'Chromate', -2, 'anion'),
('Cr2O7', 'Dichromate', -2, 'anion'),
('H2PO4', 'Dihydrogen Phosphate', -1, 'anion'),
('HCO3', 'Hydrogen Carbonate', -1, 'anion'),
('HSO4', 'Hydrogen Sulfate', -1, 'anion'),
('HSO3', 'Hydrogen Sulfite', -1, 'anion'),
('OH', 'Hydroxide', -1, 'anion'),
('CIO', 'Hypochlorite', -1, 'anion'),
('HPO4', 'Monohydrogen Phosphate', -2, 'anion'),
('NO3', 'Nitrate', -1, 'anion'),
('NO2', 'Nitrite', -1, 'anion'),
('CIO4', 'Perchlorate', -1, 'anion'),
('MnO4', 'Permanganate', -1, 'anion'),
('O2', 'Peroxide', -2, 'anion'),
('PO4', 'Phosphate', -3, 'anion'),
('SO4', 'Sulfate', -2, 'anion'),
('SO3', 'Sulfite', -2, 'anion'),
('O2', 'Superoxide', -1, 'anion'),
('S2O3', 'Thiosulfate', -2, 'anion'),
('SiO4', 'Silicate', -4, 'anion'),
('SiO3', 'Metasilicate', -2, 'anion'),
('AlSiO4', 'Aluminum Silicate', -1, 'anion'),
('CH3COO', 'Acetate', -1, 'anion');