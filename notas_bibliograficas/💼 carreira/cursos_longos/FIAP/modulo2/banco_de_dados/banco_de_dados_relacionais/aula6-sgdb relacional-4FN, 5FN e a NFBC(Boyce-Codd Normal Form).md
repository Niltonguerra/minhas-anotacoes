---
Date: 2025-12-24T16:24:00
tags:
  - fiap/modulo02/conexaoComBancoDeDados/DBRelacional
repositório:
---
# Notas conectadas:


# Resumo da nota:
nessa aula vimos a NFBC e também a 4FN e a 5FN, sendo que a NFBC é usada para quando a 3FN não é o bastante, sendo ela bem parecida com a 3FN mas mais restritiva, se diferenciando no sentido de que caso os dados se repi
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


## ### O que é um Determinante?

Em uma **Dependência Funcional**, representada matematicamente como $X \to Y$ (lê-se: "$X$ determina $Y$"), o **determinante** é o atributo (ou conjunto de atributos) que fica do lado esquerdo da seta ($X$).

- **Definição simples:** O determinante é o campo que "manda" na informação. Se eu souber o valor do determinante, eu consigo descobrir exatamente qual é o valor do atributo dependente.
    
- **Exemplo:** No seu sistema educacional, se tivermos $Matricula \to Nome\_Aluno$, o campo `Matricula` é o **determinante**. Ele determina quem é o aluno.


## BCNF  (Boyce-Codd Normal Form)
Todo **determinante** deve ser uma **chave candidata**. Se $A \rightarrow B$, então $A$ deve ser uma superchave.
 
### considerando a seguinte situação:
- Um Aluno pode ter vários Mentores (para assuntos diferentes).
- Cada Mentor é especialista em apenas **um** Assunto.
- Para um determinado Assunto, o Aluno tem apenas **um** Mentor.

### não está na FNBC
![[Pasted image 20260101064751.png|412]]

### anomalias geradas:
- **Redundância:** Toda vez que o Bruno (M01) aparecer, temos que escrever "React".
- **Anomalia de Atualização:** Se o Bruno mudar de especialidade para "Next.js", temos que atualizar várias linhas.
- **Anomalia de Inserção:** Não conseguimos cadastrar que o "Mentor M04 é especialista em Java" até que ele tenha pelo menos um aluno.

### está na FNBC

![[Pasted image 20260101065128.png|455]]

![[Pasted image 20260101065140.png|500]]





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