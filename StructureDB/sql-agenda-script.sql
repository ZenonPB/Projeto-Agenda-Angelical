CREATE DATABASE IF NOT EXISTS db_agenda;

USE db_agenda;


-- /////////////////// TABELAS ///////////////////

-- usuarios

CREATE TABLE IF NOT EXISTS tb_usuarios (
	anjo VARCHAR(20) NOT NULL,
	nome VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);

-- contatos

CREATE TABLE IF NOT EXISTS tb_contatos (
    id_contato INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(50) NOT NULL,
    categoria VARCHAR(100) NOT NULL,
    usuario VARCHAR(50),

    CONSTRAINT fk_usuarios_contatos
    FOREIGN KEY (usuario)
    REFERENCES tb_usuarios (usuario)
    ON DELETE CASCADE

    CONSTRAINT fk_categorias_contatos
    FOREIGN KEY (categoria)
    REFERENCES tb_categorias (categoria)
);


-- categorias

CREATE TABLE IF NOT EXISTS tb_categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    categoria VARCHAR(100) NOT NULL,

    CONSTRAINT fk_usuarios_categorias
    FOREIGN KEY (usuario)
    REFERENCES tb_usuarios(usuario)
    ON DELETE CASCADE
);


-- logs

CREATE TABLE IF NOT EXISTS tb_logs (
    id_log INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    dt_alteracao DATETIME DEFAULT CURRENT_TIMESTAMP() NOT NULL,
    descricao VARCHAR(250) NOT NULL
);

-- USUÁRIO ADMIN

INSERT INTO tb_usuarios VALUES ("Ganância", "belzebu", "admin", "666-777", "admin123");

CREATE USER 'admin'@'%' IDENTIFIED BY 'admin123';
GRANT ALL PRIVILEGES ON db_agenda.* TO 'admin'@'%' WITH GRANT OPTION;

-- /////////////////// TRIGGERS ///////////////////

-- vincular o usuario à categoria

DELIMITER $$

CREATE TRIGGER tr_insert_categoria
    BEFORE
    INSERT
    ON tb_categorias
    FOR EACH ROW
BEGIN
    SET NEW.usuario = SUBSTRING_INDEX(USER(), '@', 1);
END;

$$

DELIMITER ;

-- inserção da categoria -> log

DELIMITER $$

CREATE TRIGGER tr_log_insert_categoria
    AFTER
    INSERT
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("Nova categoria: ", NEW.categoria)
    );
END;

$$

DELIMITER ;

-- deletar categoria -> log

DELIMITER $$

CREATE TRIGGER tr_log_delete_categoria
    AFTER
    DELETE
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("Categoria removida: ", OLD.categoria, ". Usuário responsável: ", OLD.usuario)
    );
END;

$$

DELIMITER ;

-- alterar categoria -> log

DELIMITER $$

CREATE TRIGGER tr_log_update_categoria
    AFTER
    UPDATE
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("Categoria alterada de: ", OLD.categoria, " para: ", NEW.categoria)
    );
END;

$$

DELIMITER ;