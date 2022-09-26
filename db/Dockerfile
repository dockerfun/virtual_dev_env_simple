FROM mysql:8.0.30

MAINTAINER me

ENV MYSQL_DATABASE=morpheus

ADD mysql_dump.sql /docker-entrypoint-initdb.d

EXPOSE 3306