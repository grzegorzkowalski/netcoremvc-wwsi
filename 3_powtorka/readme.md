## Zadania

### Pierwszy program - rozgrzewka

#### Zadanie 1

Stwórz nowy projekt typu Console App (.Net Core).

#### Zadanie 2

W metodzie `Main` umieść następujący kod:
```csharp
Console.WriteLine("Podaj swoje imię:");
var name = Console.ReadLine();
Console.WriteLine("Hello " + name);
```
1. Uruchom projekt, wyświetli się okno konsoli.

#### Zadanie 3

W metodzie `Main` umieść następujący kod:
```csharp
int result = 5 + 9
```
1. Uruchom projekt.
1. Jeśli uruchomienie zakończy się niepowodzeniem, znajdź i napraw błąd. Błędy możesz zobaczyć w oknie `Error List`.

#### Operatory

#### Zadanie 1

1. W metodzie `Main` utwórz 6 zmiennych.
1. Każda zmienna powinna przechowywać odpowiednio dobrany przez Ciebie typ danych na podstawie opisu.
1. Wartości mogą być dowolne.
* Zmienna o nazwie `number` przechowująca liczbę całkowitą.
* Zmienna o nazwie `money` przechowująca liczbę zmiennoprzecinkową (float).
* Zmienna o nazwie `text` przechowująca tekst.
* Zmienna o nazwie `isLogged` przechowująca wartość logiczną.
* Zmienna o nazwie `myChar` przechowująca pojedynczy znak.
* Zmienna o nazwie `price` przechowująca liczbę zmiennoprzecinkową z największą precyzją (decimal).

Po deklaracji wszystkich zmiennych wyświetl je w konsoli.

#### Zadanie 2

1. Utwórz zmienną o nazwie `myAge` typu `string` z wartością `Age: `.
1. Utwórz zmienną o nazwie `wifeAge` typu `int` z wartością `18`.
1. Utwórz zmienną o nazwie `result` i przypisz do niej rezultat dodawania zmiennych `myAge` i `wifeAge`.
1. Wyświetl zmienną `result` w konsoli.
5. Jakie wnioski?


#### Zadanie 3

1. Utwórz 3 zmienne typu `bool` o następujących nazwach i wartościach:
    1. `isTrue` o wartości `true`.
    1. `isFalse` o wartości `false`.
    1. `isReallyTrue` o wartości `true`.
1. Utwórz 3 kolejne zmienne o następujących nazwach i przypisz do nich wyniki działań na zmiennych logicznych:
    1. `and` powinna zwierać wynik działania `isTrue` AND `isFalse`.
    1. `or` powinna zwierać wynik działania `isTrue` OR `isReallyTrue`.
    1. `negative` powinna zawierać wynik negacji `isFalse`.
1. Wyświetl zmienne `and, or i negative` w konsoli.


#### Zadanie 4 *dodatkowe

1. Utwórz dwie zmienne o nazwach `a`, `b` i przypisz do nich wartości `5, 12`.
1. Utwórz zmienne o nazwach `add`, `sub`, `div`, `mul`, `mod` i przypisz do nich kolejno wynik dodawania, odejmowania, dzielenia, mnożenia i modulo zmiennych `a` i `b`.
1. Wyświetl zmienne `add`, `sub`, `div`, `mul`, `mod` w konsoli.


#### Zadanie 5 *dodatkowe

1. Utwórz trzy zmienne typu `string` o nazwach `a`, `b` i `c`.
1. Do zmiennych przypisz kolejno tekst `Ala `, `ma `, `kota.`.
1. Utwórz 4 zmienną o nazwie `result` i przypisz do niej wynik operacji `a + b + c`.
1. Wyświetl zmienną `result` w konsoli.
1. Napisz w komentarzu swoje spostrzeżenia dotyczące wyniku.

### Instrukcje sterujące i pętle

#### Zadanie 1

1. Utwórz dwie zmienne typu `int` o nazwach `n1` i `n2`. Przypisz do nich liczby `10` i `20`.
1. Używając instrukcji `if` sprawdź wartości tych zmiennych i wypisz w konsoli, która z liczb jest większa lub czy są równe.
1. Tekst powinien się wyświetlić według wzoru `n1 jest większe od n2` lub `n1 jest równe n2`.

#### Zadanie 2

1. Stwórz pętlę, która 10 razy wypisze w konsoli `C#`.
1. Zadanie rozwiąż używając pętli `for` oraz pętli `while`.
1. W sumie w konsoli wyraz `C#` powinien pojawić się 20 razy.

#### Zadanie 3

1. Stwórz zmienną o nazwie `n`, które będzie zainicjowana wartością `10`.
1. Następnie wypisz w konsoli informacje czy liczba jest parzysta, czy nie, dla liczb od `0` do `n`.
Wzór:
```
0 - Parzysta
1 - Nieparzysta
2 - Parzysta
itd...
```

Jak sprawdzić czy liczba jest parzysta? Podpowiedź: `modulo`.

#### Zadanie 4 *dodatkowe

1. Stwórz zmienną o nazwie `n`, która będzie zawierała wartość 5.
1. Następnie napisz skrypt, który wypisze w konsoli poniższy schemat.

Schemat dla `n = 5`.
```
*
* *
* * *
* * * *
* * * * *
```

Schemat dla `n = 3`.
```
*
* *
* * *
```

#### Zadanie 5 *dodatkowe

1. Utwórz zmienną `exam`, która będzie zawierała wartość od 0 do 100.
1. Zmienna `exam` przechowuje wyniki egzaminu.
1. Utwórz kod, który wyświetli w konsoli ocenę z testu na podstawie zmiennej `point`, według poniższego schematu.
    * 0 - 39 pkt - `Ocena Niedostateczna`
    * 40 - 54 pkt - `Ocena Dopuszczająca`
    * 55 - 69 pkt - `Ocena Dostateczna`
    * 70 - 84 pkt - `Ocena Dobra`
    * 85 - 98 pkt - `Ocena Bardzo Dobra`
    * 99 - 100 pkt - `Ocena Celująca`
1. W przypadku gdy wartość `exam` jest mniejsza od `0` lub większa od `100` wyświetl komunikat: `Wartość poza zakresem`.

Przykład: Dla point z wartością `57`, w konsoli powinno wyświetlić się `Ocena Dostateczna`.

### Kolekcje

#### Zadanie 1

1. Utwórz czteroelementową tablicę typu `string` o nazwie `colors`.
1. Tablicę uzupełnij dowolnymi nazwami kolorów.
1. Wyświetl pierwszy kolor z tablicy w konsoli według wzoru `Mój pierwszy kolor to: niebieski`.
1. Wyświetl ostatni kolor z tablicy w konsoli według wzoru `Mój ostatni kolor to: czerwony`.

#### Zadanie 2

1. Stwórz tablicę z 10 dowolnymi liczbami.
1. Następnie wypisz w konsoli, przy użyciu pętli `for`, `foreach` i `while` 10 razy tekst `Liczba: 13`, gdzie `13` będzie kolejną liczbą z tablicy.

Wzór
```csharp
Liczba: 0
Liczba: 1
```

#### Zadanie 3 *dodatkowe

1. Utwórz czteroelementową listę `List<string>` o nazwie `fruits`.
1. Tablicę uzupełnij dowolnymi nazwami owoców, używając metody remove.
1. Wyświetl w konsoli wszystkie owoce według wzoru `Pomidor, Jabłko, Marchewka`. Między nazwami owoców musi się znaleźć przecinek i spacja.
4. Usuń za pomocą metod `Revome i RemoveAt` pierwszy i ostatni element listy.
5. Wyświetl wszystkie elementy listy.


## Warsztat

#### Zadanie 1: Zapoznanie się z Visual Studio

1. Utwórz nową solucję o nazwie Library
2. W solucji utwórz projekt Library.ConsoleApp typu aplikacja konsolowa
3. W solucji utwórz projekt Library.Domain typu ClassLib
4. W solucji utwórz projekt Library.Persistence typu ClassLib
5. W projekcie Library.Persistence dodaj referencję do projektu Library.Domain
6. W projekcie Library.ConsoleApp dodaj referencję do projektów Library.Domain i Library.Persistence
7. W projekcie Library.Domain utwórz klasę ksiązki, mozesz ją skopiowac z kodu ponizej
```csharp
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }

        public int ProductsAvailable { get; set; }
        public decimal Price { get; set; }
        
        public Book() {}

        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            ProductsAvailable = productsAvailable;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        }
    }
}
```
8. W projekcie Library.Persistence utwórz klasę BooksRepository, na chwilę obecną moze to byc pusta klasa
9. W projekcie Library.ConsoleApp w pliku Program.cs utworz obiekt wczesniej utworzonych klas
```csharp
Book book = new Book(/*uzupelnij parametry*/);
BooksRepository repository = new BooksRepository();
```
10. Skompiluj projek aby sprawdzic czy nie ma w nim błędów.
11. *Utwórz katalog solucji Presentation
12. *Przenies do katalogu Presentation projekt Library.ConsoleApp
13. *Utworz katalog solucji Logic
14. *Przenies do katalogu Logic projekty Library.Domain oraz Library.Persistence

#### Zadanie 2: Instrukcje Warunkowe / Debugowanie

1. Otwórz plik Program.cs w projekcie Library.ConsoleApp
2. Za pomocą API obiektu console, pobierz od uzytkownika jego login i haslo
```csharp
string text = Console.ReadLine();
```
3. Jezeli login to `Admin` a haslo to `password` wypisz na consoli napis `Access Granted`
4. W przeciwnym wypadku wypisz napis `Access Denied`
5. Za pomocą przycisku F9 (lub klikając w lewą kolumnę edytora) oznacz miejsce z if-em, tak aby wykonywanie programu zatrzymało się.
6. Urucham projekt Library.ConsoleApp w trybie Debug
7. Za pomocą przycisku F10 przejdź przez flow programu

#### Zadanie 3: Utworzenie menu w aplikacji konsol / Pętle sterujące 

1. Otworz plik Program.cs z aplikacji Library.ConsoleApp
2. Następnie za pomocą pętli zczytuj kolejne linie tekstu wprowadzone przez uzytkownika
3. Pętla ma zakończyc swoje zadanie kiedy uzytkownik wpisze komende `wyjdz`
4. Pętla ma czekac az uzytkownik wprowadzi komende
5. Wewnątrz pętli sprawdzaj jaką komendę podał uzytkownik według ponizszej rozpiski: 
   - dodaj -> Powinna wypisac tekst: "proba dodania ksiazki"
   - usun -> Powinna wypisac tekst: "proba usuniecia ksiazki"
   - wypisz -> Powinna wypisac tekst: "proba wypisania wszystkich ksiazek"
   - zmien -> Powinna wypisac tekst: "proba zmiany stanu magazynowego ksiazek"
   - dodaj zamowienie -> Powinna wypisac tekst: "proba dodania nowego zamowienia"
   - lista zamowien -> Powinna wypisac tekst: "proba wypisania wszystkich zamowien"
6. Wykorzystaj komende `Console.Clear()` aby po wprowadzeniu komendy ekran konsoli wypisywal tylko menu aplikacji
7. Wykorzystaj komendę `Console.WriteLine` aby wyswietlic uzytkownikowi mozliwe do wpisania komendy
8. *W przypadku kiedy uzytkownik poda nie wspierana komende, aplikacja powinna wyswietlic informacje ze podana komenda nie jest wspierana
9. *Po kazdej komendzie aplikacja powinna wyswietlic napis: `Press AnyKey` i wstrzymac wykonywanie programu do czasu wcisniecia klawisza