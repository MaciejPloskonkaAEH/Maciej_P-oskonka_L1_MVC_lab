# Favorite Recipes App

Aplikacja MVC do zarządzania ulubionymi przepisami kulinarnymi.

## Spis treści

1. [Opis projektu](#opis-projektu)
2. [Funkcjonalności](#funkcjonalności)
3. [Struktura projektu MVC](#struktura-projektu-mvc)
4. [Instrukcja uruchomienia](#instrukcja-uruchomienia)
5. [Widoki aplikacji](#widoki-aplikacji)

---

## Opis projektu

Favorite Recipes App to prosta aplikacja webowa zbudowana w architekturze MVC z użyciem ASP.NET Core Web App (Model-View-Cotroller), umożliwiająca tworzenie, edytowanie, przeglądanie i usuwanie przepisów kulinarnych.

---

## Funkcjonalności

- **Dodawanie przepisów** – formularz z walidacją (wymagany tytuł).
- **Wyświetlanie listy przepisów** – tabela z kolumnami: Tytuł, Składniki, Instrukcja.
- **Filtrowanie przepisów po tytule** – dynamiczne wyszukiwanie przepisów.
- **Szczegóły przepisu** – osobna strona z pełnymi informacjami.
- **Edycja przepisu** – formularz z możliwością aktualizacji danych.
- **Usuwanie przepisu** – opcja kasowania wybranego przepisu.
- **Strona główna i polityka prywatności** – widoki informacyjne.

---

## Struktura projektu MVC

### Model
- **Recipe**
  - `Title` – string, wymagane
  - `Ingredients` – string
  - `Instruction` – string

### Kontroler
- `RecipesController.cs`
  - `Index()` – lista przepisów + filtr
  - `Create()` / `POST Create()` – dodawanie nowego przepisu
  - `Edit(id)` / `POST Edit(id)` – edytowanie istniejącego przepisu
  - `Details(id)` – szczegóły przepisu
  - `Delete(id)` / `POST DeleteConfirmed(id)` – usuwanie przepisu

### Widok
- `Index.cshtml` – lista + filtr
- `Create.cshtml` – formularz tworzenia
- `Edit.cshtml` – formularz edycji
- `Details.cshtml` – szczegóły przepisu
- `Delete.cshtml` – potwierdzenie usunięcia
- `Privacy.cshtml` – polityka prywatności
- `_Layout.cshtml` – wspólny układ strony z nawigacją

---

## Instrukcja uruchomienia

1. **Kroki instalacji**:
   - Zainstaluj .NET SDK 9.0:  
     https://dotnet.microsoft.com/en-us/download
   - Otwórz projekt w Visual Studio lub Visual Studio Code.

