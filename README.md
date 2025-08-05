Project Summary: Voice Assistant "Cyrus"
---------------------------------------
This is a C# Windows Forms application that functions as a voice assistant, likely named Cyrus. Here’s what it includes:

Key Features & Components

    Voice Recognition:
      Uses System.Speech.Recognition.SpeechRecognitionEngine to listen and interpret voice commands.

    Speech Synthesis (Text-to-Speech):
      Uses SpeechSynthesizer to respond verbally to user commands.

    Graphical User Interface:
      Built using Windows Forms (Form1.cs), allowing interaction through a GUI.

    Web Automation Capabilities:
      Imports OpenQA.Selenium and OpenQA.Selenium.Chrome, indicating it can use Selenium to control a 
      web browser (e.g., open sites, search the web).
  
    Command Configuration:
      Likely reads commands from Commands.txt to determine how to respond to specific inputs.
-----------------------------------------------
Summary of What the Code Does (Full Picture)
------------------------------------------------
This Voice Assistant project includes:

| Feature               | Description                                                             |
| --------------------- | ----------------------------------------------------------------------- |
| 🎙️ Voice Recognition | Listens for specific commands using `System.Speech.Recognition`.        |
| 🗣️ Text-to-Speech    | Responds verbally using `SpeechSynthesizer`.                            |
| 🧾 Command File       | Loads commands from `Commands.txt` so users can customize interactions. |
| 🖥️ Windows Forms UI  | Runs as a desktop app with a graphical interface.                       |
| 🌐 Selenium Imported  | Web automation libraries are included but **not yet used**.             |
