- Expressões regulares – mecanismo para identificação de sequencias de caracter 
    
    - Serve para encontrar padrões em texto – palavras. 
        
    - Serve para remover caracter indesejais 
        
    

Segmentação e Tokenização - modelo pré-treinado (download de modelo no idioma) se basea em expressões regulares 

Semântica - treianar o modelo para identificar proximidade, baseado em vetorização 

- Palavra – vetor (valor numerico) -- buscar a proximidade de outros vetores (valores numericos) 
    

Ferramentas e bibliotecas: 

- Spacy - tokenização, lematização, definição de dependências morfosintática (reconhecimento de entidades).  
    
    - Mais rápida e eficiente 
        
- NLTK – modelo de análise sintatica e semantica; 
    
    - Tokenizção e lematização, cálculos de frequências 
        
    - Base de dados corpus/corporas - treinar as nossas aplicações 
        
    - Análise de textos acadêmicos - esta biblioteca tem um base de dados pré treinada dentro da área acadêmica  
        
- Hugging Face Transformer 
    
    - Contém modelo pre treinados sendo utilizados pelo BERT e GPT 
        
    - Técnicas mais avançadas. 
        

|   |   |   |   |   |   |   |
|---|---|---|---|---|---|---|
|O|Menino|Correu|para|pegar|o|onibus.|

|   |   |   |   |   |   |   |
|---|---|---|---|---|---|---|
||Menino|Correu||pegar||onibus.|