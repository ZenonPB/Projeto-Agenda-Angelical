CREATE DATABASE IF NOT EXISTS db_agenda;

USE db_agenda;

-- TABELA DE USUÁRIOS

CREATE TABLE IF NOT EXISTS tb_usuarios (
	anjo VARCHAR(20) NOT NULL,
	nome VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);

-- USUÁRIO ADMIN

INSERT INTO tb_usuarios VALUES ("Gabriel", "deus", "admin", "777-777", "admin123");

CREATE USER 'admin'@'%' IDENTIFIED BY 'admin123';
GRANT ALL PRIVILEGES ON db_agenda.* TO 'admin'@'%' WITH GRANT OPTION;

-- TABELA DE CATEGORIAS

CREATE TABLE IF NOT EXISTS tb_categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    categoria VARCHAR(100) NOT NULL,

    CONSTRAINT fk_tbusuarios_tbcategorias
    FOREIGN KEY (usuario)
    REFERENCES tb_usuarios(usuario)
    ON DELETE CASCADE
);

-- TRIGGER TABELA DE CATEGORIAS

DELIMITER $$

CREATE TRIGGER trInsertCategoria
    BEFORE
    INSERT
    ON tb_categorias
    FOR EACH ROW
BEGIN
    SET NEW.usuario = SUBSTRING_INDEX(USER(), '@', 1);
END;

$$

DELIMITER ;