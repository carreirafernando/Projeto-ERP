# Plano Operacional – Controle de Produção

Este plano operacional descreve como o sistema será desenvolvido e mantido no contexto de
**controle de produção**, utilizando a metodologia ágil Scrum. O objetivo é garantir entregas
incrementais, controle contínuo do processo e manutenção eficiente do sistema.

### Metodologia de Desenvolvimento
Será utilizada a metodologia **Scrum**, com sprints quinzenais. O processo inclui reuniões diárias
(Daily Scrum), revisões de sprint (Sprint Review), retrospectivas (Sprint Retrospective) e o uso de
ferramentas visuais como Kanban (Trello/Jira) e burndown chart.

### Divisão de Tarefas
- Product Owner (PO): responsável por priorizar funcionalidades e alinhar com objetivos de produção.
- Scrum Master: garante que o Scrum seja seguido e remove impedimentos.
- Equipe de Desenvolvimento:
   - Frontend: interface do usuário.
   - Backend: regras de negócio, APIs e integração.
   - Banco de Dados: modelagem e manutenção dos dados.
   - QA/Testes: verificação da qualidade das entregas.
     
### Recursos Tecnológicos
- Frontend: React.js
- Backend: Node.js + Express
- Banco de Dados: PostgreSQL
- Controle de versão: Git + GitHub
- Gestão de tarefas: Trello / Jira
- Comunicação: Slack / Discord
  
### Infraestrutura Necessária
- Hospedagem: Heroku / Vercel / AWS
- Banco de Dados em Nuvem: PostgreSQL (Railway ou Supabase)
- APIs: integração com autenticação e relatórios
- Ambiente de desenvolvimento: VS Code, Docker (opcional)
  
### Cronograma de Execução
- Semanas 1–2: Levantamento de requisitos, definição do backlog inicial.
- Semanas 3–4: Configuração do ambiente, modelagem do banco de dados.
- Semanas 5–6: Desenvolvimento do frontend inicial (dashboard).
- Semanas 7–8: Desenvolvimento do backend (cadastro e controle de produção).
- Semanas 9–10: Integração frontend + backend.
- Semanas 11–12: Testes, ajustes e documentação.
- Semanas 13–14: Implantação em ambiente de produção.
- Semanas 15–16: Revisão final, melhorias e entrega do projeto.
  
### Quadro de Responsáveis por Etapa
Etapa do Projeto
 Levantamento de requisitos
 Planejamento e acompanhamento (Scrum)
 Responsável
 Product Owner
 Scrum Master
 Modelagem do banco de dados
 Dev Backend + DBA
Desenvolvimento do frontend
 Desenvolvimento do backend
 Dev Frontend
 Dev Backend
 Integração de APIs
 Testes e validação
 Documentação
 Implantação e manutenção
 Dev Backend
 QA
 Todos
 DevOps/Backend
