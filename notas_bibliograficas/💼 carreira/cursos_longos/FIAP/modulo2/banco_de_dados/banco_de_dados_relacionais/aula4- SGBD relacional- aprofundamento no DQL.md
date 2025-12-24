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

todos os eventos com o id 17
```
SELECT * FROM ingresso WHERE id_evento=17 
```

todos os ingressos por menos de 100 
```
SELEC * FROM ingresso WHERE valor < 100;
```

todos os ingressos comprados exceto pelo cliente com id 1
```
SELEC * FROM ingresso WHERE id_cliente != 1;
```


todos os ingressos comprados pelo cliente um e 2
```
SELEC * FROM ingresso WHERE id_cliente IN (1,2)
```

todos os ingressos com preço entre 150 e 400 reais
```
SELEC * FROM ingresso WHERE valor BETWEEN 150 and 400;
```

todos os clientes que tem nome que começa com 'J'
```
SELEC * FROM cliente WHERE nome LIKE 'J%'
```


