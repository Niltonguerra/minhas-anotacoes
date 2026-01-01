---
Date: 2025-09-02T09:50:00
tags:
  - fiap/modulo02/conexaoComBancoDeDados/DBRelacional
---
# Notas conectadas:


# Resumo da nota:
no máximo 350 caracteres no resumo.
exemplo de tamanho:
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.

# Tópicos:

comando para criar o sumário automaticamente: 
table of contents: Create table of contents


# Explicação dos tópicos:

## o que o índice faz?
- serve como um campo que serve para ser a base da busca do SQL, assim otimizando a pesquisa

## por padrão o sql já cria índice para PF e FK

- comando 'explain':
	- usado para a gente ver o plano de consulta de uma query
		- serve para você conseguir dados para poder estimar o custo de uma query
		- ex de uso: explain format=json select * from ingresso


## comando para criar um indice:
na criação:
```
CREATE TABLE table_name (
	colum_1 INT,
	column_2 VARCHAR(20),
	INDEX [index_name](column_1)
);
```

na atualização:
```
ALTER TABLE table_name 
	ADD INDEX[index_name](column_1);
```


remover um indice:
```

```
## boas práticas no banco de dados relacional:
![[Pasted image 20250902104742.png|500]]
- sempre que possível, fazer consultas via índices
- colocar índices em campos mais usados para fazer querys
- evitar usar o like
	- por que ele não é muito performático
- não colocar índice em todos os campos de uma tabela



## Como utilizar o EXPLAIN
serve para a gente saber o plano de consulta usado pela query para chegar no dado
```
EXPLAIN
	SELECT *
		FROM ingresso i
		JOIN cliente c ON i.id_cliente = c.id
		JOIN evento e ON i.id_evento = e.id
		WHERE status = 'PAGO'
```

para mais informações da consulta use:
```
EXPLAIN FORMAT=JSON
	SELECT *
		FROM ingresso i
		JOIN cliente c ON i.id_cliente = c.id
		JOIN evento e ON i.id_evento = e.id
		WHERE status = 'PAGO'
```


dados importantes dados pelo EXPLAIN que vale a pena explicar:
- query cost: custo da requisição