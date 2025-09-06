---
Date: ""
tags:
---
# Resumo da nota:
no máximo 350 caracteres no resumo.
exemplo de tamanho:
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.

# Tópicos:

comando para criar o sumário automaticamente: 
table of contents: Create table of contents



# Explicação dos tópicos:
## contexto básico:
### 1. O que é Engenharia de Prompt

Engenharia de Prompt é o processo de **escrever instruções claras e estruturadas para modelos de linguagem (LLMs)** para obter respostas úteis, consistentes e relevantes.  
Pense nela como “programar em linguagem natural”.

---
### 2. Conceitos Fundamentais

#### 2.1. Prompt

É o texto que você envia ao modelo.  
Exemplo simples:

> “Explique a fotossíntese de forma simples.”

#### 2.2. Contexto

É toda a informação adicional que você passa para o modelo interpretar melhor a tarefa.  
Exemplo:

> “Você é um professor de ciências explicando para alunos do 5º ano. Explique a fotossíntese de forma simples.”

#### 2.3. Saída Esperada

Sempre deixe claro **como** você quer a resposta.  
Exemplo:

> “Liste em tópicos os passos da fotossíntese em linguagem simples.”

---

### 3. Estrutura Básica de um Bom Prompt

Um bom prompt normalmente tem:

1. **Papel (Role)** → quem o modelo deve ser
    
2. **Instrução (Task)** → o que fazer
    
3. **Contexto (Context)** → informações adicionais
    
4. **Formato de saída (Output)** → como apresentar
    

Exemplo:

> Você é um **professor de química**.  
> **Explique** a diferença entre mistura homogênea e heterogênea.  
> Use **exemplos do dia a dia** e responda em **até 5 linhas**.

---

### 4. Técnicas Básicas

- **Seja específico** → “explique em 3 passos” é melhor que “explique”.
    
- **Forneça exemplos** → ajuda o modelo a entender o tom ou estilo.
    
- **Divida em etapas** → peça que pense passo a passo (_chain of thought_).
    
- **Peça formato de saída** → tabela, lista, resumo, código.
    

---

### 5. Exemplos Práticos

#### Exemplo 1 – Ruim x Bom

❌ Ruim:

> Explique fotossíntese.

✅ Bom:

> Você é um professor de biologia explicando para alunos do ensino fundamental.  
> Explique o que é a fotossíntese em linguagem simples.  
> Responda em tópicos, com no máximo 4 linhas.

---

### 6. Armadilhas Comuns

- **Prompts vagos** → geram respostas genéricas.
    
- **Falta de restrição de formato** → respostas longas demais ou confusas.
    
- **Não dar contexto suficiente** → modelo pode inventar (alucinar).
    

---


### 7.boas práticas:
- Seja **específico e claro**.
- Divida tarefas complexas em etapas.
	- nisso depois vai surgir os tão famosos agentes
- Limite tamanho da resposta se necessário 
	- tente deixar o prompt com no máximo 150 caracteres mais ou menos.
		- isso depende, mas falo isso por que normalmente os prompts são quebrados nesse tamanho para facilitar a leitura pela llm
- Use exemplos para resultados consistentes.
    - isso ajuda a contextualizar a LLM sobre o  problema e ajudando nos princípios citados no ponto 3
- Teste e refine o prompt (**iterativo**).
	- é o de sempre, né, CI/CD

### 8. técnicas de prompt
- **Zero-shot:** Sem exemplos, apenas instrução direta.
- **Few-shot:** Fornece exemplos para guiar o modelo.
- **Chain-of-thought:** Solicita pensamento passo a passo antes da resposta.
- **Role prompting:** Define o papel do modelo para ajustar estilo e tom.
- **Controlar saída:** Especifique formato: lista, tabela, JSON, código, resumo.



### 9.como as partes se comunicam entre si?
- o que compoe um bom prompt é você conseguir contextualizar a AI e saber explicar o que você quer para ela, você conseguindo fazer isso, pronto, você criou um bom prompt, tendo isso em vista explicando como cada parte de um bom prompt interage para gerar isso:
	- papel
		- faz com que a IA se coloque como um profissional daquela área para responder a sua pergunta, assim dando um contexto que você espera uma resposta de um profissional da área e não de qualquer um 
	- 

### 10.ele usa outras tecnologias(recursos) do meio dele? se sim, quais?
- sim, mas não ele usa tecnologias para interpretação de linguagem natural dentro de si, mas como estou com um pouco de presa não vou entrar nesse mérito, principalmente por conta que não acho que é tão importante me aprofundar nisso


## quais são suas subpartes e como elas integram?

- **Objetivo**: guiar o modelo para produzir a saída desejada.
    
- **Como funciona**: o modelo responde com base no texto do prompt + contexto.
    
- **Técnicas básicas**:
    
    - Clareza e especificidade no pedido.
        
    - Estruturar o prompt (instrução + contexto + formato de resposta).
        
    - Usar exemplos (“few-shot prompting”) para ensinar o modelo.
        
- **Técnicas avançadas**:
    
    - _Chain-of-thought_ (forçar raciocínio passo a passo).
        
    - _Role prompting_ (atribuir papel ao modelo, ex: “você é um professor”).
        
    - _Self-consistency_ (gerar várias respostas e escolher a melhor).
        
- **Aplicações**:
    
    - Chatbots, geração de texto, resumo, análise de dados, automação.