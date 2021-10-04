# impacta-tdd-palindrome

Projeto criado para implementar TDD seguindo solicitação de atividade da Impacta.

Membros

Amanda Botelho de Moraes
Bruna Vieira Teixeira


## Atividade

Como usuário gostaria de uma funcionalidade que valide se uma frase ou palavra é
palíndromo.

Critérios de aceite:

Verdadeiro:
- “Rotator”
- “bob”
- “madam”
- “mAlAyAlam”
- “1”
- “Able was I, ere I saw Elba”
- “Madam I’m Adam”
- “Step on no pets.”
- “Top spot!”
- “02/02/2020”

Falso:
- “xyz”
- “elephant”
- “Country”
- “Top . post!”
- “Wonderful-fool”
- “Wild imagination!”

O componente deve receber os exemplos acima e retornar verdadeiro ou falso, conforme a
regra. Fazer o componente usando a metodologia TDD.

## Execução

Com ambiente que possui o .net 5.0 rodando, somente rodar os testes:

```
dotnet test
```

Caso nâo possua, subir dockerfile do projeto para rodar os testes usando a imagem do sdk .net 5.0.

```
docker run --pull -t impacta-palindrome .
```
