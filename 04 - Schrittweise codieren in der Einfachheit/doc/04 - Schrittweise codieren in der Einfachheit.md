04 - Schrittweise codieren in der Einfachheit

# Refelxion

Um einfache Probleme noch einfacher (trivial) zu machen, hilft es, sie in triviale Teilprobleme auzuteilen. Es werden zuerst die Testfälle realisiert, dann der Produktionscode. So nähert man sich der Lösung schrittweise an.

# Aufgabe 1
1. Mathematischer Ausdruck: trivial
2. Game-of-life: einfach
3. NQueen-Problem: einfach
4. Bin -> Dez: einfach

# Aufgabe 2
2.1 Nach Eingabe der römischen Zahl "MCDXCII" wird die Dezimalzahl 1492 geliefert.
2.2 public int RoemischeZahlInDezimalzahlUmwandeln(string roemischeZahl)

# 2.1 Testfälle
1. Einzelne Zahlzeichen werden korrekt übersetzt (M => 1000, D => 500, C => 100, L => 50, X => 10, V => 5, I => 1)
2. Römische Zahl ohne Abzugslogik wird korrekt übersetzt (MDCLXVI => 1666)
3. Römische Zahl mit Abzugslogik wird korrekt übersetzt  (MCMLXXXIV => 1984)