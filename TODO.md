# TODO

## Bugs
- [ ] Change status with an empty list: `getIndexFromUser(1, 0)` loops forever
- [ ] Change status with one task: Y/N answer is never read, and the code falls through to the general prompt
- [ ] Delete: `int.Parse` crashes on non-numeric input, so use `getIndexFromUser` instead
- [ ] Delete: out-of-range number crashes (`ArgumentOutOfRangeException`)

## Edge cases
- [ ] Display list when empty: show "No tasks" instead of printing nothing
- [ ] Delete when the list is empty
- [ ] Delete when there is only one task: confirm with Y/N instead of asking for a number
- [ ] `PrintList` with one task prints no number, but delete asks for "its number"

## Cleanup
- [ ] Typos in UI text: "taks", "Cange", "Chooce", "nter", "Statu"
- [ ] Typos in names: `isContenue`, `ChoiseMenu`, `userChoise`
- [ ] Naming convention: `getIndexFromUser` should be `GetIndexFromUser` (PascalCase for methods)
- [ ] Remove unused `using System.ComponentModel.Design`
- [ ] `TaskItem.Id` is never used, so either use it or remove it
- [ ] Default case uses `Console.Write` and is unreachable anyway

## Ideas
- [ ] Edit task title
- [ ] Save/load tasks to a file (JSON)
- [ ] README.md with a description and a screenshot
