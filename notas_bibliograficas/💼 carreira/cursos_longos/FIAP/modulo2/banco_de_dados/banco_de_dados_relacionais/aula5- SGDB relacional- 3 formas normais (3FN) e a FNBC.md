---
Date: 2025-12-24T15:25:00
tags:
  - fiap/modulo02/conexaoComBancoDeDados/DBRelacional
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



## 1 forma normal:
não deve se armazenar valores compostos dentro de um campo de uma tabela, quando se tem mais de um numero de telefone o ideal é criar um novo campo para o telefone ao invés de armazenar dentro do mesmo campo no banco de dados colocando apenas uma virgula para separar eles:

![[Pasted image 20251224153507.png|500]]


## 2 forma normal:
nenhum atributo não chave pode depender de apenas parte de uma chave primária composta
![[Pasted image 20251224160223.png|500]]


## 3 forma normal:
ocorre quando uma coluna, além de depender da chave primária de uma tabela, depende de outra coluna ou conjunto de colunas da tabela
![[Pasted image 20251224162254.png|500]]


