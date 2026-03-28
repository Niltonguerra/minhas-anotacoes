---
Date: 2026-03-28T12:25:00
tags:
  - fiap/modulo02/conexaoComBancoDeDados/DBColunares
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

Entra no terminal do cassandra:
```
cqlsh
```


lista todos os keyspaces(colunas das tabelas que você pode criar, já que o cassandra não tem tabelas(não vou ficar repetindo isso toda hora, mas achei legal comentar aqui)):
```
DESC keyspaces;
```


criar um keyspace:
```
CREATE KEYSPACE <nome_do_keyspace> 
	WITH replication = {
	 'class': '<estratégia_de_replicação>', 
	 'replication_factor': <fator_de_replicação> 
 };
```