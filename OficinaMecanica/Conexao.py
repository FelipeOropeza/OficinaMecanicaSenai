import mysql.connector


def conecta():
    con = mysql.connector.connect(
        host="localhost",
        user="root",
        password="senai",
        database="db_financeiro"
    )
    return con