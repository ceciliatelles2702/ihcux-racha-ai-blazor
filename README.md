# ihcux-racha-ai-blazor

## Integrantes
- Cecília Telles
- Cauan Henrique
- Davi Delmiro

## Curso
Ciência da Computação

## Disciplina
Interação Humano Computador e UX

## Professor
Daniel Henrique Matos de Paiva

---

# Implementação Blazor

O projeto foi desenvolvido utilizando Blazor e Bootstrap para transformar o wireframe criado no Miro em uma interface funcional e responsiva.

A hierarquia visual foi aplicada através da organização das informações em diferentes níveis de destaque. Os cards superiores foram utilizados para exibir os dados mais importantes do sistema, como “Total a Receber”, “Total a Pagar” e “Saldo Geral”, permitindo que o usuário visualize rapidamente sua situação financeira.

A lista de grupos foi separada em componentes reutilizáveis utilizando o arquivo `GrupoCard.razor`. Essa componentização ajudou na organização do código e facilitou a reutilização da interface para diferentes grupos financeiros.

Também foram utilizados princípios de IHC e UX, como:
- Consistência visual nas cores e espaçamentos
- Uso de cores para indicar saldo positivo e negativo
- Responsividade utilizando Grid do Bootstrap
- Botão de ação rápida destacado para adicionar novos gastos
- Campo de busca para facilitar a navegação entre grupos

---

# Dificuldade Técnica

A maior dificuldade técnica foi componentizar o `GrupoCard`, principalmente na passagem de dados entre a página principal (`Dashboard.razor`) e o componente reutilizável.

Foi necessário compreender como utilizar parâmetros no Blazor utilizando `[Parameter]`, além de organizar corretamente os namespaces, imports e a estrutura de pastas do projeto.

Outro desafio foi implementar a renderização condicional para alterar automaticamente as cores dos valores dependendo da situação financeira do usuário, utilizando `text-danger` para dívidas e `text-success` para créditos.
