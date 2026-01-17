# How to Run This Project in Cursor

## Method 1: Using Cursor's Integrated Terminal (Easiest)

1. **Open the integrated terminal in Cursor:**
   - Press `` Ctrl + ` `` (backtick) or `` Cmd + ` `` on Mac
   - Or go to: `Terminal` → `New Terminal`

2. **Navigate to the project directory:**
   ```bash
   cd CSharpLearning
   ```

3. **Run the project:**
   ```bash
   dotnet run
   ```

4. **Select from the menu:**
   - Type a number (1-7) to explore different categories
   - Press Enter
   - View the output
   - Press any key to continue and return to menu

## Method 2: Using Cursor's Run Button

1. **Open `Program.cs`** in the editor

2. **Look for the "Run" button** at the top-right of the editor (play icon ▶️)

3. **Click the Run button** - Cursor will automatically build and run the project

## Method 3: Using Command Palette

1. **Open Command Palette:**
   - Press `Ctrl + Shift + P` (Windows/Linux) or `Cmd + Shift + P` (Mac)

2. **Type:** `dotnet: run`

3. **Select:** `.NET: Run Project`

## Method 4: Build First, Then Run

1. **Build the project:**
   ```bash
   dotnet build
   ```

2. **Run the executable:**
   ```bash
   dotnet run --project CSharpLearning
   ```

## Quick Test

To quickly verify everything works, run:
```bash
cd CSharpLearning
dotnet run
```

Then select option `1` to see basic programs in action!

## Troubleshooting

- **If `dotnet` command not found:**
  - Install .NET SDK from: https://dotnet.microsoft.com/download
  - Restart Cursor after installation

- **If build errors occur:**
  - Run `dotnet restore` first
  - Then `dotnet build`

- **To stop the program:**
  - Press `Ctrl + C` in the terminal
  - Or select option `0` from the menu
