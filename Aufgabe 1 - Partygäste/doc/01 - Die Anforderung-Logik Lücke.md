01 - Die Anforderung-Logik Lücke

# Refelxion

> Entwurf scheint hinderlich, überflüssig, verlangsamend
> 
Sehe ich ähnlich. Ich mache nur selten einen Entwurf, zum einen aus Ungeduld, um direkt zum Codieren zu kommen, zum anderen  tauchen viele Probleme erst beim Codieren auf. Wie grob oder genau muss/darf ein Entwurf sein? Bei mir ist es am ehesten Pseudocode.

## Vorteile eines Entwurfs
Wenn der Entwurf klar vom Code abstrahiert ist, kann die Lösung flexibler sein (z.B. andere Programmiersprache)

# Übungsaufgaben
## Aufgabe 1.1 - Gründe für automatisierte Tests
* Wiederholtes Testen von Funktionen muss nicht manuell erfolgen => Zeitersparnis, es kann nichts vergessen werden
* Fehlerhafte Änderungen am Code werden bei guter Testabdeckung sofort erkannt
* Anpassung von (Legacy-)Code ist unkritischer, wenn es eine gute Testabdeckung gibt
* Code wird automatisch sauberer (SRP), da er für Tests entkoppelt sein muss
* Es kann per Quellcodeverwaltung sichergestellt werden, dass nur erfolgreich getester Code ins Repository kommt (gated-checkin)

## Aufgabe 1.2 - Gründe für "test-first"-Codierung
* Beim "test-first"-Ansatz macht man sich schon genaue Gedanken wie die zu entwickelnde Funktion aufgebaut sein muss (Argumente, Rückgabewert, etc...).
* Der Test einer Funktion kann nicht vergessen werden, da er ja zuerst entsteht. Umgekehrt kann auch die Methode nicht vergessen weden, da der Test so lange fehlschlägt bis sie korrekt implementiert ist.

## Aufgabe 2.1.1 - Akzeptanztestfälle
### Logik
* Gültiger Namen eingegeben
* Ungültiger Namen eingeben 
* Erste Begrüßung lautet "Hello, xxx!"
* Zweite Begrüßung lautet "Welcome Back, xxx!"
* 3.-24. Begrüßung lautet "Hello my good friend, xxx!"
* 25\. Begrüßung hängt "Hello my good friend, xxx! Congrats! You are now a platinum guest!" an
* \> 25\. Begrüßung lautet "Hello my good friend, xxx!"

### Datenlayer
* Wegschreiben von Namen und Anzahl der Besuche funktioniert
* Auslesen von Namen und Anzahl der Besuche funktioniert