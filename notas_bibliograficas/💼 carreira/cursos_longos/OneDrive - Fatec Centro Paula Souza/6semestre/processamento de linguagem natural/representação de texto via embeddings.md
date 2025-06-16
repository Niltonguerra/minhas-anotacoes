---
Date: 2024-11-08
tags:
  - IA
  - processamentoDeLiguagemNatural
---
# Notas conectadas:

# Resumo da nota:



# Tópicos:

* item 1



# Explicação dos tópicos:

## Bow ou TF-IDF:
Desvantagens:
- Exemplo:
	- a chuva molhou meus sapatos e minhas meias ---> 01101
	- meias sapatos minhas meus e chuva molhou --> 000111


- Incapacidade de capturar relações entre as palavras
- ausência de semântica
- Tamanho texto.
Existem outras formas de realizar a vetorização:

## outro modelo de linguagem de processamento natural:
pesquisar como é caracterizado cada dimensão de um algoritmos de interpretação de texto.


ler  a documentação da biblioteca gensim: https://radimrehurek.com/gensim/auto_examples/index.html

ler o livro processamento de linguagem natural: [Processamento de Linguagem Natural (brasileiraspln.com)](https://brasileiraspln.com/livro-pln/2a-edicao/ "https://brasileiraspln.com/livro-pln/2a-edicao/")
![[Pasted image 20241108194859.png]]


qual é o ponto de custo beneficio
Resposta: não sei, mas muitos usam 100 pontos.

tem como descobrir esse ponto de custo beneficio
R: sim, vai testando e comparando 


## estudamos de três tipos de modelos de inteligência

### modelo 1 - word2Vec
verifica a palavra e depois verifica as outras palavras se elas se encaixam nessa palavra para assim analisar o sentido do texto 
- verifica a palavra com outras palavras para depois analisar o contexto e validar o sentido do texto
- vetorização com análise de proximidade nas palavras próximas ao vocábulo escolhido

ex:
- rei: verificar as 5 palavras antes e 5 palavras depois 
- rainha: verificar as 5 palavras antes e 5 palavras depois.


### modelo 2 - Glove (Global vector words Representation) - 
análise de proximidade das palavras globalmente
- calcula a probabilidade de uma palavra aparecer perto dele, por exemplo, qual é a probabilidade de uma outra palavra aparecer perto de outra palavra
	- calcula de acordo com as palavras próximas, por exemplo ele olha primeiro para o que está próximo para depois olhar para a palavra

- criado por stanford


### modelo 3 - fastText
- criado pelo facebook
- faz uma quebra da plavra(n-grama)
- escolhe uma quantidade de letras para analisar as palavras
	- o padrão é 3 letras

- ex: 
	- gato - gat +ato
	- gatinho - gat + atin + tin+ inh + nho
	- Leopardo - leo + eop + ...
	- gatão - gat + atã + tão