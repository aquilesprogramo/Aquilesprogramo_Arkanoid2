CREATE DATABASE proyectoPoo;

CREATE TABLE public.usuario
(n
    nombre character varying NOT NULL,
    PRIMARY KEY (nombre)
);

ALTER TABLE public.usuario
    OWNER to postgres;


CREATE TABLE public.record
(
    num_record serial NOT NULL,
    nombre_usuario character varying,
    puntaje integer,
    PRIMARY KEY (num_record),
    FOREIGN KEY (nombre_usuario)
        REFERENCES public.usuario (nombre) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
);

ALTER TABLE public.record
    OWNER to postgres;
