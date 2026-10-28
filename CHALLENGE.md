# Enunciado do candidato — 60 minutos

Implemente uma melhoria na API inicial de gerenciamento de casas inteligentes.

## Regra obrigatória
Implemente o cadastro de dispositivos respeitando o plano da conta:
- Freemium: até 10 dispositivos por casa.
- Básico: até 50 dispositivos por casa.
- Avançado: sem limite definido.

A validação deve acontecer no backend. Considere casa inexistente, acesso a uma casa que pertence a outra conta e limite excedido. Use respostas HTTP adequadas.

## Se sobrar tempo, escolha uma melhoria
1. Limite de casas por plano (Freemium: 1; Básico: 5; Avançado: ilimitado).
2. Bloquear a criação de automações no plano Freemium.
3. Adicionar testes automatizados para os cenários de sucesso e falha.

## Critérios de avaliação
- Regra de negócio correta (40%)
- Organização e legibilidade do código (20%)
- Tratamento de erros e contratos HTTP (15%)
- Testes (15%)
- Explicação das decisões e trade-offs (10%)

Não é necessário implementar autenticação real, Kafka, AWS, dashboard, notificações ou infraestrutura de produção durante a sessão. O campo `accountId` pode ser tratado como identificador recebido no contrato para este exercício; explique que, em produção, a identidade deve vir do contexto autenticado e não ser confiada diretamente ao cliente.
