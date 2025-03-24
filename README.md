# Gerador de Senhas

Este projeto fornece uma API para a geração de senhas seguras de acordo com os critérios especificados pelo usuário.

## Tecnologias Utilizadas
- .NET 8
- ASP.NET Core
- C#

## Configuração do Projeto
### Pré-requisitos
- .NET SDK 8 ou superior
- Editor de código (Visual Studio, VS Code, Rider, etc.)

### Como executar o projeto
1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/gerador-senhas.git
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd gerador-senhas
   ```
3. Execute o projeto:
   ```bash
   dotnet run
   ```

## Endpoints
A API possui um endpoint principal para a geração de senhas:

### Gerar Senha
**GET** `/password`

#### Parâmetros de Query
| Parâmetro              | Tipo    | Padrão | Descrição |
|------------------------|---------|--------|-----------|
| `tamanho`             | int     | 12     | Define o tamanho da senha (entre 12 e 50 caracteres) |
| `letrasMinusculas`    | bool    | false  | Inclui letras minúsculas |
| `letrasMaiusculas`    | bool    | false  | Inclui letras maiúsculas |
| `numeros`             | bool    | false  | Inclui números |
| `caracteresEspeciais` | bool    | false  | Inclui caracteres especiais |

#### Exemplo de Requisição
```bash
curl -X GET "http://localhost:5000/password?tamanho=16&letrasMaiusculas=true&numeros=true&caracteresEspeciais=true"
```

#### Exemplo de Resposta
```json
"A1b!C2d@E3f$G4h%"
```

Caso ocorra um erro, a API retornará:
```json
{
  "message": "O tamanho da senha deve ser entre 12 e 50 caracteres."
}
```

ou

```json
{
  "message": "Pelo menos uma opção deve ser selecionada."
}
```

## Lógica de Geração de Senha
A geração da senha ocorre no `PasswordService` e segue as seguintes regras:
- O tamanho da senha deve estar entre **12 e 50 caracteres**.
- Pelo menos um dos seguintes conjuntos deve ser selecionado:
  - Letras maiúsculas
  - Letras minúsculas
  - Números
  - Caracteres especiais
- A string base é montada com os caracteres selecionados.
- A senha é gerada escolhendo caracteres aleatórios dessa base.

## Contato
Para dúvidas ou sugestões, entre em contato via [fernando.antunes1@gmail.com](mailto:fernando.antunes1@gmail.com).

