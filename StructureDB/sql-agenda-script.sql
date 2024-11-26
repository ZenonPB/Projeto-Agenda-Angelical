CREATE DATABASE IF NOT EXISTS db_agenda;

USE db_agenda;

-- ================ CRIACAO DAS TABELAS ================

-- TABELA DE USUÁRIOS
CREATE TABLE IF NOT EXISTS tb_usuarios(
	nome_anjo VARCHAR(20) NOT NULL,
	nome VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);

-- TABELA DE CATEGORIAS
CREATE TABLE IF NOT EXISTS tb_categorias(
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    categoria VARCHAR(100) NOT NULL,

    CONSTRAINT fk_tbusuarios_tbcategorias
    FOREIGN KEY (usuario)
    REFERENCES tb_usuarios(usuario)
    ON DELETE CASCADE
);

-- TABELA DE CONTATOS
CREATE TABLE IF NOT EXISTS tb_contatos(
	contato_id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(80) NOT NULL,
    categoria VARCHAR(100) NOT NULL,
    
	CONSTRAINT fk_tbcategorias_tbcontatos
    FOREIGN KEY (categoria)
    REFERENCES tb_categorias(usuario)
    ON DELETE CASCADE
);

-- TABELA DE TELEFONES
CREATE TABLE IF NOT EXISTS tb_telefones(
	telefone_id INT AUTO_INCREMENT PRIMARY KEY,
    telefone VARCHAR(15) NOT NULL,
    contato_id INT,
    
	CONSTRAINT fk_tbcontatos_tbtelefones
    FOREIGN KEY (contato_id)
    REFERENCES tb_contatos(contato_id)
    ON DELETE CASCADE
);

-- TABELA DE AFINIDADES
CREATE TABLE IF NOT EXISTS tb_afinidades(
	tema_id INT AUTO_INCREMENT PRIMARY KEY,
    contato_id INT NOT NULL,
    categoria_id INT NOT NULL,
    
	CONSTRAINT fk_tbcontatos_tbafinidades
    FOREIGN KEY (contato_id)
    REFERENCES tb_contatos(contato_id)
    ON DELETE CASCADE,
    
	CONSTRAINT fk_tbcategorias_tbafinidades
    FOREIGN KEY (categoria_id)
    REFERENCES tb_categorias(id_categoria)
    ON DELETE CASCADE
);

-- TABELA DE LOGS
CREATE TABLE IF NOT EXISTS tb_logs(
    id_log INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    dt_alteracao DATETIME DEFAULT CURRENT_TIMESTAMP() NOT NULL,
    descricao VARCHAR(250) NOT NULL
);
-- ================ CRIACAO DO USUARIO ADMIN ================
-- USUÁRIO ADMIN
INSERT INTO tb_usuarios VALUES ("Gabriel", "Deus", "deus", "salmo23", "admin123");

CREATE USER 'admin'@'%' IDENTIFIED BY 'admin123';
GRANT ALL PRIVILEGES ON db_agenda.* TO 'admin'@'%' WITH GRANT OPTION;

-- ================ CRIACAO DOS TRIGGERS ================

-- TRIGGER INSERT CATEGORIAS
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


-- TRIGGER LOG INSERT CATEGORIA
DELIMITER $$
CREATE TRIGGER tr_log_insert_categoria
    AFTER
    INSERT
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("Nova categoria inserida: ", NEW.categoria)
    );
END;
$$
DELIMITER ;


-- TRIGGER LOG DELETE CATEGORIA
DELIMITER $$
CREATE TRIGGER tr_log_delete_categoria
    AFTER
    DELETE
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("A categoria ", OLD.categoria, "foi deletada por: ", OLD.usuario)
    );
END;
$$
DELIMITER ;


-- TRIGGER LOG UPDATE CATEGORIA
DELIMITER $$
CREATE TRIGGER tr_log_update_categoria
    AFTER
    UPDATE
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("A categoria ", OLD.categoria, " foi mudada para: ", NEW.categoria)
    );
END;
$$
DELIMITER ;