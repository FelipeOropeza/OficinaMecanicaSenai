import Cliente

while True:
    print("[1]-Listar\n[2]-Buscar\n[3]-Insert\n[4]-Atualizar\n[5]-Deletar\n[0]-Sair")
    opcao = int(input("Opção: "))

    if opcao == 0:
        break
    if opcao == 1:
        Cliente.selectcliente()
        print("")
    if opcao == 2:
        print("")
        print("Digite o cpf a ser pesquisado: ")
        cpf = input("Cpf: ")
        Cliente.busca_um(cpf)
        print("")
    if opcao == 3:
        print("")
        print("Digite as informaçoes necessarias: ")
        array = [input("Nome: "), input("Cpf: "), input("Data de Nascimento: ")]
        Cliente.insertcliente(array[0], array[1], array[2])
        print("")
    if opcao == 4:
        print("")
        print("Digite as informaçoes necessarias pra atualizar: ")
        array = [int(input("Id: ")), input("Nome: "), input("Cpf: "), input("Data de Nascimento: ")]
        Cliente.atualizarcliente(array[0], array[1], array[2], array[3])
        print("")
    if opcao == 5:
        print("")
        print("Digite as informaçoes necessarias pra deletar: ")
        cpf = int(input("Cpf: "))
        Cliente.deletarcliente(cpf)
        print("")

