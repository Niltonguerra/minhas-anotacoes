---
Data: 2024-10-17
tags:
  - arquitetura_em_nuvem
  - computacao_nuvem
---

# Arquivos vinculados:
[[resumo do video 2]]

# Resumo do modulo:


# Tópicos:
1. idades inteligentes
2. tendências e desafios
3. estratégia de dados - visão técnica
4. disponibilidade das aplicações


## 1. cidades inteligentes

- sempre irá melhorar a vida das pessoas
    
    - melhorar viagens do ponto a ao ponto b


- manifestações da cidade inteligente
    
    - Mais dados de gestão pública
    - Mais dispositivos IOT
    - dados territoriais    
    - dados climáticos
    - dados demográficos

	**cidades estão melhorando aos poucos, se tornando cada vez mais inteligentes**
## 2. tendências e desafios

	teremos 10x mais dados em 2030 do que em 2010
##### o que esperar para o futuro:
- Cibersegurança e consciência da privacidade
- percepção mais fluída entre o privado e o público
- inteligência artificial aplicada as necessidades das cidades
- criação de novos ecossistemas e plataformas de colaboração

	**os dados são considerados um ativo e não um custo segundo a apresentação**

##### Desafios:
* diversidade de perfis das cidades(tamanho da população, conectividade, arrecadação, etc)
	* exemplo: cidades agrícolas, cidades turísticas, cidades químicas, cidades industriais e etc.
	* De tipos de pessoas
	* De quantidade de pessoas
	* diversos tipos de diversidade
* padronização e governança dos dados
* mão de obra capacitada de processamento
* quais insights podem ser gerados a partir das fontes já existentes

#### valor dos dados
* os dados estão aumentando exponencialmente
* existem diversos tipos de dados, estruturados e não estruturados
* eles são consumidos por diversas pessoas
* acessado por muitas aplicações


## 3. estratégia de dados - visão técnica

#### data Lake
* repositório centralizado que permite armazenamento de dados estruturados e não estruturados.
	* existe o catálogo, que faz uma padronização dos dados para exibi-los como um 'catalogo' de dados para depois serem consumidos.

#### Ferramentas disponíveis em cada etapa:

* **Visualisação, engajamento, aprendizado de máquina**
	* awsa data exchange
	* amazon quicksight
	* amazon pinpoint
	* amazon sageMaker
	* amazon comprehend
	* amazon Lex
	* amazon polly
	* amazon rekognition
	* amazon tralate

* **analytics**
	* amazon redshift
	* amazon emr(spark & hadoop)
	* aws glue(spark & python)
	* amazon athena
	* amazon opensearch service
	* amazon kinesis data analytics

* **data Lake infraestrutura & governança**
	* amazon s3 glacier
	* aws lake formation
	* aws glue

* **Ingestão dos dados**
	* aws dms 
	* aws snowball
	* aws snowmobile
	* amazon kinesis data firehose
	* amazon kinesis data streams
	* amazon managed streaming for apache kafka (amazon msk)


### Pensamento Data-Driven
-  Forma de organizar e escolher os recursos
- pensamento movido a dados
- É a ação de estabelecer um pipeline de dados **robusta** para capturar e armazenar todos os dados gerados
- tem como objetivo prover insights de negócio a partir dos dados coletados



### Como construir um data Lake
-  **Escolher a interface que irá consumir**: (se é desktop, mobile, web e etc) além de escolher como ele será acessado(API Rest/ RestFUL, Graph MQ  e etc)
* **segurança**: como iremos tratar a segurança dos dados
* **ingestão**: como será armazenado os dados, onde será armazenado os dados
* **catálogo e pesquisa**:  expõe os dados para consumo 
* **análises e aprendizado de máquina**: oferece para o consumidor final recursos para personalizar o consumo desses dados, como ferramentas para 

## 4. disponibilidade das aplicações

### Como validar se os dados estão funcionando 
*por que validar isso? R: para ter maior disponibilidade, resiliência e performance*
- logs
	- verificar onde está acontecendo os erros
- métricas
	- alinhar como o sistema irá se comportar e quais são as métricas de sucesso da aplicação
- rastreabilidade
	- descobrir onde está acontecendo o erro


