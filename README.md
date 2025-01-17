# Kalkulaèka WinForms

Tento projekt je jednoduchá kalkulaèka vytvoøená pomocí C# a WinForms. Umožòuje základní aritmetické operace, vèetnì sèítání, odèítání, násobení, dìlení a mocnìní.

## Funkce

- **Podpora základních operací:**
  - Sèítání (+)
  - Odèítání (-)
  - Násobení (*)
  - Dìlení (/)
  - Mocnìní (^)
- **Grafické uživatelské rozhraní (GUI):** Èíselná tlaèítka (0–9) a tlaèítka pro operace.

## Použití

1. Stisknìte tlaèítko s èíslem pro zadání hodnoty.
2. Vyberte požadovaný operátor (+, -, *, /, ^).
3. Stisknìte tlaèítko `=` pro zobrazení výsledku.

## Architektura

Projekt je rozdìlen do dvou hlavních tøíd:
1. **CalculatorView**  
   Hlavní tøída obsahující logiku uživatelského rozhraní a obsluhu událostí tlaèítek.

2. **Calculator**  
   Tøída zpracovávající všechny matematické operace. Poskytuje metody pro:
   - Sèítání
   - Odèítání
   - Násobení
   - Dìlení (s ošetøením dìlení nulou)
   - Mocnìní (vèetnì podpory záporných exponentù)


