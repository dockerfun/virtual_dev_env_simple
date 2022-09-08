FROM mysql:latest

MAINTAINER me

ENV MYSQL_DATABASE=morpheus \ 
    MYSQL_ROOT_PASSWORD=1234

ADD mysql_dump.sql /docker-entrypoint-initdb.d

EXPOSE 3306