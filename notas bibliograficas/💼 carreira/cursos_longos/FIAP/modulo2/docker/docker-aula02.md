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

dockerfile
- usado para subir um único container


flags no docker:
## docker compose up
- `-d`
	- usado para rodar um container em segundo plano
	- ex: docker compose -f docker/docker-compose.local.yml up -d
- `--rm`
	- exclui o container depois de parar ele
	- ex:docker compose -f docker/docker-compose.local.yml up -rm
- `--name`
	- defini um nome para o container
	- docker compose -f docker/docker-compose.local.yml up -d
- `-it`
	- entra dentro do container
	- ex: docker compose -f docker/docker-compose.local.yml up -it
- `-f`
	- escolhe qual arquivo docker vai ser executado
	- ex: docker compose -f docker/docker-compose.local.yml up
- `-a` 
	- mostra coisas ocultas





