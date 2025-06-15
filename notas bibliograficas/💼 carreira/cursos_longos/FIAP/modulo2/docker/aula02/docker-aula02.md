---
Date: 2025-06-15T18:55:00
tags:
  - fiap/modulo02/docker
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

sempre escreva Dockerfile com o 'D' maiúsculo

no Dockerfile, sempre execute quando for instalar as dependências usando o pnpm
- sem instale assim: ``RUN pnpm install --frozen-lockfile``
	- isso permite que a instalação das dependências seja feita como sem atualizações inesperadas de dependências


o ``CMD[]`` é executado depois que o container já subiu, diferente dos outros comando do Dockerfile


- cada instrução dada no dockerfile é uma etapa de subida d