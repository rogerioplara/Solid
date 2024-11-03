# SOLID

Acrônimo para 5 princípios, criados pelo Robert Martin (Uncle Bob)

### S - Single Reponsibility Principle (SRP)
**Princípio da responsabilidade única**

Separar as classes por sua responsabilidade. Geralmente, esse problema se demonstra com classes grandes e que tocam muitos aspectos que não necessariamente são relacionadas a ela

### O - Open/Closed Principle (OCP)
**Princípio aberto/fechado**

Uma classe, módulo ou função deve ser fechado para modificações e aberto para extensões
Se alterar algo na classe A que interfere na classe B ou C, estou violando o princípio OCP
Uma vez implementado, não deve ser modificada a classe A. Coisas essas que modifiquem ou interfiram nas outras classes
O custo de extender ao invés de alterar a classe anterior geralmente se mostra menor, visto que a possibilidade de bugs, problemas críticos ou alterações indesejadas nas regras de negócio são evitadas
Existem duas maneiras de fazer a aplicação desse princípio
- Extensão das classes por meio de herança
- Implementação de interfaces

### L - Liskov Substitution Principle (LSP)
**Princípio da substituição de Liskov**

Uma classe derivada pode ser substituível por sua classe base, sem quebrar a aplicação
Os objetos da subclasse deve se comportar da mesma maneira que a superclasse

### I - Interface Segregation Principle (ISP)
**Princípio da segregação de interface**

Os clientes não devem ser forçados a depender de métodos que não utilizam
Esse problema geralmente se caracteriza por interfaces inchadas
Não se aplica somente a interfaces, mas também a classes abstratas ou qualquer outro método público
- Minimiza a dependência de membros não utilizados
- Reduz o acoplamento do código
- Código mais harmônico e objetivo

### D - Dependency Inversion Principle (DIP)
**Princípio da inversão de dependência**

Gera desacoplação de módulos
Não confundir inversão de dependência com injeção de dependência
Um módulo de alto nível não pode depender de um módulo de baixo nível. Ambos devem depender apenas de abstrações
- Módulo de alto nível: onde estão as regras de negócio do sistema (o que precisa ser feito)
- Módulo de baixo nível: tarefas realizadas pela aplicação (como será feito)
Product é o módulo de alto nível
Data Access (SQL) e Auth são os módulos de baixo nível
Isso não é algo imutável, depende de como a aplicação foi projetada
Nesse caso, MongoDB e MySQL são de baixo nível em relação ao Data Access (SQL)
