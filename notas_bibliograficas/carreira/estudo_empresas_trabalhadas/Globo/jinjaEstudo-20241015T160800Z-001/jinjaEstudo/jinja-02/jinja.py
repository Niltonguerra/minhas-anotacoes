from jinja2 import Environment, FileSystemLoader
import webbrowser

# Função para renderizar e abrir o template em um navegador
def renderizar_template(nome_layout_base, **contexto):
    # Carrega o ambiente Jinja
    file_loader = FileSystemLoader('.')
    env = Environment(loader=file_loader)

    # Carrega o template
    template = env.get_template(nome_layout_base)

    # Renderiza o template com o contexto fornecido
    output = template.render(**contexto)

    # Escreve o resultado em um arquivo temporário
    with open('temp.html', 'w') as file:
        file.write(output)

    # Abre o arquivo HTML no navegador padrão
    webbrowser.open('temp.html')

# Exemplos de renderização de templates
if __name__ == "__main__":
    # Renderiza o template index.html
    renderizar_template('layout_base.html', titulo="Página Inicial", conteudo="Este é o conteúdo da página inicial.")

    # Renderiza o template sobre.html
    renderizar_template('layout_base.html', titulo="Sobre Nós", conteudo="Este é o conteúdo da página 'Sobre'.")

    # Renderiza o template contato.html
    renderizar_template('layout_base.html', titulo="Entre em Contato", conteudo="Este é o conteúdo da página 'Contato'.")
