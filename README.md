<div align="center">

# 🏛️ Interactive AR Science Museum
### المتحف العلمي التفاعلي


> An educational Augmented Reality application that brings five historical scientific instruments to life as interactive 3D models — simply point your camera at the target image and explore.

---

![Unity](https://img.shields.io/badge/Unity-2022.3%20LTS-black?style=for-the-badge&logo=unity)
![Vuforia](https://img.shields.io/badge/Vuforia-Engine%2010.x-blue?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Android-green?style=for-the-badge&logo=android)
![Language](https://img.shields.io/badge/Language-C%23-purple?style=for-the-badge&logo=csharp)
![License](https://img.shields.io/badge/License-Academic-orange?style=for-the-badge)

</div>

---

## 📖 Table of Contents

- [About The Project](#-about-the-project)
- [Demo](#-demo)
- [Screenshots](#-screenshots)
- [Features](#-features)
- [Scientific Instruments](#-scientific-instruments)
- [How It Works](#-how-it-works)
- [Getting Started](#-getting-started)
- [Booklet](#-booklet)
- [How To Use](#-how-to-use)
- [Project Structure](#-project-structure)
- [Built With](#-built-with)
- [Team](#-team)

---

## 🔬 About The Project

**Interactive AR Science Museum** is an educational Augmented Reality Android application developed as part of an AR & VR course project. The app transforms a printed scientific booklet into an immersive AR experience.

Users point their smartphone camera at one of five printed target images, and a fully interactive 3D model of the corresponding scientific instrument appears in real space above the image — complete with historical information about the instrument.

The goal is to bridge traditional printed educational material with modern AR technology, making learning about the history of science more engaging and memorable.

---

## 🎬 Demo

> 📹 **Watch the full demo video below:**

<!-- REPLACE the URL below with your actual demo video link (YouTube, Google Drive, etc.) -->
[![Demo Video](https://img.shields.io/badge/▶_Watch_Demo-Google_Drive-green?style=for-the-badge&logo=googledrive)](https://drive.google.com/file/d/1MSbuA1AEU16gQxsw1eTbuE_LKB-JfMeJ/view?usp=sharing)
<!-- Optional: embed a GIF preview -->
<!-- <img src="YOUR_GIF_URL_HERE" alt="Demo GIF" width="400"/> -->

---

## 📸 Screenshots

> *(Replace the placeholder links below with your actual screenshots)*

<div align="center">

| Start Screen | Vintage Phone AR | Camera AR |
|:---:|:---:|:---:|
| <img src="https://raw.githubusercontent.com/Mohanad06/AR-Science-Museum/main/screenshots/startscreen.jpeg" width="200"/> | <img src="https://raw.githubusercontent.com/Mohanad06/AR-Science-Museum/main/screenshots/Vintage Phone.jpeg" width="200"/> | <img src="https://raw.githubusercontent.com/Mohanad06/AR-Science-Museum/main/screenshots/Camera.jpeg" width="200"/> |
| *Vintage-themed main menu* | *Vintage Phone* | *Camera* |

| Microscope AR | Balance Scale AR | Gramophone AR |
|:---:|:---:|:---:|
| <img src="https://raw.githubusercontent.com/Mohanad06/AR-Science-Museum/main/screenshots/Microscope.jpeg" width="200"/> | <img src="https://raw.githubusercontent.com/Mohanad06/AR-Science-Museum/main/screenshots/Scaler.jpeg" width="200"/> | <img src="https://raw.githubusercontent.com/Mohanad06/AR-Science-Museum/main/screenshots/Gramophone.jpeg" width="200"/> |
| *Optical Microscope* | *Balance Scale* | *Gramophone* |

</div>

---

## ✨ Features

- 🎯 **Image Target Recognition** — Vuforia-powered detection of 5 unique printed targets
- 🗿 **Interactive 3D Models** — Fully rendered models appear in real AR space above each target
- 👆 **Touch Interaction** — Drag with one finger to rotate any model 360° in all directions
- 🌀 **Inertia Effect** — Models continue spinning smoothly after the finger is released
- 📋 **Info Panels** — Each model displays its name and historical/scientific information
- 🏛️ **Vintage UI Design** — Parchment-style theme consistent with the scientific museum aesthetic
- ❓ **Help System** — Built-in animated How-To-Use panel on the start screen
- 📱 **Fixed Portrait Mode** — Stable UI layout locked to portrait orientation

---

## 🔭 Scientific Instruments

| # | Instrument | Arabic Name | Key Fact |
|---|-----------|-------------|----------|
| 1 | ⚖️ Balance Scale | الميزان الحساس | Accuracy up to 0.001g — based on Archimedes' lever law |
| 2 | ☎️ Vintage Telephone | الهاتف الثابت | Invented by Graham Bell in 1876 |
| 3 | 🔬 Optical Microscope | الميكروسكوب الضوئي | Magnifies up to 1000× — uses light refraction |
| 4 | 📷 Photographic Camera | الكاميرا الفوتوغرافية | First camera invented in 1816 |
| 5 | 🎵 Gramophone | الجرامافون | Invented by Emile Berliner in 1887 |

---

## ⚙️ How It Works

```
[Launch App]
     │
     ▼
[Start Screen]
     │                    │
[Tap ? Help]         [Tap START]
     │                    │
[Show Instructions]  [Activate AR Camera]
                          │
                    [Point Camera at Target]
                          │
                  [Vuforia Detects Image]
                          │
                    [3D Model Appears]
                    [Info Panel Shows]
                          │
                  [User Rotates with Touch]
                          │
                  [Camera Moves Away]
                          │
                  [Model Resets & Hides]
```

---

## 🚀 Getting Started

### Prerequisites

- Android device running **Android 7.0 (API 24)** or higher
- Rear-facing camera
- Minimum **2GB RAM**

### Installation

**Option 1 — Direct APK Install:**
1. Download the latest APK from the [Releases](../../releases) page
2. Enable *Install from Unknown Sources* on your Android device
3. Open the APK file and install
4. Grant camera permission on first launch

**Option 2 — Build from Source:**
```bash
# Clone the repository
git clone https://github.com/YourUsername/AR-Science-Museum.git

# Open in Unity 2022.3 LTS
# File → Build Settings → Android → Build And Run
```

> **Requirements for building:** Unity 2022.3 LTS, Vuforia Engine 10.x, Android SDK (API 24+), IL2CPP backend

---
## 📘 BookLet

> يحتوي على جميع صور الـ Image Targets المستخدمة في التطبيق

<div align="center">

<a href="https://github.com/Mohanad06/AR-Science-Museum/raw/main/BookLet/BookLet.pdf">
  <img src="https://img.shields.io/badge/📥_Download_Booklet-PDF-blue?style=for-the-badge" />
</a>

</div>

> ⚠️ You must download or open the booklet to use the AR features of the app.
> ⚠️ If the PDF preview does not load on GitHub, please download the file or view it online.

---

## 📱 How To Use

1. **Download** the AR Booklet from the link above
2. **Print** the booklet (or open it on another screen)
1. **Open** the app on your Android device
2. **Tap START** on the main screen to activate the camera
3. **Print** the target images from the booklet (or display on screen)
4. **Point** your camera at any target image from the booklet — keep it flat and well-lit
5. **Watch** the 3D model appear above the image in real space
6. **Drag** with one finger to rotate the model in any direction
7. **Read** the information panel for historical details
8. **Move away** from the image to dismiss the model

> 💡 **Tips:**
> - Use good lighting — avoid dark rooms or direct sunlight on the page
> - Keep the target image flat on a stable surface
> - Maintain a distance of **20–40 cm** from the camera to the target

---

## 📁 Project Structure

```
AR-Science-Museum/
│
├── Assets/
│   ├── Scripts/
│   │   ├── StartButton.cs           # Scene transition & AR activation
│   │   ├── HelpPanelController.cs   # Help panel with fade animation
│   │   ├── ProductInfo.cs           # Vuforia tracking & UI display
│   │   └── ModelTouchController.cs  # Touch rotation with inertia
│   │
│   ├── Models/
│   │   ├── Scale/                   # Balance Scale 3D model
│   │   ├── Phone/                   # Vintage Telephone 3D model
│   │   ├── Microscope/              # Optical Microscope 3D model
│   │   ├── Camera/                  # Photographic Camera 3D model
│   │   └── Gramophone/              # Gramophone 3D model
│   │
│   ├── Scenes/
│   │   ├── StartScene.unity         # Main menu scene
│   │   └── ARScene.unity            # Core AR experience scene
│   │
│   ├── Images/                      # Vuforia target images
│   ├── Textures/                    # UI and background textures
│   └── StreamingAssets/Vuforia/     # Vuforia target database
│
├── Packages/                        # Unity package dependencies
├── ProjectSettings/                 # Unity project configuration
└── README.md
```

---

## 🛠️ Built With

| Technology | Purpose |
|-----------|---------|
| [Unity 2022.3 LTS](https://unity.com) | Game engine & AR scene management |
| [Vuforia Engine 10.x](https://developer.vuforia.com) | Image target recognition & AR tracking |
| [TextMeshPro](https://docs.unity3d.com/Manual/com.unity.textmeshpro.html) | High-quality UI text rendering |
| C# | Scripting & game logic |
| Android SDK (API 24+) | Android build target |

---

## 📋 Course Information

> This project was developed as part of the **AR & VR** course.
> **Year:** 2026

---

<div align="center">

**Made with ❤️ using Unity & Vuforia**

*Interactive AR Science Museum — المتحف العلمي التفاعلي*

</div>
