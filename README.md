# SecurePanel: Student Registration & Card Generator System 🎓🛡️

An elegant, secure, and modern desktop application built using **C# Windows Forms (.NET)**. The project focuses on implementing pure programming logic for user authentication, error validation, security controls, and real-time data transfer between multiple forms without utilizing external databases.

---

## 📸 Project Showcase & UI Design

The application features a sleek, dark-themed user interface designed for an optimal and professional user experience.

### 1. Login & Security Shield Screen
An authentication screen with a modern aesthetic, containing an input validation system and a brute-force mitigation mechanism.
*Adds a 30-second security cooldown after 3 consecutive failed login attempts.*

### 2. Student Registration Panel
A clean workspace to collect student credentials, selecting their educational levels and dynamically checking multiple technical skills.



### 3. Generated Student ID Card
A dedicated dynamic interface that captures and prints all the collected student data onto an elegant digital ID card after a simulated processing phase.


---

## 🚀 Key Features & Logic Implemented

- **Smart Brute-Force Prevention:** Incorporates counter-logic and background `Timer` components to block malicious or repetitive login attempts by freezing inputs for 30 seconds.
- **Dynamic In-Memory Data Transfer:** Utilizes architectural `static` fields and state management to transfer strings, selections, and multiple combined flags between different forms seamlessly.
- **Strict Error Validation:** Features robust real-time text validation using `ErrorProvider` components and context-focused control validation handling (`CancelEventArgs`).
- **Smooth Visual Feedback:** Implements interactive UI elements like password visibility toggles (`PasswordChar`) and an automated `ProgressBar` loading routine.
- **Clean State Cleansing:** An automated structural component resets checkboxes, text areas, and radio options back to baseline with a single click.

---

## 🛠️ Tech Stack & Concepts Covered

- **Language:** C#
- **Framework:** Windows Forms (.NET)
- **UI Architecture:** Dark Mode Design Controls (`Panel`, `TextBox`, `RadioButton`, `CheckBox`, `ProgressBar`)
- **Core Engineering Concepts:**
  - State Management & Static Communication
  - Input Validation & Control Interception (`Validating` Events)
  - Time-Triggered Callbacks (`Timer.Tick` routines)
  - Thread Management & Iteration Control

---

## ⚙️ How to Run the Project

1. Clone this repository to your local machine:
   ```bash
   git clone [https://github.com/Aissamfreee/EduCard-System.git](https://github.com/Aissamfreee/EduCard-System.git)
