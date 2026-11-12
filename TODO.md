# TODO

## Next up
- [X] **Delete**: move the code from `case 4` in `Main` into its own method (like `ChangeTaskStatus`), and handle the items below

## Bugs
- [x] Change status with an empty list: `getIndexFromUser(1, 0)` loops forever
- [x] Change status with one task: Y/N answer is never read, and the code falls through to the general prompt
- [X] Delete: `int.Parse` crashes on non-numeric input, so use `getIndexFromUser` instead
- [X] Delete: out-of-range number crashes (`ArgumentOutOfRangeException`)

## Edge cases
- [X] Display list when empty: show "No tasks" instead of printing nothing
- [X] Delete when the list is empty
- [X] Delete when there is only one task: confirm with Y/N instead of asking for a number
- [X] `PrintList` with one task prints no number, but delete asks for "its number"

## Cleanup
- [x] Typos in UI text: "taks", "Cange", "Chooce", "nter", "Statu"
- [X] Typos in names: `isContenue`, `ChoiseMenu`, `userChoise`
- [X] Naming convention: `getIndexFromUser` should be `GetIndexFromUser` (PascalCase for methods)
- [X] Remove unused `using System.ComponentModel.Design`
- [ ] `TaskItem.Id` is never used, so either use it or remove it
- [ ] Default case uses `Console.Write` and is unreachable anyway

## Ideas
- [ ] Edit task title
- [ ] Save/load tasks to a file (JSON)
- [x] README.md with a description
- [X] Screenshot in README (after the cleanup and edge cases are fixed)
