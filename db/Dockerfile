<<<<<<< HEAD
FROM mysql:latest
=======
FROM mysql:8.0.30
>>>>>>> 5214dd45d5558434606679918abc673b40102e79

MAINTAINER me

ENV MYSQL_DATABASE=morpheus \ 
    MYSQL_ROOT_PASSWORD=1234

ADD mysql_dump.sql /docker-entrypoint-initdb.d

EXPOSE 3306