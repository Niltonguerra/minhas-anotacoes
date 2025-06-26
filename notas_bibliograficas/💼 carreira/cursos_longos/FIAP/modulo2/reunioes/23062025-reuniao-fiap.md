---
tags:
  - fiap/modulo02/reuniao
Date: 2025-06-19T21:00:00
---

# pauta da reunião:
- vocês acham interessante colocar code review no projeto?✅
- perguntar como vamos inserir as imagens✅
	- IMGBB
- se vamos ter token de sessão?✅
	- vamos usar jwt? ✅
		- quanto tempo?
		- Resposta: 3 dia
- vamos colocar documentos?✅
	- resposta: sim


definir o que qual vai ser a o algoritmo de códificação que iremos usar:
- id
- md5
- uuid✅
- sha 256


- crom job
	- para notificar os usuários✅



- vamos usar migrations para nos comunicarmos com o banco de dados ou acham que não precisa?❌
- vamos fazer o sistema em português ou vamos fazer o sistema em inglês?
	- Resposta:Inglês✅
	- commit: Inglês✅
	- commit semântico ✅
- vamos implementar o Oauth 2.0?❌


- sugestão de novos campos para o post:
	- titulo:⭕
		- máximo: 70 caracteres
		- Mínimo: _20 caracteres_
		  
	- campo no post para links?✅⭕
		- array de string (2048 caracteres)
	- Introdução envolvente(introdução para chamar a atenção do leito)✅⭕
		- string (tamanho: 500 caracteres)
	- Hashtags relevantes para o conteúdo✅⭕
		- array de string (50 caracteres)
	- id do criador(FK do usuário)✅🤸‍♂️(precisa fazer a relação quando criar a tabela de usuário)
	- status da matéria(Rascunho, publicado) ❌
	- campo de video❌
	-  implementar um campo de search ✅
		- string
		- 1000 caracteres
	- slug (para a montagem da página)❌
	- estimativa de tempo de leitura()✅
		- number
	- quantidade de visualizações ❌
	- reações (Estrutura para likes, curtidas, emojis, etc.)❌
	-  agendamento_publicacao (nunca fiz algo parecido, mas parece interressante de se colocar)(utima coisa para se colocar no projeto)🤸‍♂️
	- id de estilo de estilização para determinado conteúdo✅
		- string

- o usuário vai fazer login

- sugestão de novos campos para o usuário:
	- status(Ativo, inativo, banido, etc.)❌
	- nome de perfil(nome pelo qual gostaria de ser chamado)❌
	- nome✅
	- foto do usuário ✅
		-  string (2048 caracteres)
	- genero ❌
	- telefone ❌
	- email ✅
		- string (254 caracteres)
	- preferencias(para personalizar o conteúdo) ❌ 
	- descrição do usuário❌
	- data_nascimento❌
	- - **ultimo_login**❌
	- tentativas_login❌
	- redes sociais ✅
		- string (254 caracteres)

refinar as rotas:
- ver o que vai ser entregue em cada rota:

