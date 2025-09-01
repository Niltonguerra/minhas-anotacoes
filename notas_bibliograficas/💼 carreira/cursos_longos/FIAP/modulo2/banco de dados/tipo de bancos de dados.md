---
Date: 2025-09-01T12:56:00
tags:
  - fiap/modulo02/conexaoComBancoDeDados
  - fiap/modulo02/conexaoComBancoDeDados/tiposDeBancoDeDados
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

## banco de dados relacionais e não relacionais
- banco de dados relacionais são menos performáticos que os não relacionais, mas é uma diferença muito pequena
	- por que o não relacional não tem tantos processos para fazer as consultas no banco de dados quanto o relacional
- banco de dados não relacional é mais escalável
	- é mais fácil para escalonamento horizontal
![[Pasted image 20250901125738.png]]




![[Pasted image 20250901154108.png]]


## quando usar cada modelo de banco de dados?

exemplo de definição para o banco de dados:
### caso de exemplo:
- desenvolvimento de um sistema educacional:
	- banco relacional:
		- pontos positivos:
			- permite uma maior consistência de informações
			- permite uma maior padronização dos dados
			- facilita a criação das querys
		- pontos negativos
			- baixa flexibilidade
			- menor performance
			- menor escalabilidade
- #### vale a pena usar DB relacional por que como é um sistema de educação e não vai precisar de muita escalabilidade ou de suprir milhões de requisições, mas sim apenas algumas milhares de requisições, e por oferecer varias vantagens como facilidade na criação de querys é melhor usar o banco de dados relacional

### caso de exemplo:
 - desenvolvimento de uma rede social:
	 - banco de dados não relacional:
		 - pontos positivos:
			 - flexibilidade de esquema
			 - facilidade de escalabilidade horizontal
			 - velocidade de desenvolvimento
		 - pontos negativos:
			 - mais difícil fazer um relacionamento entre diferentes entidades
			 - é mais complexo gerenciar transações e consistência
- #### nesse caso vale mais apena usar o banco de dados não relacional por conta que ele é mais escalável horizontalmente e sendo uma rede social é essencial ter isso no sistema, mesmo que seja mais 