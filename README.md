# Dragon CLI Game

A terminal-based dragon collection and breeding simulator written in C# using .NET. Build habitats, grow food, breed dragons, and collect all dragons.

---
## Run Instructions
use `dotnet publish -r win-x64 --self-contained true` to create an executable
or `-r linux-x64` in linux or either `osx-x64` or `osx-arm64` for MacOS,
find the executable in `/bin/Release/net8.0/win-x64` or your architecture of choice.
## Programming / Coding

### Language, Tools, and Dependencies

| Component     | Details                                  |
|---------------|-------------------------------------------|
| Language      | C# 12                                     |
| Framework     | .NET 8                                    |
| Dependency    | Humanizer – for human-readable time formatting |

---

### Program Structure

- **Program.cs**  
  Main entry point; handles game loop and user interface.

- **Classes**  
  - `Dragon`: Includes name, elements, level, food required to upgrade, and rarity.  
  - `Habitat`: Holds dragons and generates gold; can be upgraded.  
  - `Farm`: Grows food using gold; different crops based on level.  
  - `Egg`: Created from breeding or purchased; hatched using an object factory.

---

### Data Persistence

- Uses Newtonsoft.Json for serialization and deserialization.
- Game data is saved to a file located in the User's AppData folder.
- Progress is saved manually from the main menu.

---

### Game Loop and UI

- Menus are controlled using `while` loops.
- The screen is cleared using:
  ```csharp
  Console.Clear();
  Console.WriteLine("\x1b[3J");
  ```
### Time Features
- Wait timers are implemented using the `DateTime` class
- Used for: Breeding, hatching, growing crops, upgrades, building
  
### Game Functionality
- When the game starts, we check for a save file on the users's AppData folder, if it does not exist, we create one
- As starter, we give the user a habitat and a dragon
- `Dragons` can be discovered, bred, fed and removed
- `Eggs` can be obtained thorugh purchasing or breeding and placed on the Hatchery
- `Habitats` generate gold depending on the dragons and their level
- `Farms` can be purchased from the store and grow crops

### Pictures
<img width="483" height="291" alt="Screenshot 2025-07-21 225034" src="https://github.com/user-attachments/assets/cfd0cfc9-3da9-465c-9f94-36ecff2bb56f" />
<img width="630" height="434" alt="Screenshot 2025-07-21 225015" src="https://github.com/user-attachments/assets/2d7a16ee-a516-46da-aa7f-429b7c66f826" />
<img width="439" height="330" alt="Screenshot 2025-07-21 223733" src="https://github.com/user-attachments/assets/37300987-3cfd-4b3b-b58a-19d705404e2f" />
<img width="265" height="304" alt="Screenshot 2025-07-21 223633" src="https://github.com/user-attachments/assets/2081d264-9676-4858-a70d-b990a37a7ca8" />
