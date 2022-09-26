FROM mysql

MAINTAINER me

ENV MYSQL_DATABASE=morpheus

ADD mysql_dump.sql /docker-entrypoint-initdb.d

EXPOSE 3306