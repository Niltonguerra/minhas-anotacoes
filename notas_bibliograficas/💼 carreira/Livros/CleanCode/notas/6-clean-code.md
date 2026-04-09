---
Date: 2026-04-09T08:21:00
tags:
  - Livros/CleanCode
Livro: CleanCode
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

- não use palavras vagas como info e data
ex:
ProductData/ProductInfo


exemplo de função ambigua:


❌
```
getActicveAccount(); 
getActiveAccounts();
getActiveAccountInfo();
```
- difícil de entender o uso das funções


✅
```
getActiveAccount(); 
getAllActiveAccounts();
getActiveAccountMetadata();
```
- mas claro para que cada função serve


- crie variáveis que sejam nomeáveis
❌
![[Pasted image 20260409085149.png]]

✅
![[Pasted image 20260409085158.png]]



- para regra geral não use variaveis não declarativas(que não declaram nada)
	- variaveis de uma letra
		- ex: j,i, e etc




- hoje em dia, não é mais necessário colocar prefixos e pós-fixo nas variáveis:
- 