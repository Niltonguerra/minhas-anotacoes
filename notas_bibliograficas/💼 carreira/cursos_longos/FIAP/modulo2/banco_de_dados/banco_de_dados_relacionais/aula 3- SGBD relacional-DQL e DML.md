---
Date: 2025-12-24T12:46:00
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




## comandos de pesquisa no banco de dados:
```
SELECT  * FROM cliente;
```



## comando para inserir um dado na tabela:
```
INSERT INTO cliente (id,nome, dt_nasc, cpf) values (1,'Lucas Ferreira', '1993-07-22', '12233344455');
```

inserindo vários dados de uma vez:
![[Pasted image 20251224131456.png|500]]


## comando para atualizar:
```
UPDATE cliente SET nome = 'João Pedro' where  id=2;
```