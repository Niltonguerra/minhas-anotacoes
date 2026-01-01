---
Date: 2025-12-24T16:24:00
tags:
  - fiap/modulo02/conexaoComBancoDeDados/DBRelacional
repositório:
---
# Notas conectadas:


# Resumo da nota:
nessa aula vimos a NFBC e também a 4FN e a 5FN, sendo que a NFBC é usada para quando a 3FN não é o bastante, sendo usada
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

## BCNF  (Boyce-Codd Normal Form)
Todo **determinante** deve ser uma **chave candidata**. Se $A \rightarrow B$, então $A$ deve ser uma superchave.
 
![[Pasted image 20260101053100.png|500]]
![[Pasted image 20260101053110.png|500]]





![[Pasted image 20260101053139.png|500]]
![[Pasted image 20260101053150.png|500]]



## 4FN- 4 forma normal
Uma tabela não deve possuir mais de uma dependência multivalorada
é feito isso para evitar repetição dos valores, permite que seja otimizado o espaço evitando duplicidade de dados e evitando duplicidade e inscrições erradas e inconsistência dos dados
![[Pasted image 20260101054628.png|500]]


## 5FN - 5 forma normal:
condição: Não puder ser decomposta em tabelas menores que, quando juntadas (JOIN), resultem em dados "fantasmas" ou percam informações originais.
- essa FN é para ser usada quando se estiver fazendo JOIN's no SGBD
- basicamente a 5FN prevê que se você quebrar uma tabela em tabelas menores, que é uma boa prática de se fazer, as tabelas menores  não devem trazer dados fantasmas quando for feito a reconstrução da tabela original via inner join 
![[Pasted image 20260101055747.png|469]]


### está na 5FN

![[Pasted image 20260101055813.png|122]]
![[Pasted image 20260101055823.png|122]] 
![[Pasted image 20260101055849.png|122]]