---
Date: ""
tags:
---
# Resumo da nota:
no máximo 350 caracteres no resumo.
exemplo de tamanho:
ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss

# Tópicos:

comando para criar o sumário automaticamente: 
table of contents: Create table of contents



# Explicação dos tópicos:

## por que foi criado?

### quais são os princípios desse assunto? 

#### Largest Contentful Paint (LCP)
- mede o tempo do maior elemento visual ser renderizado
- deve ser menor que 2.5 segundos
##### Como melhorar:
- Otimize Imagens, 
	- use a tag <Image/> do Next.js que otimiza a imagem da melhor forma possivel

- Otimize imagens (compressão, formatos modernos como WebP).
	- evite de usar jpg ou png, use formatos otimizados para a web

- Use carregamento assíncrono para scripts e fontes.
	- use  `loading="lazy"` nas imagens para otimizar o seu carregamento

- Melhore o tempo de resposta do servidor.
	- gaste mais dinheiro com máquinas melhores, kkk 😂

- Use um CDN.
##### o que é CDN?




#### Cumulative Layout Shift (CLS)
- mede a quantidade de alterações na página enquanto é carregada
	- é aquele movimento inesperado quando algo sobe ou desse em uma página enquanto é carregado
- deve ser menor que 0.1
##### Como melhorar:
- reverse espaço fixo para imagens, vídeos e anúncios
- crie fallback adequados para coisas que carreguem lentamente
- evite colocar conteúdo dinâmico em cima de conteúdo fixo




#### First Input Delay (FID)
- mede o tempo da primeira interação do usuário e o site
- deve ser menor que 0.1 segundos
- em prevê vai ser substituído pelo INP
##### Como melhorar:
- Divida JavaScript em pequenos chunks (code splitting).
- Reduza o uso de JavaScript pesado.
- Adie scripts não críticos.

##### como dividir o código em pequenos chunks?




#### Interaction to Next Paint (INP)
- calcula a responsividade da página, não apenas a primeria,
- deve ser menor que 0,2 segundos
##### Como melhorar:
- Similar às dicas do FID
	- 
- Otimizar JavaScript.
	- compilar o código
- Usar web workers.
- Evitar tarefas longas no thread principal.

##### Como usar web Workers?

##### Como trabalhar com theads no frontend?
- esse vai ser um estudo posterior 

### o que norteou o desenvolvimento do mesmo?
- melhorar a experiencia do usuário em aplicações web

---
## quais são suas propriedades inerentes?

### pontos positivos 

### pontos negativos

### quando é recomendável usar/aplicar?

---
## definição oficial do assunto estudado

### Em uma frase, qual é o propósito ou a ideia central deste conteúdo?

### como você explicaria isso para um amigo de forma simples?

### como você explicaria isso para um amigo de forma mais completa?