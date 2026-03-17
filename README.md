# APBD Git Exercises

Repozytorium zawiera rozwiązania ćwiczeń z Git i GitHub.

## Fast-forward vs merge commit

Git wykonuje merge typu fast-forward, gdy gałąź docelowa (np. `main`) nie ma nowych commitów od momentu utworzenia gałęzi roboczej. W takiej sytuacji Git jedynie przesuwa wskaźnik gałęzi do przodu, bez tworzenia dodatkowego commit’a scalającego.

Merge commit powstaje wtedy, gdy obie gałęzie mają nowe, niezależne commity i ich historie się rozeszły. Git musi wtedy połączyć te zmiany, tworząc nowy commit scalający.

## Merge vs rebase

Merge łączy gałęzie, zachowując pełną historię wraz z rozgałęzieniami. Często tworzy dodatkowy commit scalający.

Rebase przepisuje historię, przenosząc commity z jednej gałęzi na koniec drugiej. Dzięki temu historia jest bardziej liniowa i czytelna, ale zmieniają się identyfikatory commitów.

## Rozwiązanie konfliktu

Konflikt powstał, ponieważ ten sam fragment kodu w pliku `Program.cs` został zmieniony niezależnie na gałęzi `feature-conflict` oraz na `main`.

Git nie był w stanie automatycznie wybrać poprawnej wersji, dlatego konflikt został rozwiązany ręcznie poprzez połączenie obu zmian w jedną:



Po rozwiązaniu konfliktu program został uruchomiony, aby upewnić się, że działa poprawnie.