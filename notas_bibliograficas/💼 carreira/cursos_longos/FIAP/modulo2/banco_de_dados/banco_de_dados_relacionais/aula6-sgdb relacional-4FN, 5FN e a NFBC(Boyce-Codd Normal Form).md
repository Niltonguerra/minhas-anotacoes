---
Date: 2025-12-24T16:24:00
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

## o que é a chave candidata?
É uma chave que identifica o usuário mas não é usada para chave primária por exemplo:
- id_usuario
- cpf
- nome
- email

normalmente escolhe apenas uma e as outras viram chaves candidatas

## BCNF (Boyce-Codd Normal Form)
Todo **determinante** deve ser uma **chave candidata**. Se $A \rightarrow B$, então $A$ deve ser uma superchave.







