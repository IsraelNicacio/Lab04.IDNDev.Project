CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20251218222727_Db_Inicial') THEN
        IF NOT EXISTS(SELECT 1 FROM pg_namespace WHERE nspname = 'Cadastros') THEN
            CREATE SCHEMA "Cadastros";
        END IF;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20251218222727_Db_Inicial') THEN
    CREATE TABLE "Cadastros"."Pessoas" (
        "Id" uuid NOT NULL,
        "Nome" varchar(120) NOT NULL,
        "Documento" varchar(14) NOT NULL,
        "Idade" integer NOT NULL,
        CONSTRAINT "PK_Pessoas" PRIMARY KEY ("Id")
    );
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20251218222727_Db_Inicial') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20251218222727_Db_Inicial', '10.0.1');
    END IF;
END $EF$;
COMMIT;

