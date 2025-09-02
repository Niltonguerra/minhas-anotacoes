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

## por padrão o sql já cria índice para PF e FK


- comando explain:
	- usado para a gente ver o plano de consulta de uma query
		- serve para você conseguir dados para poder estimar o custo de uma query
		- ex de uso: explain format=json select * from ingresso
## boas práticas no banco de dados relacional:
![[Pasted image 20250902104742.png]]
- sempre que possível, fazer consultas via índices
- 