# Oficina Mecânica Senai

## Sistema de Gestâo de Estoque para Oficina Mecânica
![BD_OFICINAMECANICA2](https://github.com/FelipeOropeza/OficinaMecanicaSenai/assets/151665002/94995890-dd20-48a1-ae43-7acf6fd3f125)

Este sistema foi criado para facilitar a gestâo de estoque na oficina mecâcina Senai Roberto Simonsen. Ele centraliza informações sobre produtos, categorias, movimentações de estoque e  fornecedores, permitindo um controle de estoque eficiente e a manutenção de um  registro detalhado das operações.

### Tabelas Implementadas
#### ARMAZÉM 
Contém informações detalhadas sobre cada produto, como identificação única, 
nome, descrição, preço de custo, preço de venda e quantidade em estoque.
#### MOVIMENTAÇÃO 
Permite a classificação dos produtos em categorias, facilitando a organização e a 
busca por itens similares ou relacionados.
#### POSIÇÃO
Registra todas as entradas e saídas do estoque, proporcionando uma visão clara 
sobre a movimentação dos produtos e auxiliando na previsão de necessidades 
futuras de compra.
#### MATERIAL
Armazena dados sobre os fornecedores, incluindo nome, contato e a lista de produtos 
que fornecem, facilitando o processo de reabastecimento e negociação.
### PROFESSOR 
- *Cadastro de Produtos*: Inclui a possibilidade de adicionar novos produtos ao 
estoque, bem como atualizar informações de produtos existentes.
- *Organização por Categorias*: Oferece a opção de categorizar produtos, o que 
simplifica a gestão e melhora a experiência do usuário.
- *Monitoramento de Estoque*: Acompanha as movimentações de entrada e 
saída de produtos, atualizando automaticamente a quantidade disponível em 
estoque.
- *Gerenciamento de Fornecedores*: Centraliza as informações dos 
fornecedores, tornando mais fácil o contato e a gestão das compras.

#### TURMA






### Pré-requisitos

- IDE recomendade: Visual Studio Code
- Sistema de gerenciamento de banco de dados MySQL Workbench.

### Configuração
Clone o repositório:
-- git clone [https://github.com/gvnff/](https://github.com/FelipeOropeza/OficinaMecanicaSenai.git)
### Uso
Este sistema fornece uma interface de linha de comando para gerenciar produtos, 
categorias, movimentações de estoque e fornecedores. A seguir, você encontrará 
exemplos detalhados de como utilizar cada funcionalidade.
#### Adicionando um Novo Produto
Para adicionar um novo produto, siga estas etapas:
1. No menu principal, selecione a opção *[1] Produto.*
2. No menu de produtos, selecione a opção *[3] Inserir.*
3. Informe o nome do produto.
4. O sistema solicitará as seguintes informações adicionais:
- Descrição
- Preço de custo
- Preço de venda
- Quantidade inicial em estoque
- ID do fornecedor
- ID da categoria
- Marca
- Data de validade (formato YYYY-MM-DD)
- Lote
5. Após fornecer todas as informações, o produto será adicionado ao sistema.

### Categorizando um Produto
Para associar um produto a uma categoria existente:
1. No menu principal, selecione a opção *[1] Produto*.
2. No menu de produtos, selecione a opção *[3] Inserir*.
3. Informe o nome do produto e os demais detalhes solicitados.
4. Quando for solicitado o "ID da categoria", informe o ID da categoria desejada.
Para criar uma nova categoria:
1. No menu principal, selecione a opção *[2] Categoria*.
2. No menu de categorias, selecione a opção *[3] Inserir*.
3. Informe o nome da nova categoria.
4. A nova categoria estará disponível para associação aos produtos.
### Registrando Movimentações de Estoque
Para registrar uma nova entrada ou saída de estoque:
1. No menu principal, selecione a opção *[4] Movimentação*.
2. No menu de movimentações, selecione a opção *[3] Inserir*.
3. Informe o ID do produto para o qual deseja registrar a movimentação.
4. Informe o ID do usuário responsável pela movimentação.
5. Informe a data da movimentação no formato YYYY-MM-DD.
6. Informe a quantidade movimentada.
7. Informe o tipo de movimentação (entrada ou saída).
8. A movimentação será registrada, atualizando o estoque correspondente.
### Gerenciando Fornecedores
Para inserir um novo fornecedor:
1. No menu principal, selecione a opção *[3] Fornecedor*.
2. No menu de fornecedores, selecione a opção *[3] Inserir*.
3. Informe o nome do fornecedor.
4. Informe o endereço do fornecedor (ID do endereço).
5. O novo fornecedor será adicionado ao sistema.
Para atualizar informações de um fornecedor existente:
1. No menu principal, selecione a opção *[3] Fornecedor*.
2. No menu de fornecedores, selecione a opção *[2] Buscar*.
3. Informe o ID do fornecedor que deseja atualizar.
4. As informações atuais do fornecedor serão exibidas.
5. Siga as instruções fornecidas pelo sistema para atualizar os campos 
desejados.
### Licença
Este projeto é licenciado sob a Licença MIT License.
### Autores
- Seu Nome - Trabalho Inicial - SeuPerfilGitHub
### Contato
Para qualquer dúvida ou suporte técnico, entre em contato através de:
- GitHub Issues
- LinkedIn


