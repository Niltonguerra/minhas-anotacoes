---
Date: 2025-05-03T18:02:00
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


## Entidades
- quando se coloca um id em um registro ele virá uma entidade
![[Pasted image 20250503180322.png]]

![[Pasted image 20250503180348.png]]


## Quando usar uma entidade e quando usar um objeto de valor
### ✅ Use um **Objeto de Valor** quando:

- **A identidade não importa**: o que importa são os **atributos**.
- É **imutável**: se precisar mudar, você cria um novo.
- Pode ser comparado por **igualdade de valores**.
- É reutilizável em vários contextos do domínio.

📌 **Exemplos comuns**:
- `Endereço` (rua, cidade, estado, CEP)
- `CPF`, `CNPJ`
- `Dinheiro` (valor, moeda)
- `Email`, `Telefone`
---
### ✅ Use uma **Entidade** quando:
- Precisa de uma **identidade única** (geralmente um ID).
- A **identidade persiste ao longo do tempo**, mesmo que atributos mudem.
- É parte essencial do seu modelo de negócio.

📌 **Exemplos comuns**:
- `Usuário`
- `Pedido`
- `Produto`
- `Aluno`, `Funcionário`
---
### 🔁 Comparação rápida:

| Critério         | Objeto de Valor     | Entidade                   |
| ---------------- | ------------------- | -------------------------- |
| Identidade       | Não tem             | Tem (ex: ID)               |
| Comparação       | Por valor           | Por identidade             |
| Imutabilidade    | Sim                 | Geralmente mutável         |
| Persistência     | Geralmente embutido | Requer repositório próprio |
| Exemplo clássico | Dinheiro, Endereço  | Cliente, Pedido            |
### 🧠 Resumo Filosófico:
####  Objetos de valor **são definidos por seus atributos**, enquanto entidades **são definidas por sua identidade**.