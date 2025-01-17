# Kalkula�ka WinForms

Tento projekt je jednoduch� kalkula�ka vytvo�en� pomoc� C# a WinForms. Umo��uje z�kladn� aritmetick� operace, v�etn� s��t�n�, od��t�n�, n�soben�, d�len� a mocn�n�.

## Funkce

- **Podpora z�kladn�ch operac�:**
  - S��t�n� (+)
  - Od��t�n� (-)
  - N�soben� (*)
  - D�len� (/)
  - Mocn�n� (^)
- **Grafick� u�ivatelsk� rozhran� (GUI):** ��seln� tla��tka (0�9) a tla��tka pro operace.

## Pou�it�

1. Stiskn�te tla��tko s ��slem pro zad�n� hodnoty.
2. Vyberte po�adovan� oper�tor (+, -, *, /, ^).
3. Stiskn�te tla��tko `=` pro zobrazen� v�sledku.

## Architektura

Projekt je rozd�len do dvou hlavn�ch t��d:
1. **CalculatorView**  
   Hlavn� t��da obsahuj�c� logiku u�ivatelsk�ho rozhran� a obsluhu ud�lost� tla��tek.

2. **Calculator**  
   T��da zpracov�vaj�c� v�echny matematick� operace. Poskytuje metody pro:
   - S��t�n�
   - Od��t�n�
   - N�soben�
   - D�len� (s o�et�en�m d�len� nulou)
   - Mocn�n� (v�etn� podpory z�porn�ch exponent�)


