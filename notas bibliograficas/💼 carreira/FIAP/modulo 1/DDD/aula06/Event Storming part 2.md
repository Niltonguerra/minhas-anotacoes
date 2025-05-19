---
Date: 2025-05-19T19:47:00
tags:
  - tecnologia/DDD
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
## continuação do Event Storming...
### 5. definir o comando
![[Pasted image 20250519194916.png]]
#### comandos são no presente, como:
- cria atividade
- envia atividade

### 6. criar os atores/politicas
![[Pasted image 20250519194916.png]]
- aqui é o ator é o professor
- aqui a politica é o 'notificar o aluno de nova atividade'
	- ela pode ser um serviço/api/lógica, básicamente um sistema 

- um comando sempre precisa de um um ator ou politica


### 7. definição  do modelo de leitura
![[Pasted image 20250519201433.png]]
- o modelo de leitura se refere a interface do usuário
- o modelo de leitura sempre deve vir antes do comando 


### 8. como definir o agregado 
![[Pasted image 20250519203052.png]]

- deixa de melhor visualização o diagrama
- você faz com que os outros elementos orbitem o agregado



### 9. como criar o contexto delimitado
![[Pasted image 20250519203318.png]]

por que é importante definir um contexto delimitado?
para que possa definir um escopo para onde um time vai atuar

#### como definir um contexto delimitado?
eles costumam se relacionar pelos seguintes itens
- Linguagem ubíqua comum.
- Regras de negócio específicas.
- Entidades e agregados comuns.

#### exemplos de contexto delimitado:
- **Contexto de Catálogo**
    - Eventos: "Produto Cadastrado", "Produto Atualizado"
    - Responsável por manter os dados dos produtos.

- **Contexto de Carrinho de Compras**
    - Eventos: "Item Adicionado ao Carrinho", "Carrinho Abandonado"

- **Contexto de Pedido**
    - Eventos: "Pedido Realizado", "Pedido Cancelado"

- **Contexto de Pagamento**
    - Eventos: "Pagamento Aprovado", "Pagamento Rejeitado"