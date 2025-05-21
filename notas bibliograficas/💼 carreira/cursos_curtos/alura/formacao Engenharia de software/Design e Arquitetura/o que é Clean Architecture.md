---
Date: 2025-05-20T21:00:00
tags:
  - tecnologia/ArquiteturaDeSoftware/CleanArchitecture
---
# Notas conectadas:


# Resumo da nota:
no máximo 350 caracteres no resumo.
exemplo de tamanho:
ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss

# Tópicos:

comando para criar o sumário automaticamente: 
table of contents: Create table of contents



# Explicação dos tópicos:

![[Pasted image 20250520210151.png]]

- as camadas mais internas não devem conhecer as camadas mais externa

## definição dos termos:
- o que é uma entidade?
	- e um tipo de classe que tem uma identificação
		- por exemplo: uma pessoa, ou serviço
	- nela fica as regras de negócio
		- por exemplo: precisa ter +18 para se cadastrar
	- 
- o que é um use case?
	- é uma 'jornada do usuário', por exemplo uma ação que o usuário precisa fazer
		- por exemplo: a jornada para fazer uma conta, e todas as etapas para se cadastrar
			- usando o exemplo acima, se tivesse uma regra para poder se cadastrar apenas com +18 aqui ficaria informado onde ele passaria para fazer essa validação
- camada de controller, gateway, presentation
	- essa camada é ainda mais externa que o use case, por exemplo, você tem um controller que gerencia a rota qu 



