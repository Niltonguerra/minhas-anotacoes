import webbrowser
from jinja2 import Environment, FileSystemLoader

# Carrega o arquivo do template
file_loader = FileSystemLoader('.')
env = Environment(loader=file_loader)
template = env.get_template('template.html')

# Renderiza o template com o valor especificado para 'nome'
output = template.render(nome="nilton")

# Escreve o resultado em um arquivo temporário
with open('temp.html', 'w') as file:
    file.write(output)

# Abre o arquivo HTML no navegador padrão
webbrowser.open('temp.html')
