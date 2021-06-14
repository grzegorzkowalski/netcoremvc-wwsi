### Identity

Zadanie jest podzielone na 4 sekcje: Konfiguracja, Rejestracja, Logowanie, Dostęp do akcji i role.

#### Zadanie 1

## Konfiguracja

1. Rozwijamy aplikację `FilmDB`.
1. Pobierz pakiety NuGet `Microsoft.AspNetCore.Identity` i `Microsoft.AspNetCore.Identity.EntityFrameworkCore`, aby skorzystać z uwierzytelnienia.
1. Utwórz klasę kontekstu o nazwie `EFCContext`, która będzie dziedziczyć po klasie `IdentityDbContext`.
1. Za pomocą metody `AddIdentity` dołącz usługę uwierzytelniania do projektu przekazując dwa parametry generyczne `IdentityUser` oraz `IdentityRole`. Na zwracanym obiekcie typu `IdentityBuilder` uruchom metodę `AddEntityFrameworkStores` przekazując w parametrze generycznym typ klasy kontekstu.
1. Za pomocą metody `UseAuthentication` włącz obsługę uwierzytelnienia. Ponieważ kolejność wywoływania metod ma znaczenie, metodę `AddIdentity` należy wywołać przed metodą `AddMvc`.
1. Utwórz migrację i wprowadź zmiany do bazy danych.

#### Zadanie 1.1

1. Na stronie głównej utwórz link z tekstem `Rejestacja`, który będzie kierował na akcję `Register` kontrolera `Account` oraz link z tekstem `Zaloguj`, który będzie kierował na akcję `LogIn` kontrolera `Account`.
1. Utwórz kontroler o nazwie `Account`.
1. W kontrolerze `Account` odbierz zarejestrowaną usługę `SignInManager` oraz `UserManager`.

## Rejestracja

#### Zadanie 1.2

1. Utwórz model widoku o nazwie `RegisterViewModel`, który będzie przekazywał dane rejestracji, model powinien zawierać następujące właściwości:
    1. `Login` typu `string` na login użytkownika.
    1. `Email` typu `string` na email użytkownika.
    1. `Password` oraz `RepeatPassword` typu `string` na hasło użytkownika.
1. Wszystkie właściwości powinny być wymagane. Dodatkowo wartość właściwości `Password` powinna być identyczna jak wartość właściwości `RepeatPassword`.
1. Utwórz metodę `Register` w kontrolerze `Account`, metoda powinna:
    1. Przyjmować tylko żądania `get`.
    1. Zwracać widok z formularzem utworzonym na podstawie modelu `RegisterViewModel`.
    1. Formularz powinien być typu `post` i powinien być wysyłany na akcję `Register` typu `post`.
    1. W widoku wyświetl błędy walidacji.
1. Utwórz metodę `Register` w kontrolerze `Account` z parametrem typu `RegisterViewModel`. Metoda powinna:
    1. Przyjmować tylko żądania `post`.
    1. Sprawdzać walidację modelu.
    1. Rejestrować użytkownika przy pomocy usługi `SignInManager`.
    1. Jeśli rejestracja zakończy się pomyślnie, zrób przekierowanie na akcję `Index` kontrolera `Home`.
    1. Jeśli rejestracja zakończy się niepomyślnie, zwróć widok z formularzem logowania i odpowiednim komunikatem.
1. Sprawdź czy zarejestrowany użytkownik został utworzony w bazie danych.

## Logowanie

#### Zadanie 1.3

1. Utwórz model o nazwie `LogInViewModel`, który będzie przekazywał dane logowania, model powinien zawierać następujące właściwości:
    1. `Login` typu `string` na login użytkownika.
    1. `Password` typu `string` na hasło użytkownika.
1. Wszystkie właściwości powinny być wymagane.
1. Utwórz metodę `LogIn` w kontrolerze `Account`, metoda powinna:
    1. Przyjmować tylko żądania `post`.
    1. Zwracać widok z formularzem utworzonym na postawie modelu `LogInViewModel`.
    1. Formularz powinien być typu `post` i powinien być wysłany na akcję `LogIn` typu `post`.
    1. W widoku wyświetl błędy walidacji.
1. Utwórz metodę `LogIn` w kontrolerze `Account` z parametrem typu `LogInViewModel`. Metoda powinna:
    1. Przyjmować tylko żądania `post`.
    1. Sprawdzić walidację modelu.
    1. Logować użytkownika za pomocą usługi `SignInManager`.
    1. W przypadku pomyślnego zalogowania przekierować na stronę główną z odpowiednim komunikatem.
    1. W przypadku, gdy wystąpią błędy logowania, login lub hasło będą niepoprawne zwrócić widok formularza z odpowiednimi komunikatami błędów.
    
#### Zadanie 1.4

1. Zmień akcję `Register` typu `post` w taki sposób, aby po rejestracji użytkownik był od razu zalogowany.

#### Zadanie 1.5

1. W widoku `Index` kontrolera `Home` zrób następujące czynności:
    1. Zmień widok w taki sposób, aby link `Zaloguj` był wyświetlany tylko wtedy gdy użytkownik nie jest zalogowany.
    1. Jeśli użytkownik jest zalogowany wyświetl link z tekstem `Wyloguj [LoginUżytkownika]`, który będzie kierował na akcję `LogOut` w kontrolerze `Account`.
1. W kontrolerze `Account` utwórz akcję `LogOut`, która będzie wywoływana na żądania typu `get`.
1. Metoda powinna wylogować użytkownika i przekierować na akcję `Index` w kontrolerze `Home`.

## Dostęp do Akcji i Role

#### Zadanie 1.6

1. Utwórz kontroler o nazwie `Role`. Kontroler będzie dodawał role do użytkownika.
1. Na kontrolerze `Role` ustaw atrybut `Authorize`, aby nie był dostępny dla niezalogowanych użytkowników.
1. W kontrolerze utwórz akcję `Index` wraz z widokiem, który będzie zawierał linki do pozostałych akcji kontrolera.
1. Odbierz w kontrolerze zarejestrowaną usługę `RoleManager`.
1. W widoku `Index` kontrolera `Home` utwórz link kierujący na akcję `Index` kontrolera `Role`.

#### Zadanie 1.7

1. W kontrolerze `Role` utwórz akcję o nazwie `Add` wraz z widokiem, wywoływanie akcji ogranicz tylko do żądań `get`.
1. Widok ma wyświetlać formularz typu `post` z polem tekstowym na nazwę roli, która zostanie dodana.
1. W kontrolerze `Role` utwórz akcję `Add`, wywoływaną na żądanie `post`, która doda rolę do systemu. Akcja powinna przyjmować parametr typu `string` z nazwą roli.
1. Gdy rola zostanie dodana pomyślne zrób przekierowanie na akcję `Index` w przeciwnym wypadku zwróć komunikat z błędem.

#### Zadanie 1.8

1. W kontrolerze `Role` utwórz akcję o nazwie `Remove` wraz z widokiem. Ogranicz akcję do żądań `get`.
1. Widok powinien wyświetlać pole typu `ComboBox` z listą ról w systemie oraz przyciskiem pozwalającym usunąć rolę.
1. Formularz powinien kierować na akcję `Remove` typu `post`.
1. Utwórz akcję `Remove` wywoływaną na żądania `post` z parametrem typu `string`, którym będzie nazwa roli.
1. W przypadku pomyślnego usunięcia roli zrób przekierowanie na akcję `Index`, w przeciwnym przypadku zwróć widok z komunikatem błędu.

#### Zadanie 1.9

1. W widoku `Index` kontrolera `Role` wyświetl listę wszystkich ról w systemie.
1. W widoku `Index` utwórz link do akcji `Add` oraz link `Remove` przy każdym wierszu z rolą. Link `Remove` powinien zawierać `ID` roli.

#### Zadanie 1.10

1. Przy każdym wierszu z rolą w widoku dla akcji `Index` kontrolera `Role` utwórz link do akcji `Edit`. Link powinien zawierać `ID` roli.
1. Analogicznie do zadania z dodawaniem nowych ról utwórz dwie akcje `Edit` wraz z widokiem, które pozwolą na edytowanie ról.

#### Zadanie 1.11

1. W kontrolerze `Role` utwórz akcję `AddToRole` wraz z widokiem. Akcja powinna być wywoływana tylko na żądanie `get`.
1. Widok powinien zawierać formularz z dwoma elementami typu DropDown:
    1. Pierwsze powinno wyświetlić listę wszystkich użytkowników w systemie.
    1. Drugie powinno wyświetlić listę wszystkich ról w systemie.
1. Po wybraniu użytkownika i roli formularz powinien zostać wysłany na akcję `AddToRole` typu `post`.
1. Utwórz akcję `AddToRole` typu `post`, która przyjmie identyfikator użytkownika oraz roli i doda użytkownika do roli.
1. W przypadku pomyślnego dodania użytkownika do roli zrób przekierowanie do widoku wszystkich ról i wyświetl odpowiedni komunikat. W przeciwnym przypadku wróć do formularza dodawania i wyświetl błędy.

#### Zadanie 1.12

1. Zmień widok `Index` w kontrolerze `Home`, tak, aby wyświetlał login i role zalogowanego użytkownika.

#### Zadanie 1.13

1. Do programu dodaj rolę `Admin`.
1. Nadaj tę rolę dla swojego wybranego użytkownika.
1. W kontrolerze `Role` zmodyfikuj atrybut Authorize w taki sposób, aby dawał dostęp wyłącznie użytkownikom w roli `Admin`.
1. Przetestuj dostęp do kontrolera `Role` na dwóch różnych użytkownikach, z rolą `Admin` i bez tej roli.