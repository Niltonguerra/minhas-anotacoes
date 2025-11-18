---
Date: 2025-11-18T06:46:00
tags:
  - tecnologia
repositório:
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


## comparação entre banco relacional e não relacional
### sgbd estrutural:
- mais rígido
- mais consistência nos dados
- menos sujeitos a erros
- os dados são estruturados
- é mais lento por conta que ele tem mais verificações e validações que o não estruturado, justamente por seu modelo mais rígido e seguro
- menos escalável horizontalmente, é preciso escalar verticalmente(mais CPU, RAM, mais memória e etc) assim sendo mais difícil de escalar
![[Pasted image 20251118065101.png|155]]


### sgbd não estrutural:
- menos rígido
- mais rápido para desenvolver
- menos consistência nos dados
- mais sujeitos a erros
- os dados são semi estruturados ou não-estruturados
- é mais rápido por conta que não tem tantas validações que o sgbd estruturado
- é mais fácil de escalar horizontalmente(aumentar o numero de contêineres, vms e etc cria varias máquinas menores )
- ![[Pasted image 20251118065041.png|350]]




## Banco de dados de Documentos:
- mongoDB
- couchDB relax
- amazon DocumentDB



## Banco de Dados de chave-valor
- redis
- amazon dynamoDB
- riak

## banco de dados de colunares
- cassandra
- google bigtable
- apache hbase 