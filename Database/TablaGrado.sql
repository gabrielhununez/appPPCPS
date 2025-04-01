CREATE TABLE grado (
    id_grado INT AUTO_INCREMENT PRIMARY KEY,
    abreviatura VARCHAR(10) NOT NULL,
    grado_completo VARCHAR(35) NOT NULL
);

INSERT INTO grado (abreviatura, grado_completo) VALUES
('TG', 'Teniente General'),
('GD', 'General de Division'),
('GB', 'General de Brigada'),
('CY', 'Coronel Mayor'),
('CR', 'Coronel'),
('TC', 'Teniente Coronel'),
('MY', 'Mayor'),
('CT', 'Capitan'),
('TP', 'Teniente Primero'),
('TT', 'Teniente'),
('ST', 'Subteniente'),
('SM', 'Suboficial Mayor'),
('SP', 'Suboficial Principal'),
('SA', 'Sargento Ayudante'),
('SI', 'Sargento Primero'),
('SG', 'Sargento'),
('CI', 'Cabo Primero'),
('CB', 'Cabo'),
('VP', 'Voluntario de Primera'),
('VS', 'Voluntario de Segunda'),
('VS "EC"', 'Voluntario de Segunda en Comision'),
('A/C', 'Agente Civil')