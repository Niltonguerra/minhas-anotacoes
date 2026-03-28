---
Date: ""
tags: []
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

## Cassandra:
### criador:
- Facebook
- 2008

### características no Cassandra

- escalabilidade linear "(por conta de ser no sql)"
- alta disponibilidade
	- por conta da forma como foi feito, não sei descrever, mas se algum dia alguém te perguntar, fale que ele tem duplicidade de dados (mesmo que ele não tenha), por que embora ele não mostre para a gente que tem duplicidade, a forma como foi construído faz com que ele tenha duplicidade de dados, mas seja otimizado para não ocupar tanto espaço, sei que é estranho, mas é isso que acontece
- tolerância a falhas
- modelo de dados flexível
- suporte a consultas distribuídas


## arquiteturas de dados:
![[Pasted image 20260328114127.png]]
- ### centralized system (sistemas centralizados)
	- se o nó maior cair, tudo cai

- ### decentralizes system (sistemas descentralizados)
	- tem nós de centralização, mas não é só um

- ### distributed system (sistemas distribuídos)
	- todos os nós tem visão uns dos outros.
	- #### essa é a arquitetura do cassandra 


## como modelar um SGBD colunar?
- tabelas devem seguir as consultas desejadas, e não o contrário
- não existe join, integridade referencial ou chaves estrangeiras
- denormalização
	- é o ato de depois de a