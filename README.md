# 🤖 Mini GUI — Epson Robot Output Tracking

A lightweight desktop application built with **C# / .NET Framework** to support and monitor an **Epson robot** on a PCB production line — providing real-time output tracking, QR code station labeling, and direct robot control.

---

## 📋 Features

### 🏭 Production Line Tracking
- 📦 **Track PCB output** — counts and records each PCB that the Epson robot picks up on the production line
- 📊 **Real-time monitoring** — keeps operators informed of current production output at a glance
- 🏷️ **Station QR code label** — displays the station name as a QR code for easy identification on the line

### 🤖 Epson Robot Control
- ▶️ **Start robot program** — send start command directly to the Epson robot from the GUI
- ⏹️ **Stop robot program** — safely stop the robot program from the interface
- 🔌 **Direct connection** — communicates directly with the Epson robot controller

---

## 🛠️ Tech Stack

| Technology | Details |
|---|---|
| Language | C# |
| Framework | .NET Framework |
| UI | Windows Forms (WinForms) |
| Integration | Epson Robot Controller (direct connection) |
| Label | QR Code (station name) |
| IDE | Visual Studio |

---

## 🚀 Getting Started

### Prerequisites
- Windows OS
- Visual Studio 2019 or later
- .NET Framework 4.x
- Epson robot controller connected to the network/machine

### Installation
1. Clone the repository
```bash
git clone https://github.com/uuunuknik/Mini_GUI_Epson_For_Tracking_Output.git
```
2. Open `UI_Output_Labeling.sln` in Visual Studio
3. Build the solution (`Ctrl + Shift + B`)
4. Run the project (`F5`)

> ⚠️ **Note:** A physical Epson robot connection is required for full functionality. The app is designed for use in a production line environment.

---

## 📁 Project Structure

```
Mini_GUI_Epson_For_Tracking_Output/
├── UI_Output_Labeling/       # Main GUI application
├── SetupOutputLabeling/      # Setup/installer project
└── UI_Output_Labeling.sln
```

---

## 💡 Use Case

This tool was built for a real manufacturing environment where an **Epson robot picks up PCBs** on a production line. The GUI allows operators to:
- Start and stop the robot directly from a screen
- Track how many PCBs have been picked up in real time
- Identify the workstation quickly via a QR code label

It removes the need for manual counting and gives operators a simple, clean interface to manage and monitor the robot without touching the robot controller directly.

---

## 👨‍💻 Author

**uuunuknik** — [GitHub Profile](https://github.com/uuunuknik)

---

> *Built with C# | Designed for real industrial production line use*
