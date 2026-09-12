<p align="center">
  <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSm1Z7752bOKmBssX_FeVMtjmgG9ghBpxjfvA9DsNsGkQ&s=10" alt="UniCesumar" width="360">
</p>

<h1 align="center">Game Engine — UniCesumar</h1>
<p align="center"><em>Material de aula — fundamentos de movimento 2D e power-up (Unity)</em></p>

---

## Para que serve este repositório?

Projeto introdutório de **game engine / gameplay 2D** na Unity, com foco em:

- Movimento do player com **Input System** (teclado)
- Animação (`isWalking`, eixos X/Y)
- Física 2D (`Rigidbody2D`)
- Coleta simples de **PowerUp** (trigger + XP)

## Tecnologias

| Item | Detalhe |
|------|---------|
| Engine | **Unity 6** (`6000.2.5f1`) |
| Linguagem | C# |
| Input | Unity Input System |
| Render | URP 2D (template) |

## Estrutura principal

```
Assets/
├── Scripts/
│   ├── PlayerMovement.cs
│   └── PowerUp.cs
├── Scenes/SampleScene.unity
└── Settings/ ...
```

## Como abrir (aluno)

1. Unity Hub + versão **6000.2.5f1**  
2. Clone:
   ```bash
   git clone https://github.com/UniCesumarGames/game_engine_unicesumar.git
   ```
3. Abra no Hub → `Assets/Scenes/SampleScene.unity` → **Play**

## Controles

| Ação | Teclas |
|------|--------|
| Mover | W A S D ou setas |

## Exercícios sugeridos

1. Alterar `velocidade` do player e sentir a diferença  
2. Trocar a mensagem do PowerUp e adicionar aumento real de XP/variável  
3. Impedir movimento diagonal indesejado (já há `normalized` — explique por quê)

---

<p align="center">UniCesumar — Jogos Digitais / Desenvolvimento de Games</p>
