---
Date: 2025-12-24T13:25:00
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

## pesquisa com limite:

```
SELECT * FROM ingresso LIMIT 5;
```

## pesquisa onde os dados são diferentes:
![[Pasted image 20251224134037.png]]

```
SELECT DISTINCT nome FROM cliente
```



##  filtrar os dados:
![[Pasted image 20251224134224.png|500]]

### operadores do WHERE
![[Pasted image 20251224134237.png|500]]
![[Pasted image 20251224134556.png|500]]

```
SELECT * FROM ingresso WHERE valor > 100
```


### exemplos de select:

SELECT **