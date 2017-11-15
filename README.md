1. W nowym projekcie wykonaj poniższe czynności:
* Stwórz klasę `Osoba` z polami `imie` i `nazwisko`. Następnie stwórz klasę potomną `Student` z polami `rokStududiów`, `numerGrupy`, `numerAlbumu`. Dodaj w obu klasach konstruktory domyślne i parametryczne (można wykorzystać kod z jednych z poprzednich ćwiczeń).
* W obu klasach stwórz metody `WypiszInfo()` wyświetlające wszystkie pola z klasy na konsoli (mają to być tylko instrukcje `Console.WriteLine()` z parametrami).
* Dodaj `new`, aby pozbyć się ostrzeżenia (warning) w Visual Studio. Czemu takie rozwiązanie nie jest najlepsze?
* Wykonaj rzutowanie w górę (`Osoba student1 = new Student()`) i wywołaj dla tego obiektu metodę `WypiszInfo()`.
* Usuń `new` (dodane w trzecim podpunkcie). Następnie do metody `WypiszInfo()` w klasie `Osoba` dodaj `virtual`, a w klasie `Student` `override`. Jaka jest różnica?
* Zmodyfikuj metodę `WypiszInfo()` w klasie `Student` używając `base.WypiszInfo();` (o ile nie zrobiono tego wcześniej).
* Narysuj diagram klas UML projektu.


Diagram UML:

![diagram](https://i.imgur.com/eQxJ0ep.png)
