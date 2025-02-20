# **Projeto Kanban**

Este é um sistema de gerenciamento de atividades inspirado no modelo Kanban, desenvolvido utilizando ASP.NET Core, Entity Framework e MySQL. O objetivo do projeto é permitir o gerenciamento visual de atividades, permitindo a criação, atualização e deleção de tarefas, bem como a movimentação entre diferentes status (Pendente, Em andamento, Finalizada).

## **Funcionalidades**

- **Criação de atividades**: Permite ao usuário cadastrar atividades, atribuindo título, descrição e status.
- **Listagem de atividades**: Visualização das atividades divididas em três categorias: Pendentes, Em andamento e Finalizadas.
- **Movimentação de status**: O usuário pode mover atividades entre os status de "Pendente", "Em andamento" e "Finalizada".
- **Deleção de atividades**: Permite excluir atividades finalizadas.
- **Interface de usuário interativa**: Utiliza Razor Pages para renderização e interações dinâmicas.

## **Tecnologias Utilizadas**

- **ASP.NET Core** - Framework web para criação do backend.
- **Entity Framework** - ORM para interação com o banco de dados.
- **MySQL** - Banco de dados para armazenamento das atividades e status.
- **Razor Pages** - Utilizado para criação de views dinâmicas.
- **Bootstrap** - Framework CSS para a criação de um layout responsivo.

## **Estrutura do Projeto**

```plaintext
/Projeto_Kanban
│
├── /Controllers          # Controladores para gerenciamento das atividades
├── /Data                 # Contexto de banco de dados (AppDbContext)
├── /DTOs                 # Objetos de transferência de dados (DTOs)
├── /Models               # Modelos de dados (Atividade, Status)
├── /Services             # Lógica de negócios (Serviços de Atividade)
├── /Views                # Views Razor para interação com o usuário
│
├── /wwwroot              # Arquivos estáticos (CSS, JS)
│
└── /appsettings.json     # Configurações do banco de dados e outras configurações
