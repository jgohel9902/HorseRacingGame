# Horse Racing Game

A C# Windows Forms application simulating a simple horse racing game with real-time leader updates and a race completion feature. This project is designed to demonstrate basic game logic, UI interaction, and timer-based animations in a Windows Forms application.

## Features

- **Start Button**: Initiates the race and resets horse positions.
- **Race Timer**: Controls the movement of each horse.
- **Leaderboard**: Displays the current leader and updates in real-time.
- **Finish Line**: Detects when a horse has crossed the finish line and announces the winner.
- **Reset Functionality**: Allows the race to be restarted without closing the application.


## Code Structure

- **Form1.cs**: Contains the main logic for the race, including methods for moving horses, updating the leaderboard, and detecting the race winner.
- **Resources**: 
  - `pictureBoxHorse1`, `pictureBoxHorse2`, `pictureBoxHorse3`: PictureBox controls representing the horses.
  - `labelLeader`: Label to display the leading horse.
  - `labelFinishLine`: Label marking the finish line.
- **Timer Control**: The timer controls the periodic updates to move horses across the racetrack.

## Requirements

- Visual Studio with .NET framework support
- Basic understanding of C# and Windows Forms

## Development Setup

1. **Initialize Components**: The `InitializeComponent()` method in `Form1.cs` sets up the form controls.
2. **Methods**:
   - `MoveHorse`: Randomly moves each horse across the screen.
   - `UpdateLeadingHorse`: Updates the leader display based on horse positions.
   - `CheckForWinner`: Checks if a horse has crossed the finish line.
   - `RaceFinished`: Ends the race and announces the winner.
