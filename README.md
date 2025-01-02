# Ranked Matches Calculator

## Description

This project is a simple **Ranked Matches Calculator** built in C#. It calculates the player's match balance (wins - losses) and determines their rank based on the number of victories. The program utilizes a **`switch-case` structure** to evaluate the rank efficiently, ensuring clean and readable code.

While this implementation uses `switch-case`, other approaches such as `if-else` statements or arrays with loops could also be used to achieve the same result. These alternatives are mentioned for educational purposes but are not implemented in this version.

---

## Features

- Calculates the balance of ranked matches using the formula:
  \[
  \text{Balance} = \text{Wins} - \text{Losses}
  \]
- Determines the player's rank based on the number of wins:
  - **Iron**: Less than 10 wins
  - **Bronze**: Between 11 and 20 wins
  - **Silver**: Between 21 and 50 wins
  - **Gold**: Between 51 and 80 wins
  - **Diamond**: Between 81 and 90 wins
  - **Legendary**: Between 91 and 100 wins
  - **Immortal**: More than 100 wins
- Displays a message summarizing the player's balance and rank.

---

## How It Works

1. The program prompts the user to input:
   - The number of victories (`Wins`).
   - The number of defeats (`Losses`).
2. It calculates the match balance using a simple subtraction.
3. Using a `switch-case` structure, it evaluates the rank based on predefined thresholds.
4. Finally, it outputs a message displaying the player's balance and rank.

---

## Example Output

Enter the number of wins:
45
Enter the number of losses:
20
The Hero has a balance of 25 and is at the level Silver.

---

## Possible Improvements

While this implementation uses `switch-case`, other approaches could be explored for learning purposes:
- **Using `if-else`:** A straightforward way to handle conditions but can become verbose with many cases.
- **Using Arrays and Loops:** A scalable solution that allows for dynamic thresholds and ranks.

These methods are not implemented in this version but are worth considering for future enhancements or educational exploration.

---

## Technologies Used

- **Language:** C#
- **IDE:** Visual Studio Code
- **Version Control:** Git/GitHub

---
