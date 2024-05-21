import Conexao


def selectcliente():
    con = Conexao.conecta()
    cursor = con.cursor()

    cursor.execute("Select * from clientes;")
    dados = cursor.fetchall()

    for i in dados:
        print(i)
    # print("{:<4} | {:<15} | {:<11}".format("ID", "NOME", "CPF"))
    # for i in lista_clientes:
    #     print("{:<4} | {:<15} | {:<11}".format(i[0], i[1], i[2]))


def busca_um(cpf):
    con = Conexao.conecta()
    cursor = con.cursor()

    sql = f"select * from clientes where cpf = '{cpf}'"
    cursor.execute(sql)
    cliente = cursor.fetchall()
    print(cliente)


def insertcliente(nome, cpf, datanasc):
    con = Conexao.conecta()
    cursor = con.cursor()

    cursor.execute(f"insert into db_financeiro.clientes values(default, '{nome}', '{cpf}', '{datanasc}');")
    con.commit()

def atualizarcliente(id, nome, cpf, datanasc):
    con = Conexao.conecta()
    cursor = con.cursor()

    sql = f"update clientes set nome = '{nome}', cpf = '{cpf}', data_nascimento = '{datanasc}' where cliente_id = {id};"
    cursor.execute(sql)
    con.commit()

def deletarcliente(cpf):
    con = Conexao.conecta()
    cursor = con.cursor()

    sql = f"delete from clientes where cpf = '{cpf}';"
    cursor.execute(sql)
    con.commit()