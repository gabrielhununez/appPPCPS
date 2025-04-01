CREATE TABLE personal (
    id_personal INT AUTO_INCREMENT PRIMARY KEY,
    id_grado INT,
    nombre VARCHAR(20) NOT NULL,
    segundo_nombre VARCHAR(20) NULL,
    apellido VARCHAR(20) NULL,
    tipo_de_doc VARCHAR(20) NULL,
    nro_doc VARCHAR(20) NOT NULL UNIQUE,
    FOREIGN KEY (id_grado) REFERENCES grado(id_grado)
);

INSERT INTO personal (id_grado, nombre, segundo_nombre, apellido, tipo_de_doc, nro_doc ) VALUES