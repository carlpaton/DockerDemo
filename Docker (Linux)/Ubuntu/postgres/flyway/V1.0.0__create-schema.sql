/* flyway will create the schema for you on BASELINE */
CREATE DATABASE flyway_demo
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    CONNECTION LIMIT = -1;