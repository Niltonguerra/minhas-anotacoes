Módulo de Processamento de Texto 

- Aula 04  - Limpeza de texto E normalização:  
    
- Aula 05 - Representação de Texto (bag of word):  
    
- Aula 06 – Embeddings de palavras:  
    
- Aula 07 – Modelagem de tópicos com LDA (Latent Dirichlet Allocation):  
    

Conteúdo de hoje: 

1. Limpeza da dados textuais – Extrair tudo aquilo que não contribui para a comunicação 
    
    1. O que são dados sujos? 
        
        1. Erros de digitação: qui foi isso? 
            
        2. Informações irrelevantes: emojis e figurinhas 
            
        3. Variações de palavras: carro e automóvel 
            
        4. Caracteres especiais: #empregonovo, #fatec 
            
    2. Cuidados com a limpeza: 
        
        1. Abreviações: QLQ, VC, PROF, 6aF 
            
        2. Pontuações: Eu amo a aula de sexta!!!!! 
            
        3. Textos misto com emojis e outros idiomas: eu LOVE vc! 
            
        4. Tags HTML (mineração e raspagem de dados) : <p>A aula de sexta é a melhor do mundo.</p>  
            
2. Normalização - Remover os caracteres especiais, pontuação e padronizar tudo em  (!@#$%¨&*()_+`{^}<>:?), deixando tudo em letra maiúscula ou minúscula  
    
    1. Identificar as sujeiras e ruídos nos dados: elementos no texto que não vão contribuir para o significado da comunicação 
        
    2. Utilizar expressões regulares para eliminar as sujeiras e ruídos. 
        
    3. Normaliza em letras maiúsculas ou minúsculas 
        

Obs: expressões regulares: Ver os sites de referências passados no chata da aula 

3. Tokenização - dividir um texto nas menores unidades de significados, ou seja, palavras. 
    
    1. Primeiro passo essencial para a compreensão de uma linguagem natural 
        
    2. Como isso é feito: 
        
        1. Por espaço 
            
        2. Por pontuação 
            
        3. Biblioteca PLN – nós vamos usar este  
            
4. Remoção StopWords – retirar as palavras que contém pouco valor semântico 
    
    1. Reduzir o ruído 
        
    2. Economia de recursos computacionais 
        
    3. Maior precisão no modelo de processamento 
        
    4. É feito baseando em uma lista pre definidas de StopWords 
        
        1. Obs: elementos iteravel no Python 
            
            1. Lista: ["aqsd","asdfgre34","a","a"....]  - pode modificar qualquer elemento 
                
            2. Tupla:("aqsd","asdfgre34","a","a"....) - Não pode modificar ela 
                
            3. Dicionário: {'rotulo':'valor do rotulo','nome do usuário':'Rodolfo',"Idade":"40","Idade":"40"} - pode modificar desde que modifique o rotulo ou o valor 
                
            4. Conjunto: {elemento1, elemento 2, elemento 3} - não se repetem  
                
5. Stemming ou Lematização - redução para a raiz da palavra (verbo) 
    
    1. Ex. Correr - corrido, correu, correrá,... = corr ou correr 
        
    2. Ex. Andar -  andei, andou, andaram, andará,...= and ou andar 
        
    3. Processo por Stemmming – reduz para o raiz (corr... ou and... ou cant... ou dorm...) 
        
        1. Limitação - as raizes das palavras podem ficar incompletas ou irreconhesíveis 
            
    4. Processo por Lematização - normalizando as palavras para suas forma regular (correr, andar, fugir, cantar,...) 
        
        1. Vantagem: facilidade em ter análise assertiva da palavra. 
            
    5. Por que precisamos disso? 
        
        1. Simplificar e padronizar a palavras – economia dos recursos computacionais