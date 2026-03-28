---
Date: 2026-03-28T09:35:00
tags:
  - fiap/modulo02/conexaoComBancoDeDados
  - fiap/modulo02/conexaoComBancoDeDados/bancoDeDadosDocumental
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

mostrar databases:

```
show databases
```


criar e usar database:
```
use <nome_da_base_de_dados>
```

comparação:
coleções (no mongo) === tabelas(no sql)
documento(no mongo) === registro(no sql)

criar coleção:
```
db.createCollection("<nome_da_coleção>")
```


criar documento:
```
	db.<nome da coleção >.insertOne(<documento(ex:)>)
```