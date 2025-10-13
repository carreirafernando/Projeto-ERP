# Visão Geral
Esse ERP tem como objetivo controlar:
- Clientes e seus veículos
- Ordens de serviço (OS)
- Peças e estoque
- Serviços realizados
- Mecânicos e etapas de produção

## Tabelas e Relacionamentos
## Clientes
| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|id_cliente| INT (PK, AI)| Identificador único|
|nome| VARCHAR(100)| Nome completo ou razão social|
|cpf_cnpj| VARCHAR(20)| CPF ou CNPJ|
|telefone| VARCHAR(20)| Telefone de contato|
|email| VARCHAR(100)| E-mail do cliente|
|endereco| VARCHAR(150)| Endereço completo|
|cidade| VARCHAR(60)| Cidade|
|uf| CHAR(2)| Estado|
|data_cadastro| DATE| Data de registro|

## Veiculos
| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|id_veiculo| INT (PK, AI)| Identificador do veículo|
|id_cliente| INT (FK)| Cliente dono do veículo|
|placa| VARCHAR(10)| Placa do veículo|
|modelo| VARCHAR(50)| Modelo|
|marca| VARCHAR(50)| Marca|
|ano| INT| Ano de fabricação|

### observacoes TEXT Observações gerais
Relacionamento:
Um cliente pode ter vários veículos → (1:N)

## Funcionarios
| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|id_funcionario| INT (PK, AI)| Identificador|
|nome| VARCHAR(100)| Nome completo|
|cargo| VARCHAR(50)| Ex: Mecânico, Pintor, Eletricista|
|telefone| VARCHAR(20)| Contato|
|email| VARCHAR(100)| E-mail|
|data_admissao| DATE| Data de entrada|
|status| VARCHAR(20)| Ativo / Inativo|

## Servicos
### Campo Tipo Descrição
| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|id_servico| INT (PK, AI)| Identificador|
|nome_servico| VARCHAR(100)| Ex: Troca de óleo, Alinhamento|
|valor_padrao| DECIMAL(10,2)| Valor padrão de referência|

### Pecas
| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|id_peca| INT (PK, AI)| Identificador|
|descricao| VARCHAR(100)| Nome da peça|
|codigo_fabricante| VARCHAR(50)| Código do fabricante|

| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|preco_custo| DECIMAL(10,2)| Custo da peça|
|preco_venda| DECIMAL(10,2)| Valor de venda|
|quantidade_estoque| INT| Quantidade atual no estoque|
|unidade_medida| VARCHAR(10)| Ex: UN, KG, L|
|localizacao| VARCHAR(50)| Local de armazenamento|

### Ordens_Servico
| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|id_os| INT (PK, AI)| Identificador da OS|
|id_cliente| INT (FK)| Cliente da OS|
|id_veiculo| INT (FK)| Veículo em serviço|
|data_emissao| DATE| Data de abertura da OS|
|data_prevista_entrega| DATE| Previsão de entrega|
|status| VARCHAR(30)| Aberta, Em execução, Concluída, Cancelada|
|total_pecas| DECIMAL(10,2)| Soma do valor das peças|
|total_servicos| DECIMAL(10,2)| Soma do valor dos serviços|
|total_geral| DECIMAL(10,2)| Total geral da OS|

### Tabela de relação entre ordem de serviço e peças utilizadas.
| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|id_os_peca| INT (PK, AI)| Identificador|
|id_os| INT (FK)| Ordem de serviço|
|id_peca| INT (FK)| Peça utilizada|

| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|valor_unitario| DECIMAL(10,2)| Valor unitário no momento|
|subtotal| DECIMAL(10,2)| Total dessa peça (quantidade × valor_unitário)|

### Relacionamento:
Uma OS pode ter várias peças → (1:N)
OS Serviços
Tabela de relação entre ordem de serviço e serviços realizados.

| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|id_os_servico| INT (PK, AI)| Identificador|
|id_os| INT (FK)| Ordem de serviço|
|id_servico| INT (FK)| Serviço executado|
|id_funcionario| INT (FK)| Funcionário responsável|
|valor| DECIMAL(10,2)| Valor cobrado|

observacao TEXT Observações do serviço
Produções
Serve para registrar o andamento da produção (etapas).

| Campo | Tipo | Descrição |
|:------|:----:|:---------:|
|id_producao| INT (PK, AI)| Identificador|
|id_os| INT (FK)| Ordem de serviço|
|etapa| VARCHAR(50)| Ex: desmontagem, análise, montagem, teste|
|data_inicio| DATETIME| Início da etapa|
|data_fim| DATETIME| Fim da etapa|
|id_funcionario| INT (FK)| Funcionário responsável|
|status| VARCHAR(20)| Em andamento / Concluída|
|observacao| TEXT| Observações gerais|

Principais Relacionamentos (Resumo)
- Clientes → Veículos → 1:N
- Clientes → Ordens_Servico → 1:N
- Veículos → Ordens_Servico → 1:N
- Ordens_Servico → OS_Pecas / OS_Servicos / Producoes → 1:N
- Funcionarios → OS_Servicos / Producoes → 1:N

Modelo Conceitual (Entidades principais)
CLIENTE ← VEÍCULO ← ORDEM DE SERVIÇO → PEÇAS, SERVIÇOS, FUNCIONÁRIOS,
PRODUÇÃO.