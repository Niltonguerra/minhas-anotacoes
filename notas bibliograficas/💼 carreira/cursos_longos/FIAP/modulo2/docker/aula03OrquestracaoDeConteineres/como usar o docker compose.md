---
Date: 2025-06-16T05:48:00
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

exemplo de docker compose
```
version:3.9

volumes:
	mysql_data:{}

services:
	mysql:
		image:mysql:8.0
		volumes:
			- mysql_data:/var/lib/mysql
		restart:always 
		environment:
			MYSQL_ROOT_PASSWORD: root
			MYSQL_DATABASE: wordpress
			MYSQL_USER: wordpress
			MYSQL_PASSWORD:wordpress
	wordpress:
		depends_on:
			- mysql
		image:wordpress:lastest
		ports:
			- "80:80"
		restart: always
		environment:
			WORDPRESS_DB_HOST: mysql:3306
			WORDPRESS_DB_USER: wordpress
			WORDPRESS_DB_PASSWORD: wordpress
			WORDPRESS_DB_NAME: wordpress
		volumes:
			- ./wordpress:/var/www/html
```

- o restart é usado para reiniciar o container caso aconteça algum erro na inicialização do mesmo


