from jinja2 import Environment, FileSystemLoader

# Carrega o arquivo do template
file_loader = FileSystemLoader('.')
env = Environment(loader=file_loader)

# Variável de exemplo com nomes
nomes = ['Alice', 'Bob', 'Charlie']

# Carrega o template
template = env.get_template('template.html')

# Renderiza o template com os nomes
output = template.render(nomes=nomes)

# Imprime o resultado
print(output)from jinja2 import Environment, FileSystemLoader

# Carrega o arquivo do template de um diretório específico
file_loader = FileSystemLoader('.')
env = Environment(loader=file_loader)

# Variável de exemplo com nomes
nomes = ['Alice', 'Bob', 'Charlie']

# Carrega o template
template = env.get_template('caminho/para/template.html')  # Especifique o caminho correto para o arquivo de template

# Renderiza o template com os nomes
output = template.render(nomes=nomes)

# Especifique o caminho para salvar o arquivo renderizado
caminho_saida = 'caminho/para/saida.html'  # Especifique o caminho e o nome do arquivo de saída

# Salva o resultado renderizado em um arquivo
with open(caminho_saida, 'w') as file:
    file.write(output)

print(f'O arquivo renderizado foi salvo em {caminho_saida}')
