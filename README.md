# Gato - TDD

## Requerimientos

- [x] Como jugador quiero que el tablero tenga 3 filas y 3 columnas para poder jugar.
  - [x] Dado que juego comenzó, el tablero no tiene ninguna marca.
- [ ] Como jugador quiero colocar una marca en una casilla para jugar mi turno.
  - [ ] Dado que el jugador quiere colocar una marca en el tablero, puede seleccionar `X` o `O`.
  - [x] Dado que el jugador quiere colocar una marca en el tablero, cuando intenta colocar una marca en una casilla que ya tenía otra marca, no se le permite.
  - [ ] Dado que el jugador quiere colocar una marca en el tablero, solo puede asignar su ficha asignada.
- [ ] Como jugador quiero ganar cuando hago una línea de 3 marcas consecutivas de mi símbolo.
  - [ ] Dado que el jugador coloca 3 marcas consecutivas (horizontal, vertical o en diagonal), gana el juego y este concluye.
  - [ ] Dado que el jugador no ha colocado 3 marcas consecutivas, no gana el juego.
- [ ] Como jugador quiero empatar cuando no hay casillas disponibles.
- [ ] Como jugador quiero jugar contra otro jugador.
  - [ ] Dado que dos jugadores inician una partida, no se pueden unir más jugadores.
- [ ] Como jugador, quiero seleccionar el símbolo de mis marcas al iniciar.
  - [ ] Dado que un jugador seleccionó su marca, debe utilizarla durante el resto del juego.
  - [ ] Dado que un jugador ya ha seleccionado una marca, el siguiente jugador no puede seleccionar la misma.
- [ ] Como jugador, quiero que se seleccione un jugador aleatorio para jugar el primer turno.
- [ ] Como jugador, quiero que al colocar una marca, termine mi turno para que el siguiente jugador pueda continuar.
- [ ] Como jugador, quiero poder retirarme de una partida en cualquier momento.