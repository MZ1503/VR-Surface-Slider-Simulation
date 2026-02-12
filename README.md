# VR-Surface-Slider-Simulation
A Unity 3D Virtual Reality simulation developed as a B.Tech final project, featuring modular system design and rigorous QA testing.

Markdown
# VR Surface Slider (Unity 3D & C#)
This project is a stereoscopic Virtual Reality (VR) skiing simulation developed for my Bachelor of Technology. It features a modular architecture and was used to implement formal software testing methodologies.

## 🛠 System Architecture
The system is divided into four primary modules:
* **Graphics Module:** Manages the visual environment (Hill, Player, Slalom Gates).
* **Physics Module:** Implements varied surface friction (Ice, Rubber, Wood).
* **Audio Module:** Handles collision and movement sound effects.
* **GUI Module:** Manages VR head-tracking input and real-time UI updates.

## 🧪 Testing & Quality Assurance
The project served as a framework to apply and document various testing approaches:
* **Black Box Testing:** Utilized Equivalence Classing and Boundary Value Analysis for physics triggers.
* **White Box Testing:** Performed Control-flow and Data-flow testing to ensure script integrity.
* **Logic Validation:** Debugged the `GameManager` to ensure 100% accuracy in score persistence and collision penalties.

## 💻 Core Logic (GameManager.cs)
The central controller manages the entire game lifecycle, including:
* Event-driven logic for gate passing (+5s penalty for misses).
* State management (GameInProgress, Reset, EndGame).
* Persistent score tracking (Best Time vs. Last Time)
