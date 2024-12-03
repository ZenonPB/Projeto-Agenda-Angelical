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

-- contatos

CREATE TABLE IF NOT EXISTS tb_contatos (
    id_contato INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    id_categoria INT,
    endereco VARCHAR(50),
    telefone VARCHAR(50) NOT NULL,
    usuario VARCHAR(50),

    CONSTRAINT fk_usuarios_contatos
    FOREIGN KEY (usuario)
    REFERENCES tb_usuarios (usuario)
    ON DELETE CASCADE,
    
	CONSTRAINT fk_categorias_contatos
    FOREIGN KEY (id_categoria)
    REFERENCES tb_categorias(id_categoria)
    ON DELETE CASCADE
    
);

-- logs

CREATE TABLE IF NOT EXISTS tb_logs (
    id_log INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    dt_alteracao DATETIME DEFAULT CURRENT_TIMESTAMP() NOT NULL,
    descricao VARCHAR(250) NOT NULL
);

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


-- trigger de contato
DELIMITER $$

CREATE TRIGGER tr_insert_contato
    BEFORE
    INSERT
    ON tb_contatos
    FOR EACH ROW
BEGIN
    SET NEW.usuario = SUBSTRING_INDEX(USER(), '@', 1);
END;

$$

DELIMITER ;

-- inserção da contato -> log

DELIMITER $$

CREATE TRIGGER tr_log_insert_contato
    AFTER
    INSERT
    ON tb_contatos
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("Novo contato: ", NEW.nome)
    );
END;

$$

DELIMITER ;

-- deletar categoria -> log

DELIMITER $$

CREATE TRIGGER tr_log_delete_contato
    AFTER
    DELETE
    ON tb_contatos
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("Contato removido: ", OLD.nome, ". Usuário responsável: ", OLD.usuario)
    );
END;

$$

DELIMITER ;

-- alterar categoria -> log

DELIMITER $$

CREATE TRIGGER tr_log_update_contato
    AFTER
    UPDATE
    ON tb_contatos
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("Categoria alterada de: ", OLD.nome, " para: ", NEW.nome)
    );
END;

$$

DELIMITER ;

